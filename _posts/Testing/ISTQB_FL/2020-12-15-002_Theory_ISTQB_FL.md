---
title:  "[002] ISTQB foundation level 실라버스(v3.1) 이론 - 소프트웨어 개발 수명 주기와 테스팅"
excerpt: "실라버스(v3.1)를 기반으로한 ISTQB foundation level 이론(요약, 정리)이에요. 소프트웨어 개발 수명 주기와 테스팅을 배워봐요. ISTQB CTFL에 도전하실 분들 참고하세요~!"
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
last_modified_at: 2020-12-15T18:06:00-05:00
---

*※ "ISTQB의 syllabus v3.1을 기준으로 작성되었습니다."*  

본 문서는 ISTQB CTFL 공부를 하며 실라버스 내 각 chapter 별 내포 된 의미 및 뉘앙스를 요약한 문서이다. 추후 실무에 적용 시 곧바로 찾아 볼 수 있도록 굵직한 내용 위주로 정리했다.<br><br><br>


# 2. 소프트웨어 개발 수명 주기와 테스팅

## 2.1 소프트웨어 개발 수명주기 모델

### 2.1.1 소프트웨어 개발과 소프트웨어 테스팅
- 어떤 소프트웨어 개발 수명주기 모델을 차용하더라도 개발 주기 초기에 테스팅을 시작하면 시간과 비용을 절약할 수 있다.
- 순차적 개발모델 : [Waterfall](#2111 "> 개발활동 끝나고 테스트 활동 수행"), [V-cycle](#2112 "> 테스트를 개발 프로세스 초반에 병렬적으로 수행")
- 반복적 점진적 개발 모델 : [TDD(Test driven development)](#2113 "> 테스트 케이스 먼저 작성 후 개발 수행, 기능을 조금씩 추가하며 이 과정을 반복")

### 2.1.2 정황에 따른 소프트웨어 개발 수명주기 모델
- 앞서 언급했듯 테스트 정황 및 제품 특성에따라 소프트웨어 개발 수명주기 모델은 수정될 수 있다.

## 2.2 테스트 레벨
- 테스트 레벨은 컴포넌트 테스팅, 통합 테스팅, 시스템 테스팅, 인수 테스팅의 4가지로 구성된다.
- V-cycle의 우측 단계를 나타낸다. V-cycle의 좌측은 [verification](#2221 "> 시스템이 주어진 명세를 만족하는지 평가")을 나타내고 우측은 [validation](#2222 "> 시스템이 사용자 요구사항 및 환경에 적합한지 평가")을 나타낸다.
- V-cycle과 앞서 배운 테스트 프로세스는 동시에 병렬적으로 진행되니 시간 순서로 함께 이해하면 좋다.
![V-cycle의 테스트 레벨](/assets/images/201212_Theory_ISTQB/2_2_a.png "V-cycle의 테스트 레벨")
![동적 테스트 프로세스](/assets/images/201212_Theory_ISTQB/2_2_b.png "동적 테스트 프로세스")
<!--
[![](https://mermaid.ink/img/eyJjb2RlIjoiZmxvd2NoYXJ0IExSXG5cbiAgICBzdWJncmFwaCBsYXllcjRcbiAgICAgICAg7JqU6rWs7IKs7ZWt67aE7ISdIC0tLSDsnbjsiJjthYzsiqTtirhcbiAgICBlbmRcbiAgICBzdWJncmFwaCBsYXllcjNcbiAgICAgICAg67mE7KaI64uI7Iqk7ISk6rOEIC0tLSDsi5zsiqTthZzthYzsiqTtirhcbiAgICBlbmRcblxuICAgIHN1YmdyYXBoIGxheWVyMlxuICAgICAgICDsi5zsiqTthZzshKTqs4QgLS0tIO2Gte2Vqe2FjOyKpO2KuFxuICAgIGVuZFxuICAgIHN1YmdyYXBoIGxheWVyMVxuICAgICAgICDsvZTrlKkgLS0tIOy7tO2PrOuEjO2KuO2FjOyKpO2KuFxuICAgIGVuZFxuICAgIOyalOq1rOyCrO2Vreu2hOyEnSAtLT4g67mE7KaI64uI7Iqk7ISk6rOEXG4gICAg7Iuc7Iqk7YWc7YWM7Iqk7Yq4IC0tPiDsnbjsiJjthYzsiqTtirhcbiAgICDruYTspojri4jsiqTshKTqs4QgLS0-IOyLnOyKpO2FnOyEpOqzhFxuICAgIO2Gte2Vqe2FjOyKpO2KuCAtLT4g7Iuc7Iqk7YWc7YWM7Iqk7Yq4XG4gICAg7Iuc7Iqk7YWc7ISk6rOEIC0tPiDsvZTrlKlcbiAgICDsu7Ttj6zrhIztirjthYzsiqTtirggLS0-IO2Gte2Vqe2FjOyKpO2KuFxuXG5cbiIsIm1lcm1haWQiOnt9LCJ1cGRhdGVFZGl0b3IiOmZhbHNlfQ)](https://mermaid-js.github.io/mermaid-live-editor/#/edit/eyJjb2RlIjoiZmxvd2NoYXJ0IExSXG5cbiAgICBzdWJncmFwaCBsYXllcjRcbiAgICAgICAg7JqU6rWs7IKs7ZWt67aE7ISdIC0tLSDsnbjsiJjthYzsiqTtirhcbiAgICBlbmRcbiAgICBzdWJncmFwaCBsYXllcjNcbiAgICAgICAg67mE7KaI64uI7Iqk7ISk6rOEIC0tLSDsi5zsiqTthZzthYzsiqTtirhcbiAgICBlbmRcblxuICAgIHN1YmdyYXBoIGxheWVyMlxuICAgICAgICDsi5zsiqTthZzshKTqs4QgLS0tIO2Gte2Vqe2FjOyKpO2KuFxuICAgIGVuZFxuICAgIHN1YmdyYXBoIGxheWVyMVxuICAgICAgICDsvZTrlKkgLS0tIOy7tO2PrOuEjO2KuO2FjOyKpO2KuFxuICAgIGVuZFxuICAgIOyalOq1rOyCrO2Vreu2hOyEnSAtLT4g67mE7KaI64uI7Iqk7ISk6rOEXG4gICAg7Iuc7Iqk7YWc7YWM7Iqk7Yq4IC0tPiDsnbjsiJjthYzsiqTtirhcbiAgICDruYTspojri4jsiqTshKTqs4QgLS0-IOyLnOyKpO2FnOyEpOqzhFxuICAgIO2Gte2Vqe2FjOyKpO2KuCAtLT4g7Iuc7Iqk7YWc7YWM7Iqk7Yq4XG4gICAg7Iuc7Iqk7YWc7ISk6rOEIC0tPiDsvZTrlKlcbiAgICDsu7Ttj6zrhIztirjthYzsiqTtirggLS0-IO2Gte2Vqe2FjOyKpO2KuFxuXG5cbiIsIm1lcm1haWQiOnt9LCJ1cGRhdGVFZGl0b3IiOmZhbHNlfQ)
[![](https://mermaid.ink/img/eyJjb2RlIjoiZmxvd2NoYXJ0IExSXG5cbiAgQSgxLiBUZXN0IHBsYW5uaW5nKS0tPkIoMi4gVGVzdCBtb25pdG9yaW5nIGFuZCBjb250cm9sKS0tPkMoNy4gVGVzdCBjb21wbGV0aW9uKVxuXG4gIHN1YmdyYXBoIEV4ZWN1dGlvbl9wcm9jZXNzXG4gICAgRCgzLiBUZXN0IGFuYWx5c2lzKS0tPkUoNC4gVGVzdCBkZXNpZ24pLS0-Rig1LiBUZXN0IGltcGxlbWVudGF0aW9uKS0tPkcoNi4gVGVzdCBleGVjdXRpb24pXG4gIGVuZFxuXG4gIEEtLT5EXG4gIEctLT5DXG4gIEI8LS0-RXhlY3V0aW9uX3Byb2Nlc3NcblxuIHN0eWxlIEEgZmlsbDojRkNGXG4gc3R5bGUgQiBmaWxsOiNGQ0ZcbiBzdHlsZSBDIGZpbGw6I0ZDRlxuIHN0eWxlIEQgZmlsbDojQ0NGXG4gc3R5bGUgRSBmaWxsOiNDQ0ZcbiBzdHlsZSBGIGZpbGw6I0NDRlxuIHN0eWxlIEcgZmlsbDojQ0NGXG4iLCJtZXJtYWlkIjp7fSwidXBkYXRlRWRpdG9yIjpmYWxzZX0)](https://mermaid-js.github.io/mermaid-live-editor/#/edit/eyJjb2RlIjoiZmxvd2NoYXJ0IExSXG5cbiAgQSgxLiBUZXN0IHBsYW5uaW5nKS0tPkIoMi4gVGVzdCBtb25pdG9yaW5nIGFuZCBjb250cm9sKS0tPkMoNy4gVGVzdCBjb21wbGV0aW9uKVxuXG4gIHN1YmdyYXBoIEV4ZWN1dGlvbl9wcm9jZXNzXG4gICAgRCgzLiBUZXN0IGFuYWx5c2lzKS0tPkUoNC4gVGVzdCBkZXNpZ24pLS0-Rig1LiBUZXN0IGltcGxlbWVudGF0aW9uKS0tPkcoNi4gVGVzdCBleGVjdXRpb24pXG4gIGVuZFxuXG4gIEEtLT5EXG4gIEctLT5DXG4gIEI8LS0-RXhlY3V0aW9uX3Byb2Nlc3NcblxuIHN0eWxlIEEgZmlsbDojRkNGXG4gc3R5bGUgQiBmaWxsOiNGQ0ZcbiBzdHlsZSBDIGZpbGw6I0ZDRlxuIHN0eWxlIEQgZmlsbDojQ0NGXG4gc3R5bGUgRSBmaWxsOiNDQ0ZcbiBzdHlsZSBGIGZpbGw6I0NDRlxuIHN0eWxlIEcgZmlsbDojQ0NGXG4iLCJtZXJtYWlkIjp7fSwidXBkYXRlRWRpdG9yIjpmYWxzZX0)
-->

### 2.2.1 컴포넌트 테스팅
- 목적 : 컴포넌트의 기능/비기능 동작이 설계 및 명세와 일치하는지 판단
- 테스트 베이시스 : 상세 설계, 코드, 모델, 컴포넌트 명세
- 평가 대상 : 모듈, 코드, 데이터 구조, 클래스

### 2.2.2 통합 테스팅
- 목적 : 컴포넌트나 시스템 간의 상호작용에 초점하여 인터페이스의 기능/비기능이 설계 및 명세와 일치하는지 판단
- 테스트 베이시스 : 인터페이스 및 통신 프로토콜 명세, 유스케이스, 시스템 아키텍쳐
- 평가 대상 : 서브시스템, 인터페이스

### 2.2.3 시스템 테스팅
- 목적 : 전체 시스템의 기능/비기능 동작이 설계 및 명세와 일치하는지 판단
- 테스트 베이시스 : 시스템 요구사항 명세, 유스케이스, state diagram
- 평가 대상 : Application, 제품

### 2.2.4 인수 테스팅
- 목적 : 고객(최종 사용자) 환경에서 사용할 준비가 되었는지 판단, <span style="color:#FF0000">결함 발견이 목적이 아니다! risk 없어야한다!</span>
- 테스트 베이시스 : 비즈니스 프로세스, 비즈니스 요구사항, 유스케이스
- 평가 대상 : 시스템의 비즈니스 프로세스, 유지보수 프로세스

## 2.3 테스트 유형
1. Blackbox testing : 기능/비기능 테스팅
2. Whitebox testing
3. 변경 관련 테스팅 

### 2.3.1 기능 테스팅
- 완전성, 정확성, 적합성 등과 같은 기능 품질 특성을 평가한다.

### 2.3.2 비기능 테스팅
- 신뢰성, 성능 효율성, 보안성, 호환성, 사용성 등과 같은 비기능 품질 특성을 평가한다.

### 2.3.3 Whitebox testing
- 컴포넌트나 시스템의 아키텍쳐 및 구조가 정확하고 완전하며 명시된 것과 일치하는지 평가한다.

### 2.3.4 변경 관련 테스팅
- 수정에 의한 효과를 평가한다. 결함이 수정되었는지는 <span style="color:#0000FF">확인 테스팅</span>을 통해 평가하고 수정에 의해 의도하지 않은 영향이 있는지 <span style="color:#0000FF">리그레션 테스팅</span>으로 평가한다.
- agile 개발 방법과 같은 점진 반복적 개발 모델에 주로 사용된다.

## 2.4 유지보수 테스팅
- 제품이 고객 환경에 배포되고 나면 유지보수가 필요하다.
- 시스템의 수명동안 비기능 특성에 대한 유지보수가 특히 중요하다.

### 2.4.1 유지보수가 필요한 상황
- 개선을 위한 변경, 이관을 위한 변경, 단종, 장시간 저장 데이터 신뢰성, 여전히 서비스하고 있는 기능이 정상 동작할거라는 확신을 얻기 위해

### 2.4.2 유지보수를 위한 영향도 분석
- 유지보수 후 영향도 분석을 통해 해당 변경점을 적용할지 말지 결정할 수 있다.  
<br>
<br>
<br>
