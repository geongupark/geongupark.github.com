---
title:  "001.Theory of ISTQB foundation level"
excerpt: "Theory of ISTQB foundation level based on syllabus(v3.1)"
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
last_modified_at: 2020-12-6T08:06:00-05:00
---

*※ "ISTQB의 syllabus v3.1을 기준으로 작성되었습니다."*  

본 문서는 ISTQB CTFL 공부를 하며 실라버스 내 각 chapter 별 의미를 요약한 문서이다. 추후 실무에 적용 시 곧바로 찾아 볼 수 있도록 굵직한 내용 위주로 정리했다.<br><br><br>

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

<div class="mermaid" style="font-size:1.5em">
flowchart LR;
	subgraph QM;
		stateA(QA);	%% It means QA
		stateC(QC);
	end;
	
  stateA-->|프로세스 제공|stateC;
  stateC-->|테스팅 데이터 제공|stateA;
</div>

### 1.2.3 오류, 결함, 장애
- 오류(Error) : 개발자, 디자이너, 테스터 등 사람의 실수, 경험 부족, 심리적 요인 등으로 인해 발생
- 결함(Defact) : 오류로 인해 [test basis](#testbasisgus "> 요구사항, 설계문서, 코드 등 개발 산출물")에 발생한 문제
- 장애(Failure) : 고객 사용 단계에서 발생하는 문제, 장애의 원인은 결함 or [환경 조건](#envgus "> 운용환경과의 호환성/환경성")이 될 수 있음

<div class="mermaid" style="font-size:1em">
flowchart LR;
 error(Error);
 defact(Defact);
 failure(Failure);
 env(Enviroment)

 error-->defact;
 defact-->failure;
 env-->failure;
</div>

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


# 2. 소프트웨어 개발 수명 주기와 테스팅

# 3. 정적 테스팅

# 4. 테스트 기법

# 5. 테스트 관리

# 6. 지원 도구



