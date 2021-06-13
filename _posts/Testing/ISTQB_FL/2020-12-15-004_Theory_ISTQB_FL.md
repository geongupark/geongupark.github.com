---
title:  "[004] ISTQB foundation level 실라버스(v3.1) 이론 - 테스트 기법"
excerpt: "실라버스(v3.1)를 기반으로한 ISTQB foundation level 이론(요약, 정리)이에요. 테스트 기법에 대해 알아봐요. ISTQB CTFL에 도전하실 분들 참고하세요~!"
toc: true
#toc_label:
toc_sticky: true
#toc_icon: "heart"
#teaser: 

# color
# 주황색 : <span style="color:#FF8000"></span>
# 파란색 : <span style="color:#0000FF"></span>
# 빨간색 : <span style="color:#FF0000"></span>
# 초록색 : <span style="color:#00FF00"></span>
# 보라색 : <span style="color:#9A2EFE"></span>

categories:
  - ISTQB
tags:
  - ISTQB
  - Foundation level
  - FL
  - CTFL
  - 테스팅
  - SW테스팅
  - 자격증
  - 테스팅자격증
  - STEN
  - 요약
  - 정리
  - 테스트 기법
last_modified_at: 2020-12-15T18:06:00-05:00
---

*※ "ISTQB의 syllabus v3.1을 기준으로 작성되었습니다."*  

본 문서는 ISTQB CTFL 공부를 하며 실라버스 내 각 chapter 별 내포 된 의미 및 뉘앙스를 요약한 문서이다. 추후 실무에 적용 시 곧바로 찾아 볼 수 있도록 굵직한 내용 위주로 정리했다.<br><br><br>

# 4. 테스트 기법
## 4.1 테스트 기법의 종류
### 4.1.1 테스트 기법의 종류와 특성
- 블랙박스 테스팅 : I/O에 집중하고 내부 구조는 고려하지 않음
- 화이트박스 테스팅 : 내부구조와 처리에 집중한다.
- 경험기반 테스팅 : 개발자, 테스터, 사용자의 경험을 바탕으로 테스트를 설계, 구현, 실행하는 방법

## 4.2 블랙박스 테스트 기법
### 4.2.1 동등 분할
- 입력 범위를 기준에 근거하여 여러 클래스로 나눈다.
- 각 클래스의 모든 값은 동일한 output을 낸다는 가정을 하여 대표값 만으로 평가를 구성하는 방법이다.
- 커버리지 : <span style="color:#0000FF">최소한 한개의 값으로 테스트한 동등 분할 수/모든 동등 분할 수 (%)</span>
- ex) 직원 보너스 계산 소프트웨어 - 실라버스 sample exam A  

