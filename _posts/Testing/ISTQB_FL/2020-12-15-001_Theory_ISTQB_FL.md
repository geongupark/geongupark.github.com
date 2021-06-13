---
title:  "[001] ISTQB foundation level 실라버스(v3.1) 이론 - 테스팅의 기초"
excerpt: "실라버스(v3.1)를 기반으로한 ISTQB foundation level 이론(요약, 정리)이에요. 테스팅의 기초를 알아봐요. ISTQB CTFL에 도전하실 분들 참고하세요~!"
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
  - 테스팅 기초
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