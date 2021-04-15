---
title:  "[001] ISTQB foundation level 실라버스(v3.1) 이론"
excerpt: "실라버스(v3.1)를 기반으로한 ISTQB foundation level 이론이에요. ISTQB CTFL에 도전하실 분들 참고하세요~!"
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

# 1. 테스팅의 기초

## 1.1 테스팅이란 무엇인가?
임베디드 시스템 테스팅을 전공하고 관련 업무를 하고 있지만 **"테스팅이란 무엇인가요?"** 라는 질문에 한마디로 대답하는 것은 쉽지 않다.
하지만 실라버스 학습을 끝낸 지금은 답을 할 수 있다. 
> "테스팅은 <span style="color:#FF0000">결함이 없음을 보장하는 것이 아닌</span> SW의 품질을 측정하고 운영 중 <span style="color:#0000FF">장애 발생 가능성을 줄이는 하나의 방법</span>이다"  

주의할 점은 테스팅은 다양한 활동을 포함하는 프로세스라는 것이다. 테스트 수행은 그 많은 활동 중 하나일 뿐이다. 

### 1.1.1 테스팅의 일반적인 목적
- 명시된 요구사항이 충족 되었는지 확인
- 작업 산출물(요구사항, 설계, 소스 코드 등) 평가에 의한 결함 예방
- 장애 및 결함 발견과 이에 따른 부적절한 소프트웨어 품질의 리스크 레벨 감소

### 1.1.2 테스팅과 디버깅
- 테스팅 : 장애 및 결함을 발견하는 것
- 디버깅 : 결함에 대한 원인을 밝혀 수정하는 것
> 테스팅 → 디버깅 → 확인 테스팅 → 디버깅 ...  