```
Q. 직원의 보너스를 계산하는 소프트웨어가 있다. 보너스는 음수는 될 수 없지만 0은 될 수 있다. 보너스는 근무 기간에 따라 산정한다.  
- 2년이하  
- 2년 초과 5년 미만  
- 5년이상 10년 이하 또는 10년 초과  
보너스를 개산하기 위해 모든 유효 동등 파티션을 커버하는 최소 테스트 케이스 수는?

A.
- 단위를 정수로 가정하면 아래의 그래프를 그릴 수 있다.
- 이 중 유효 동등 파티션을 커버하는 최소 테스트 케이스 수는 유효 동등 파티션 개수인 4개이다.
- 즉, 4개의 테스트 케이스로 평가를 진행했다면 "최소한 한개의 값으로 테스트한 동등 분할 수/모든 동등 분할 수 (%)" = 4/5 * 100 = 80%가 된다.
```
![동등 분할 예](/assets/images/201212_Theory_ISTQB/4_2_1.png "동등 분할 예")
<!--
[![](https://mermaid.ink/img/eyJjb2RlIjoiZmxvd2NoYXJ0IExSXG4gICAtaW5mPC0tLT5867mE7Jyg7ZqofC0xLS0tMFxuICAgMDwtLS0-fOycoO2aqHwyLS0tMzwtLS0-fOycoO2aqHw0XG4gICA0LS0tNTwtLS0-fOycoO2aqHwxMFxuICAgMTAtLS0xMTwtLS0-fOycoO2aqHwraW5mXG4gICAiLCJtZXJtYWlkIjp7fSwidXBkYXRlRWRpdG9yIjpmYWxzZX0)](https://mermaid-js.github.io/mermaid-live-editor/#/edit/eyJjb2RlIjoiZmxvd2NoYXJ0IExSXG4gICAtaW5mPC0tLT5867mE7Jyg7ZqofC0xLS0tMFxuICAgMDwtLS0-fOycoO2aqHwyLS0tMzwtLS0-fOycoO2aqHw0XG4gICA0LS0tNTwtLS0-fOycoO2aqHwxMFxuICAgMTAtLS0xMTwtLS0-fOycoO2aqHwraW5mXG4gICAiLCJtZXJtYWlkIjp7fSwidXBkYXRlRWRpdG9yIjpmYWxzZX0)
-->

### 4.2.2 경계값 분석
- 동등 분할의 확장형으로 각 클래스(파티션)가 순서화되어 있고, 숫자 또는 연속 데이터로 구성된 경우에만 적용한다.
- 2-value, 3-value 경계값이 있다.
- 커버리지 : 테스트한 경계 값의 수 / 식별한 모든 경계 값의 수 (%)
- ex) 속도 제어 및 알림 시스템 - 실라버스 sample exam A

```
Q. 속도 제어 및 알림 시스템이 다음과 같이 동작한다
- 50 km/h 이하로 주행 시 아무 일도 일어나지 않음
- 50 km/h 보다 빠르지만, 55km/h 이하인 경우 경고 메시지 표시
- 55 km/h 보다 빠르지만, 60 km/h 이하로 주행 시 벌금 부과
- 60 km/h 보다 빠르게 주행 시 운전 면허 중지
속도 단위 Km/h는 시스템에서 정수만 가능
동등 클래스(equivalence classes) 경계에 있는 값만을 선택하는 경계 값 분석을 적용해 식별할 수 있는 값 세트?

A. 
> 2-value 경계값 : (50, 51), (55, 56), (60, 61)
> 3-value 경계값 : (49, 50, 51), (54, 55, 56), (59, 60, 61) 
```

- 2-value 경계값 분석  
![2-value 경계값 분석](/assets/images/201212_Theory_ISTQB/4_2_2_a.png "2-value 경계값 분석")
<!--
[![](https://mermaid.ink/img/eyJjb2RlIjoiZmxvd2NoYXJ0IExSXG4gICAtaW5mPC0tLT41MC0tLTUxXG4gICA1MTwtLS0-NTUtLS01NjwtLS0-NjBcbiAgIDYwLS0tNjE8LS0tPitpbmZcbiAgICIsIm1lcm1haWQiOnt9LCJ1cGRhdGVFZGl0b3IiOmZhbHNlfQ)](https://mermaid-js.github.io/mermaid-live-editor/#/edit/eyJjb2RlIjoiZmxvd2NoYXJ0IExSXG4gICAtaW5mPC0tLT41MC0tLTUxXG4gICA1MTwtLS0-NTUtLS01NjwtLS0-NjBcbiAgIDYwLS0tNjE8LS0tPitpbmZcbiAgICIsIm1lcm1haWQiOnt9LCJ1cGRhdGVFZGl0b3IiOmZhbHNlfQ)
-->
- 3-value 경계값 분석  
![3-value 경계값 분석](/assets/images/201212_Theory_ISTQB/4_2_2_b.png "3-value 경계값 분석")
<!--
[![](https://mermaid.ink/img/eyJjb2RlIjoiZmxvd2NoYXJ0IExSXG4gICAtaW5mPC0tLS0-NDktLS01MC0tLTUxXG4gICA1MTwtLS0tPjU0LS0tNTUtLS01NjwtLS0tPjU5LS0tNjBcbiAgIDYwLS0tNjE8LS0tLT4raW5mXG4iLCJtZXJtYWlkIjp7fSwidXBkYXRlRWRpdG9yIjpmYWxzZX0)](https://mermaid-js.github.io/mermaid-live-editor/#/edit/eyJjb2RlIjoiZmxvd2NoYXJ0IExSXG4gICAtaW5mPC0tLS0-NDktLS01MC0tLTUxXG4gICA1MTwtLS0tPjU0LS0tNTUtLS01NjwtLS0tPjU5LS0tNjBcbiAgIDYwLS0tNjE8LS0tLT4raW5mXG4iLCJtZXJtYWlkIjp7fSwidXBkYXRlRWRpdG9yIjpmYWxzZX0)
-->

### 4.2.3 결정 테이블 테스팅
- 시스템이 구현해야 하는 복잡한 비즈니스 규칙을 기록하는 방법이다.
- 시스템의 조건(Input), 예상 동작(Output)을 식별한다.
- 전체 결정 테이블에는 모든 조건 조합을 포괄 할 수 있는 충분한 열(테스트 사례)이 있다.
- 결과에 영향을 미치지 않는 열을 삭제하면 테스트 케이스 수를 상당히 줄일 수 있다.
- 커버리지 : 최소 한개의 테스트 케이스로 테스트 한 결정 규칙의 수/ 식별한 모든 결정 규칙의 수(%)

| 항목 | 조건의 조합 |
|:---|:---|
|입력조건|참과 거짓으로 표현되는 조건|
|Trigger 조건|동작을 유발 시키는 조건|
|예상결과|각 Triggering conditions의 예상결과|

- ex) 결정 테이블 테스트 케이스 도출 예 ([link](https://m.blog.naver.com/PostView.nhn?blogId=wisestone2007&logNo=220850784642&proxyReferer=https:%2F%2Fwww.google.com%2F))


### 4.2.4 상태 전이 테스팅
- 소프트웨어의 가능한 상태뿐만 아니라 소프트웨어 상태 간의 전이 방법을 명시한 모델을 통한 평가이다.
- 커버리지 : 상태 커버리지(state coverage), 전이 커버리지(transition coverage), decision, condition, MC/DC 등이 있다.

### 4.2.5 유스케이스 테스팅
- 액터(actor)와 대상간의 관계를 나타낸 유스케이스를 기반으로 평가를 진행
- 정의한 기본 동작과 오류 처리를 수행하도록 평가를 설계한다.
- 커버리지 : 테스트한 유스케이스 수/ 모든 유스케이스 동작 수 (%)

## 4.3 화이트박스 테스트 기법
- 화이트 박스 테스팅은 대상 시스템의 내부 구조를 기반으로 한다.

### 4.3.1 구문 테스팅과 커버리지
- 코드의 잠재적 실행 가능 구문을 수행.
- 커버리지 : 실행한 구문의 수 / 테스트 대상의 모든 실행 가능한 구문의 수
- ex) 구문 테스팅 예제

```
Q. 실행 가능한 구문은 몇개인가?
begin
  x = 3;
  erase(x);
  write("hello world");
  read(y);
end

A. 4개
```

### 4.3.2 결정 테스팅과 커버리지
- 코드에 존재하는 결정문을 실행하고 결정문의 결과에 따라 실행되는 코드를 평가하는 방법.
- 커버리지 : 테스트로 실행된 결정문 결과의 수 / 테스트 대상의 가능한 모든 결정문 결과의 수
- ex) 결정 테스팅 예제

```
Q. 코드의 결정문 결과는 몇개인가?
switch (i){
  case 1 : A();
  case 2 : B();
  case 3 : C();
  case 4 : D();
}

A. 어느 조건에도 해당 되지 않는 default 까지 합쳐서 5개
```

### 4.3.3 구문 및 결정 테스팅의 가치
- 100% 결정 커버리지는 100% 구문 커버리지를 보장한다.
- 그 반대는 성립하지 않는다.


## 4.4 경험 기반 테스트 기법

### 4.4.1 오류 추정
- 유사 제품에서 주로 발생한 오류, 제품의 과거 동작 등 과거의 경험을 기반으로 오류 결함 및 장애 발생을 예측하는 평가

### 4.4.2 탐색적 테스팅
- 명세가 충분하지 않거나 적은 경우 사용하는 방법
- 테스트 차터를 기반으로 평가 수행 후 이상한 부분을 도출하여 동적으로 평가를 설계하여 평가 진행

### 4.4.3 체크리스트 기반 테스팅
- 체크리스트에 기록된 테스트 컨디션을 커버하기 위해 테스트를 설계, 구현, 실행한다.
<br>
<br>
<br>