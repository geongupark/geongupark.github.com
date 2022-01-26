---
title:  "[C#/kiwoom_open_api_002] Login 해보기"
excerpt: "Kiwoom open api로 login 해보기 with C#"
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
  - 로그인
last_modified_at: 2022-01-26T18:06:00-05:00
---
*키움 증권 OpenAPI+를 활용해 로그인을 해보자*
  
# 1. C# Winform project 생성 및 OCX 컨트롤 추가
* Visual studio에서 C# winform project를 생성
* 도구상자>마우스우클릭>항목 선택
<img src="/assets/images/220126_kiwoom_login/Add_API1.png" width="600" height="300">
* COM 구성 요소 내 KHOpenAPI Control 체크 후 확인
<img src="/assets/images/220126_kiwoom_login/Add_API2.png" width="600" height="300">
* 도구 상자 내에 KHOpenAPI 도구 생성 된 것 확인 가능
<img src="/assets/images/220126_kiwoom_login/tool_box.png" width="400" height="200">

# 2. WinForm 구성
* 도구상자로부터 Button(로그인, 로그아웃), ListBox(로그), KHOpenAPI를 끌어옴

## 2.1 UI
### 2.1.1 Button(로그인, 로그아웃)
* KOA Studio 내 개발 가이드를 살펴보면 login 관련 함수 설명을 볼 수 있음
* 로그인은 CommConnect() 함수를 이용, 로그 아웃은 CommTerminate() 함수가 제거 됐기 때문에 구현 불가
* GetConnectState() 함수를 통해 연결 상태 확인 가능
<img src="/assets/images/220126_kiwoom_login/login_method.png" width="400" height="200">

### 2.1.2 ListBox(로그)
* 로그인 과정에서 발생하는 로그를 남김

### 2.1.3 KHOpenAPI
* OCX control을 사용하기 위해 Form에 위치 시켜줌
* visible 속성을 False로 해주면 실제 Application에 나타나지 않음

## 2.2 Event
### 2.2.1 Button(로그인, 로그아웃), ListBox
* axKHOpenAPI 내 CommConnect() 메서드를 호출하면 키움 증권의 로그인 창이 뜸
* 로그인 창이 제대로 뜨는지 안뜨는지 여부 ListBox에 출력
* 연결 이벤트 발생 시 수행 될 메서드 매핑(OnEventConnect)
```
private void ButtonLogin_Click(object sender, EventArgs e)
{
    if (this.axKHOpenAPI.CommConnect() == 0)
    {
        this.ListBoxLog.Items.Add("Login Start");
    }
    else
    {
        this.ListBoxLog.Items.Add("Login Fail");
    }
    this.axKHOpenAPI.OnEventConnect += this.OnEventConnect;
}
```

### 2.2.2 OnEventConnect(로그)
* axKHOpenAPI 내 GetConnectState() 메서드의 출력 값에 따라 연결 상태 ListBox에 출력
```
private void OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
{
    if (e.nErrCode == 0)
    {
        if (this.axKHOpenAPI.GetConnectState() == 1)
        {
            this.ListBoxLog.Items.Add("Connecting...O.K.");
        }
        else if (this.axKHOpenAPI.GetConnectState() == 0)
        {
            this.ListBoxLog.Items.Add("Not Connecting");
        }
    }
}
```
# 3. 결과 화면
* Application 수행 결과는 아래와 같음  
<img src="/assets/images/220126_kiwoom_login/result1.png" width="200" height="400">
<img src="/assets/images/220126_kiwoom_login/result2.png" width="200" height="400">