---
title:  "[003] ISTQB foundation level 실라버스(v3.1) 이론 - 정적 테스팅"
excerpt: "실라버스(v3.1)를 기반으로한 ISTQB foundation level 이론(요약, 정리)이에요. ISTQB CTFL에 도전하실 분들 참고하세요~!"
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
