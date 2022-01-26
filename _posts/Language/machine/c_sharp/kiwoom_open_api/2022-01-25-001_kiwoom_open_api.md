---
title:  "[C#/kiwoom_open_api_001] Kiwoom open api란?"
excerpt: "Kiwoom open api 사용 법 with C#"
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
  - C#_open_api
tags:
  - C#
  - open api
  - kiwoom
  - 키움
  - 주식
last_modified_at: 2022-01-25T18:06:00-05:00
---
*키움 증권 OpenAPI+를 활용하기 위한 사전 작업에 대해 알아보자*
  
# 1. Kiwoom Open Api
* 키움 증권에서 제공하는 주식 관련 정보를 얻어 올 수 있는 공개된 API
* C#을 통해 활용 할 수 있음

# 2. 준비 작업
* 키움 증권 Open API 사용을 위한 준비 작업
* 하기 사이트에서 아래 3단계 진행
* [Kiwoom OpenAPI link](https://www.kiwoom.com/h/customer/download/VOpenApiInfoView)
1. Open API 사용자 신청
2. OpenAPI+ 모듈 다운로드 및 설치
3. KOA Studio 다운로드 및 실행

## 2.1 Open API 사용자 신청
* 로그인 후 Open API 사용 신청을 함

## 2.2 OpenAPI+ 모듈 다운로드 및 설치
* 본인의 PC에 OpenAPI+ 모듈을 설치하는 과정임
* 해당 모듈이 먼저 설치 되어야 KOA Studio 정상 동작 가능

## 2.3 KOA Studio 다운로드 및 실행
* OpenAPI+를 잘 설치 했다면 KOA Studio가 정상 실행 될 것임
* KOA Studio란?
> 키움 증권이 개발 편의를 위해 제공하는 TR의 목록과 정보를 간편하게 확인 할 수 있음  
> 모의 투자 서버로만 접속 가능  
> 서비스 TR의 입력/출력 값 확인 가능  
> 실시간 DATA의 ID 값 확인 가능  

<img src="/assets/images/220125_kiwoom_open_api/KOA_Studio.png" width="800" height="400">

# 3. OpenAPI+ 활용
* C# 언어를 활용하여 Open API OCX 탑재 프로그램을 제작 가능
* 개발 시 개발 가이드, KOA Studio를 참고하여 진행