## 1.2 테스팅이 왜 필요한가?
테스팅이 필요한 이유는 [1.1.1 테스팅의 일반적인 목적](#111-테스팅의-일반적인-목적 "> 요구사항 충족 확인, 결함예방, 품질 리스크 레벨 감소")이 답이 될 수 있다.

### 1.2.1 성공을 위한 테스팅의 기여
테스팅은 개발 프로세스 <span style="color:#0000FF">전 과정에 기여</span>를 하며 이를 통해 <span style="color:#0000FF">결함 예방/발견</span>을 할 수 있다. (요구사항 리뷰, 시스템 설계, 코드 개발, 제품 릴리즈 전 등)

### 1.2.2 품질 보증과 테스팅
- 품질 보증과 테스팅은 다른 개념이다.
- Quality management(QM)에 Quality assurance(QA)와 Quality control(QC)이 포함된다.
- Testing은 QC에 해당된다.
- QC는 QA에게 테스트 데이터를 제공하여 프로세스의 개선을 도우며 QA는 QC에 프로세스를 제공한다.
![QM,QA,QC의 관계](/assets/images/201212_Theory_ISTQB/1_2_2.png "QM,QA,QC의 관계")

<!--
[![](https://mermaid.ink/img/eyJjb2RlIjoiZmxvd2NoYXJ0IFRCXG5cdHN1YmdyYXBoIFFNXG5cdFx0c3ViZ3JhcGggUUFcblx0XHRlbmRcblx0XHRzdWJncmFwaCBRQ1xuXHRcdFx0dGVzdGluZ1xuXHRcdGVuZFxuXHRcdFFBIC0tPiB87ZSE66Gc7IS47IqkIOygnOqztXxRQy0tPnzthYzsiqTtjIUg642w7J207YSwIOygnOqztXxRQVxuXHRlbmQiLCJtZXJtYWlkIjp7InRoZW1lIjoiZGVmYXVsdCJ9LCJ1cGRhdGVFZGl0b3IiOmZhbHNlfQ)](https://mermaid-js.github.io/mermaid-live-editor/#/edit/eyJjb2RlIjoiZmxvd2NoYXJ0IFRCXG5cdHN1YmdyYXBoIFFNXG5cdFx0c3ViZ3JhcGggUUFcblx0XHRlbmRcblx0XHRzdWJncmFwaCBRQ1xuXHRcdFx0dGVzdGluZ1xuXHRcdGVuZFxuXHRcdFFBIC0tPiB87ZSE66Gc7IS47IqkIOygnOqztXxRQy0tPnzthYzsiqTtjIUg642w7J207YSwIOygnOqztXxRQVxuXHRlbmQiLCJtZXJtYWlkIjp7InRoZW1lIjoiZGVmYXVsdCJ9LCJ1cGRhdGVFZGl0b3IiOmZhbHNlfQ)
-->
### 1.2.3 오류, 결함, 장애
- 오류(Error) : 개발자, 디자이너, 테스터 등 사람의 실수, 경험 부족, 심리적 요인 등으로 인해 발생
- 결함(Defact) : 오류로 인해 [test basis](#testbasisgus "> 요구사항, 설계문서, 코드 등 개발 산출물")에 발생한 문제
- 장애(Failure) : 고객 사용 단계에서 발생하는 문제, 장애의 원인은 결함 or [환경 조건](#envgus "> 운용환경과의 호환성/환경성")이 될 수 있음
![오류, 결함, 장애의 상관 관계](/assets/images/201212_Theory_ISTQB/1_2_3.png "오류, 결함, 장애의 상관 관계")
<!--
[![](https://mermaid.ink/img/eyJjb2RlIjoiZmxvd2NoYXJ0IExSO1xuIGVycm9yKEVycm9yKTtcbiBkZWZhY3QoRGVmYWN0KTtcbiBmYWlsdXJlKEZhaWx1cmUpO1xuIGVudihFbnZpcm9tZW50KVxuXG4gZXJyb3ItLT5kZWZhY3Q7XG4gZGVmYWN0LS0-ZmFpbHVyZTtcbiBlbnYtLT5mYWlsdXJlOyIsIm1lcm1haWQiOnsidGhlbWUiOiJkZWZhdWx0In0sInVwZGF0ZUVkaXRvciI6ZmFsc2V9)](https://mermaid-js.github.io/mermaid-live-editor/#/edit/eyJjb2RlIjoiZmxvd2NoYXJ0IExSO1xuIGVycm9yKEVycm9yKTtcbiBkZWZhY3QoRGVmYWN0KTtcbiBmYWlsdXJlKEZhaWx1cmUpO1xuIGVudihFbnZpcm9tZW50KVxuXG4gZXJyb3ItLT5kZWZhY3Q7XG4gZGVmYWN0LS0-ZmFpbHVyZTtcbiBlbnYtLT5mYWlsdXJlOyIsIm1lcm1haWQiOnsidGhlbWUiOiJkZWZhdWx0In0sInVwZGF0ZUVkaXRvciI6ZmFsc2V9)
-->

### 1.2.4 결함, 근본 원인, 결과
- 결함을 분석함으로써 근본 원인을 찾을 수 있다.
- 장애 발생에 의한 사용자 반응이 결과이다.

## 1.3 테스팅의 7가지 원리
1. [테스팅은 결함이 존재함을 밝히는 활동이지, 결함이 없음을 밝히는 활동이 아니다.](#1gus "Testing shows the presence of defects, not their absence")  
결함이 없다는 것을 증명 할 수 없으며, 결함이 없더라도 완벽한 소프트웨어가 아니다.
2. [완벽한 테스팅은 불가능하다.](#2gus "Exhaustive testing is impossible")  
모든 조합을 테스트 할 수 없다. 리스크 분석과 우선순위를 토대로 노력을 집중하는게 좋다.
3. [조기 테스팅으로 시간과 비용을 절약할 수 있다.](#3gus "Early testing saves time and money")  
정적/동적 테스팅을 SW 개발 수명 주기의 이른 시점에 시작하여 초기에 결함을 발견할 수 있다.
4. [결함은 집중된다.](#4gus "Defects cluster together")  
대부분의 결함은 집중되며 이를 리스크 분석의 입력값으로 사용한다.
5. [살충제 페러독스에 유의하라.](#5gus "Beware of the pesticide paradox")  
계속 같은 테스트를 반복 수행하면 더 이상 결함을 발견할 수 없다.  
주기적으로 테스트 케이스와 테스트 데이터를 수정해서 평가해야한다.
6. [테스팅은 정황에 의존적이다.](#6gus "Testing is context dependent")  
테스팅은 산업, 제품, 차용한 개발 프로세스에 따라 다르게 진행된다.
7. [오류 부재는 궤변이다.](#7gus "Absence-of-errors is a fallacy")  
모든 결함을 발견 할 수 없으며 많은 결함을 발견했다고 성공을 보장 할 수 없다.

## 1.4 테스트 프로세스
주어진 상황에 맞는 구체적인 소프트웨어 테스트 프로시저는 다양한 변수에 따라 결정된다.

### 1.4.1 정황에 따른 테스트 프로세스
- 정황(예산과 자원, 제품 분야, 적용하고자 하는 테스트레벨과 유형 등)에 따라 테스트 프로세스가 결정된다.
- 테스트 프로세스는 테스트 계획, 분석, 설계, 테스트 구현, 테스트 진행 상황 및 결과 보고, 테스트 대상 품질 평가 등으로 구성된다.

### 1.4.2 테스트 활동과 작업 (동적 테스트 프로세스) / 1.4.3 테스트 작업 산출물
- 테스트 프로세스(동적)에 대해 살펴보자.  
- 관리자가 주도하는 <span style="color:#FF88FF">**관리 프로세스(Management process/ 1,2,7)**</span>, 테스터가 주도하는 <span style="color:#8888FF">**실행 프로세스(Execution process/ 3,4,5,6)**</span>로 나뉜다.

![동적 테스트 프로세스](/assets/images/201212_Theory_ISTQB/1_4_2.png "동적 테스트 프로세스")
<!--
[![](https://mermaid.ink/img/eyJjb2RlIjoiZmxvd2NoYXJ0IExSXG5cbiAgQSgxLiBUZXN0IHBsYW5uaW5nKS0tPkIoMi4gVGVzdCBtb25pdG9yaW5nIGFuZCBjb250cm9sKS0tPkMoNy4gVGVzdCBjb21wbGV0aW9uKVxuXG4gIHN1YmdyYXBoIEV4ZWN1dGlvbl9wcm9jZXNzXG4gICAgRCgzLiBUZXN0IGFuYWx5c2lzKS0tPkUoNC4gVGVzdCBkZXNpZ24pLS0-Rig1LiBUZXN0IGltcGxlbWVudGF0aW9uKS0tPkcoNi4gVGVzdCBleGVjdXRpb24pXG4gIGVuZFxuXG4gIEEtLT5EXG4gIEctLT5DXG4gIEI8LS0-RXhlY3V0aW9uX3Byb2Nlc3NcblxuIHN0eWxlIEEgZmlsbDojRkNGXG4gc3R5bGUgQiBmaWxsOiNGQ0ZcbiBzdHlsZSBDIGZpbGw6I0ZDRlxuIHN0eWxlIEQgZmlsbDojQ0NGXG4gc3R5bGUgRSBmaWxsOiNDQ0ZcbiBzdHlsZSBGIGZpbGw6I0NDRlxuIHN0eWxlIEcgZmlsbDojQ0NGXG4iLCJtZXJtYWlkIjp7fSwidXBkYXRlRWRpdG9yIjpmYWxzZX0)](https://mermaid-js.github.io/mermaid-live-editor/#/edit/eyJjb2RlIjoiZmxvd2NoYXJ0IExSXG5cbiAgQSgxLiBUZXN0IHBsYW5uaW5nKS0tPkIoMi4gVGVzdCBtb25pdG9yaW5nIGFuZCBjb250cm9sKS0tPkMoNy4gVGVzdCBjb21wbGV0aW9uKVxuXG4gIHN1YmdyYXBoIEV4ZWN1dGlvbl9wcm9jZXNzXG4gICAgRCgzLiBUZXN0IGFuYWx5c2lzKS0tPkUoNC4gVGVzdCBkZXNpZ24pLS0-Rig1LiBUZXN0IGltcGxlbWVudGF0aW9uKS0tPkcoNi4gVGVzdCBleGVjdXRpb24pXG4gIGVuZFxuXG4gIEEtLT5EXG4gIEctLT5DXG4gIEI8LS0-RXhlY3V0aW9uX3Byb2Nlc3NcblxuIHN0eWxlIEEgZmlsbDojRkNGXG4gc3R5bGUgQiBmaWxsOiNGQ0ZcbiBzdHlsZSBDIGZpbGw6I0ZDRlxuIHN0eWxlIEQgZmlsbDojQ0NGXG4gc3R5bGUgRSBmaWxsOiNDQ0ZcbiBzdHlsZSBGIGZpbGw6I0NDRlxuIHN0eWxlIEcgZmlsbDojQ0NGXG4iLCJtZXJtYWlkIjp7fSwidXBkYXRlRWRpdG9yIjpmYWxzZX0)
-->

1. 테스트 계획 (Test planning)
- [테스트의 목적](#1421 "> 품질 risk 감소")과 정황에 따른 제약 사항을 고려하여 목적 달성을 위해 필요한 평가 방법을 정의하는 과정이다.
- 테스트 계획은 테스트 모니터링과 [제어 활동에서 나온 피드백](#1421 "> metric, test data")을 기반으로 수정 및 [업데이트](#1421 "> 업데이트가 없다면 살충제 페러독스에 빠질 수 있다.") 할 수 있다.
- 산출물 : 테스트 계획, Test basis

2. 테스트 모니터링과 제어 (Test monitoring and control)
- 테스트 모니터링 : 테스트 모니터링 [메트릭](#1422 "> 테스트 중 얻어지는 산출물")을 활용해 진행 상황과 원래 계획을 비교하는 활동
- 테스트 제어 : 모니터링을 토대로 테스트 계획을 수정 및 업데이트 하는 과정
- 이 과정에서 종료 조건 평가를 하며 이를 통해 다음 단계로 진행한다.
- 산출물 : 테스트 진행 현황 보고서

3. 테스트 분석 (Test analysis)
- 무엇을 테스트 할 지 결정하는 과정이다.
- [테스트 베이시스](#1423 "> 개발 산출물. ex) 명세, 모델, 코드")를 분석하여 테스트 가능한 기능인 테스트 컨디션과 기대결과인 테스트 오라클을 식별한다.
- 산출물 : 테스트 컨디션, 테스트 차터, 테스트 오라클

4. 테스트 설계 (Test design)
- 테스트 컨디션과 테스트 오라클을 기반으로 상위 수준 테스트 케이스, 테스트 케이스 세트를 생성하고 [테스트 데이터](#1424 "> 테스트 케이스의 입력 값")를 식별한다.
- 평가에 필요한 인프라 설계 및 도구 식별한다.
- 산출물 : 테스트 케이스, 테스트 데이터

5. 테스트 구현 (Test implementation)
- [테스트 프로시저](#1425 "> 사람이 수행 할 테스트 케이스 묶음") 개발 및 [자동 테스트 스크립트](#1425 "> 자동화로 수행 할 테스트 스크립트 (테스트 케이스 + 테스트 데이터)") 생성
- 테스트 인프라 구축 및 확인
- 이를 기반으로 [테스트 스위트](#1425 "> 테스트 스위트 : "테스트 프로시저 + 평가 환경" or "자동 테스트 스크립트 + 평가 환경"") 생성 및 테스트 일정 수립
- 테스트 데이터 준비 및 평가 환경 세팅 확인
- 산출물 : 테스트 프로시저, 자동 테스트 스크립트, 테스트 스위트

6. 테스트 실행 (Test execution)
- 일정에 따라 테스트 스위트 실행
- 기대 결과와 실제 결과를 비교하여 결함 발생시 결함 보고
- 산출물 : 결함 보고서

7. 테스트 완료 (Test completion)
- 테스트 요약 보고서 작성
- 모든 결함 보고 처리 완료 했는지 확인
- 산출물 : 테스트 요약 보고서

### 1.4.4 테스트 베이시스와 테스트 작업 산출물 간의 추적성
- 테스트 베이시스와 작업 산출물 간의 추적성은 제품 품질을 평가 할 수 있는 정보(커버리지)를 제공한다.

## 1.5 테스팅의 심리학

### 1.5.1 인간 심리학과 테스팅
- 협력이 중요하다!

### 1.5.2 테스터와 개발자의 사고방식
- 개발자 : 해결책을 찾는데 관심이 많지만 그 해결책에 문제가 없는지는 관심이 적다. 확증 편향으로 자신의 오류를 인지하기 힘들다.
- 테스터 : 비판적인 시각과 세밀한 것에 집중하는 능력이 필요하다. 긍정적인 마인드도 중요하다.  
<br>
<br>
<br>

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
- V-cycle의 우측 단계를 나타낸다. V-cycle의 좌축은 [verification](#2221 "> 시스템이 주어진 명세를 만족하는지 평가")을 나타내고 우측은 [validation](#2222 "> 시스템이 사용자 요구사항 및 환경에 적합한지 평가")을 나타낸다.
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

# 3. 정적 테스팅

## 3.1 정적 테스팅 기초
- 테스트할 SW의 실행이 필요한 동적 테스트와는 달리 정적 테스트는 SW의 실행이 필요없다.
- 정적 테스트는 2가지(리뷰/정적분석)가 존재한다.
- 리뷰 : 작업 산출물을 수동으로 검사
- 정적분석 : 작업 산출물을 도구를 사용하여 분석

### 3.1.1 정적 테스팅으로 검토할 수 있는 작업 산출물
- 대부분의 작업 산출물은 정적 테스팅이 가능하다.

### 3.1.2 정적 테스팅의 효과
- 정적 테스팅과 동적 테스팅은 서로 발견하는 결함의 유형이 달라 상호 보완적이다.
- 결함 조기 발견하여 수정
- 테스팅 비용 및 기간 단축
- 개발 생산성 향상
- 리뷰 참여를 통해 팀원간 의사소통 개선

## 3.2 리뷰 프로세스
- 공식 리뷰, 비공식 리뷰가 있다.
- 공식 리뷰 : 팀 참여, 리뷰 결과 문서화, 정의된 프로세스대로 수행
- 비공식 리뷰 : 리뷰 결과 문서화 하지 않아도 됨, 프로세스 정해진거 없음

### 3.2.1 작업 산출물 리뷰 프로세스

![작업 산출물 리뷰 프로세스](/assets/images/201212_Theory_ISTQB/3_2_1.png "작업 산출물 리뷰 프로세스")
<!--
[![](https://mermaid.ink/img/eyJjb2RlIjoiZmxvd2NoYXJ0IExSXG5cbiAgIEEo6rOE7ZqNKSAtLS0-IEIo66as67ewIOywqeyImCkgLS0tPiBDKOqwnOuzhCDrpqzrt7ApIC0tLT4gRCjsnbTsiogg64W87J2YIOuwjyDrtoTshJ0pIC0tLT4gRSjsiJjsoJUg67CPIOuztOqzoClcbiIsIm1lcm1haWQiOnt9LCJ1cGRhdGVFZGl0b3IiOmZhbHNlfQ)](https://mermaid-js.github.io/mermaid-live-editor/#/edit/eyJjb2RlIjoiZmxvd2NoYXJ0IExSXG5cbiAgIEEo6rOE7ZqNKSAtLS0-IEIo66as67ewIOywqeyImCkgLS0tPiBDKOqwnOuzhCDrpqzrt7ApIC0tLT4gRCjsnbTsiogg64W87J2YIOuwjyDrtoTshJ0pIC0tLT4gRSjsiJjsoJUg67CPIOuztOqzoClcbiIsIm1lcm1haWQiOnt9LCJ1cGRhdGVFZGl0b3IiOmZhbHNlfQ)
-->
1. 계획
- 관리자가 주도하는 과정으로 리뷰 목적, 노력과 기간을 추정한다.
- 리뷰에 참여할 인원을 선정하고 역할을 할당한다.
- 공식적인 리뷰에서는 시작, 종료 조건을 정의한다.

2. 리뷰 착수
- 리뷰리더가 참여자들에게 리뷰 범위, 목적 등에 대해 설명 및 질의 응답 하는 과정이다.

3. 개별 리뷰
- 리뷰어들이 진행하는 과정으로 작업 산출물의 각자 할당된 범위를 리뷰하고 질문 사항을 준비한다.

4. 이슈 논의 및 분석
- 주로 중재자가 진행하며 개별 리뷰 단계에서 식별한 잠재 결함을 전달한다.
- 종료 조건을 기준으로 리뷰 결과를 평가하여 리뷰 결과를 결정한다.

5. 수정 및 보고
- 작업 산출물 수정을 요하는 잠재 결함에 대한 결함 보고서를 작성한다.
- 리뷰한 작업 산출물에서 발견한 결함을 수정한다.(주로 저자가 수정)

### 3.2.2 공식 리뷰에서의 역할과 책임
- 저자 : 리뷰 대상 작업 산출물 작성, 결함 수정
- 관리자 : 리뷰 계획, 리뷰 실행 결정, 인력/예산/시간 할당, 리뷰 과정 모니터링
- 촉진자(중재자) : 원활한 리뷰 회의 진행
- 리뷰 리더 : 전반적으로 리뷰에 대한 책임을 짐
- 검토자 : 리뷰 대상 작업 산출물의 잠재적 결함 식별

### 3.2.3 리뷰 유형
1. 비공식 리뷰
- 버디 체크 : 산출물 작성 후 동료가 리뷰
- 페어링 : 산출물 작성 시 동료 옆에 두고 진행
- 짝 리뷰 : 산출물 작성 후 동료 2명에게 리뷰

2. 워크쓰루
- 목적 : 주로 지식 교육, 아이디어 교환을 위해 진행
- 서기 참여 필수, 주로 저자가 회의 주도

3. 기술 리뷰
- 목적 : 주로 기술적 의사결정, 새 아이디어 도출을 위해 진행
- 회의는 주로 촉진자가 주도, 서기 참여 필수

4. 인스펙션
- 목적 : 결함 식별/예방, 품질 측정
- 가장 공식적인 리뷰, 규칙 및 체크리스트 기반
- 회의는 촉진자가 주도, 서기 창며 필수

### 3.2.4 리뷰 기법 적용
- 개별 리뷰 단계에서 적용할 수 있는 리뷰 기법들이다.
- Ad hoc : 검토자에게 안내가 거의 없이 산출물 던져주고 리뷰하라고 하는 방식. 사람들의 생각은 비슷하기에 여러 검토자가 동일한 문제를 보고할 수 있다.
- 체크리스트 기반 : 검토자는 리뷰 시작전 배포된 체크리스트를 기반으로 검토 진행. 체크 리스트 이외의 결함도 찾을 수 있도록 주의를 기울여야 한다.
- 시나리오 및 드라이 런 : 검토자는 구조화된 지침을 제공받는다. 마찬가지로 시나리오 이외의 상황도 주의를 기울여야 한다.
- 관점 기반(역할기반) : 검토자가 다양한 이해관계자의 관점을 사용하여 리뷰를 진행한다. 가장 강력한 리뷰 방법이다.

### 3.2.5 리뷰의 성공 요소
- 각 리뷰는 명확한 목적이 있어야한다.
- 참여자는 충분한 시간이 있어야한다.
<br>
<br>
<br>

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

# 5. 테스트 관리

## 5.1 테스트 조직

### 5.1.1 독립적인 테스팅
- 대부분의 프로젝트에서 보통 여러 테스트 레벨을 두고 그 중 일부는 독립적인 테스터가 담당하도록 하는 것이 최적이다.
- 독립적인 테스팅 장점 : 독립적인 테스터를 두면 개발자와는 다른 유형의 장애를 찾을 수 있다.
- 독립적인 테스팅 단점 : 개발팀과의 고립으로 협업이 어려울 수 있다. 심하면 적대적 관계가 될 수 있다.

### 5.1.2 테스트 관리자 및 테스터의 역할
- 테스트 관리자와 테스터의 역할은 다르다.

| 테스트 관리자 | 테스터 |
|:---|:---|
|- 테스트 프로세스에 대한 전반적인 책임<br>- 결정권에 대한 권한<br>- 조직에 테스터에 대한 홍보 및 지지 요청|- 테스트 계획 리뷰 및 수행<br>- 테스트 실행 결과 기록 및 분석<br>- 필요할 경우 테스트 자동화 수행|

## 5.2 테스트 계획과 추정

### 5.2.1 테스트 계획의 목적과 내용
- 테스트 계획은 개발 및 유지보수 프로젝트의 평가 활동에 대한 전반적인 내용을 담는다.
- 테스트 계획 활동은 제품 수명주기 전반에 걸쳐 이루어지는 지속적 활동이다.

### 5.2.2 테스트 전략과 테스트 접근법
- 테스트 전략은 평가 프로세스의 일반적인 모습을 반영한다.

| No | Item | Description | Exmaple |
|:---:|:---|:---|:---|
|1|분석적|특정 요소에 대한 분석을 기반으로한 평가 방법.|ex) 리스크 기반 평가|
|2|모델 기반|요구되는 제품의 특정 측면에 대한 모델을 기반으로 평가|-|
|3|방법론적|사전 정의한 테스트 셋이나 테스트 컨디션을 체계적으로 사용하는 방법.|ex) 보편적이고 발생 가능성이 높은 장애 분류|
|4|프로세스/표준 준수|외부 규정 또는 표준을 기반으로 테스트를 분석, 설계, 구현하는 방법.|-|
|5|전문가 조언/자문|이해관계자(사용자, 최종 소비자), 비즈니스 도메인 전문가의 자문.<span style="color:#0000FF">(외/내부 전문가)</span>|-|
|6|리그레션 기피|기존 기능에 대한 리그레션 테스트 기피를 목표로함.|ex)기존 테스트웨어 재사용, 리그레션 테스트 자동화 등|
|7|반응적|테스트 실행 중 발생하는 이벤트에 따라 반응적으로 수행하는 평가 방법.|ex) 탐색적 테스팅|

### 5.2.3 시작 조건과 종료 조건
- 시작 조건 : 특정 테스트 활동이 시작 할 수 있는 조건.
ex) 이전 테스트 종료 조건, 테스트 환경 가용 여부, 테스트 자원 가용 여부
- 종료 조건 : 특정 테스트 레벨이나 테스트 세트가 끝났음을 만족하는 조건
ex) 계획한 테스트 실행 완료, 정의한 커버리지 도달, 해결 못한 결함 수가 합의된 수 미만, 비기능적 특성이 원하는 품질 수준에 도달

### 5.2.4 테스트 실행 일정
- 우선순위가 높은 테스트 케이스를 먼저 실행 하는 등 평가 실행 일정을 계획

### 5.2.5 테스트 노력에 영향을 미치는 요소

| Item | Example |
|:---|:---|
|제품 특성|요구사항 특성, 제품 관련 리스크, 제품 도메인 복잡도|
|개발 프로세스 특성|테스트 접근법, 사용하는 개발 모델, 조직의 성숙도, 테스트 프로세스|
|인력 특성|팀 응집력, 열걍, 유사 프로젝트 경험|
|테스트 결과|발견 결함 수|

### 5.2.6 테스트 추정 기법
테스트 노력을 추정하는 기법.
- 메트릭 기반 기법 : 기존 유사 프로젝트에서 얻은 메트릭에 기반하거나 보편적 값을 바탕으로 테스트 노력 예측 <span style="color:#0000FF">(외부)</span>
- 전문가 기반 기법 : 테스팅 작업의 책임자나 전문가의 경험을 기반으로 테스트 노력 예측 <span style="color:#0000FF">(내/외부)</span>

## 5.3 테스트 모니터링과 제어
- 테스트 모니터링을 통해 정기적으로 테스트 진행상황 보고서를 작성한다.
| Item | Description |
|:---|:---|
|테스트 모니터링|- 테스트 모니터링을 통한 정보 수집을 통해 테스트 진행 상황 평가.<br>- 테스트 종료 조건 등을 평가|
|테스트 제어|- 수집한 정보를 토대로 테스트 계획 및 평가 수정|

### 5.3.1 테스팅에 사용하는 메트릭
- 계획한 일정과 예산 대비 진행 상황
- 테스트 대상의 현재 품질
- 테스트 접근법을 타당성
- 목적 대비 테스트 활동의 효과
- 결함 정보, 커버리지

### 5.3.2 테스트 보고의 목적, 내용, 독자
- 테스트 진행상황 보고서 : 테스트 계획 대비 진행 상황, 진행 방해 요소, 다음 계획한 테스팅 등을 명시한다.
- 테스트 요약 보고서 : 종료 조건 만족시 작성하는 보고서로 테스팅 수행 내용 요약, 계획 대비 편차 등을 명시한다.

## 5.4 형상관리
- 형상 관리의 목적은 프로젝트와 제품 수명주기 동안 컴포넌트나 시스템, 테스트웨어와 이들 서로간의 관계 통합을 수립하고 유지하는 데 있다.

## 5.5 리스크와 테스팅

### 5.5.1 리스크의 정의
- 리스크 : 미래에 <span style="color:#FF0000">부정적 결과</span>를 가져오는 이벤트 발생 가능성이다. 리스크는 이벤트 발생 가능성과 이벤트로 인한 영향도로 결정한다.

### 5.5.2 제품 및 프로젝트 리스크

| Item | Description | Example |
|:---|:---|:---|
|제품 리스크|- 제품 자체의 리스크|ex) 제품이 명시된 요구사항과 다른게 기능함, 일부 비기능 요구사항을 지원 못함, 특정 계산식의 결함 |
|프로젝트 리스크|- 프로젝트 목적 달성에 부정적인 영향을 주는 것|ex) 인력 부족, 평가 환경/도구 가용성, 미흡한 요구사항, 외주 업체 문제|

### 5.5.3 리스크 기반 테스팅과 제품 품질
- 리스크 기반 접근법은 제품 리스크 수준을 조기에 낮추는데 기여한다.
- 제품 리스크 식별 및 리스크 발생 가능성과 영향을 평가하는 제품 리스크 분석을 포함한다.

## 5.6 결함 관리
- 테스팅 목적 중 하나가 결함 발견이기 때문에 발견된 결함은 반드시 기록해야 한다.
- 관리 도구를 사용하는 것이 좋다.
<br>
<br>
<br>

# 6. 지원 도구
## 6.1 테스트 도구 고려 사항
### 6.1.1 테스트 도구 의 분류

| 도구 | Description | Example |
|:---|:---|:---|
|테스팅 및 테스트웨어 관리 지원 도구| 개발 수명 주기 전체에 걸쳐 사용 | 요구사항 관리 도구, 형상 관리 도구 |
|정적 테스팅 지원 도구| 정적 분석에 사용 | 정적 분석 지원 도구(for 개발자) |
|테스트 설계 및 구현 지원 도구| 테스트 설계와 구현을 지원 | Model based 평가 도구, 테스트 데이터 준비 도구 |
|테스트 실행 미 로깅 지원 도구| 평가 수행을 돕는 도구| 커버리지 도구, 테스트 하네스(개발자 평가 환경), 테스트 수행 도구 |
|성능 측정 및 동적 분석 지원 도구| 성능 및 부하 테스트 활동 지원 도구 | 동적 분석 동구, 성능 평가 도구(tiobench, androbench) |

### 6.1.2 테스트 자동화의 효과와 리스크
- 자동화 효과 : 반복 작업 감소, 평가 결과 정보 접근 용이
- 자동화 리스크 : 도구에 대한 비현실적 기대, 도구 도입에 드는 비용, 유지 보수

### 6.1.3 테스트 실행 및 테스트 관리 도구 고려 사항
- 테스트 실행 도구
1. 캡처 기반 테스트 접근법 : 테스터의 수동적인 조작 녹화해 테스트 수행하는 방법. 비효율성 높다.
2. 데이터 주도 테스트 접근법 : 공통 스크립트에 다양한 데이터를 읽어 들여 평가.
3. 키워드 주도 테스트 접근법 : 키워드 스크립트 호출을 통해 평가.

## 6.2 도구의 효과적인 사용
### 6.2.1 도구 선택의 주요 원칙
- 조직의 수준 및 성숙도 평가
- 도구를 미리 사용해보는 평가기간 필요 (사전 검증)
- 도구를 사용할 사람의 수요 확인

### 6.2.2 도구 도입을 위한 파일럿 프로젝트
- 도구의 습득 및 장/단점 이해
- 기존 프로세스에 도구 어떻게 적용하여 평가할지 결정
- 목표 달성에 도움이 될지 평가

### 6.2.3 도구 성공 요인
- 조직의 다른 부서에 도구 사용 전파를 점진적으로 수행
- 도구의 사용법에 맞게 프로세스를 수정하고 개선<span style="color:#FF0000">(도구를 프로세스에 맞춰 수정하면 안됨)</span>
- 도구 사용자들에게 피드백 수용
