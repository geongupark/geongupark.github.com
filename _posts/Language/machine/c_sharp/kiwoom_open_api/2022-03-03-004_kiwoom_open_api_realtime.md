---
title:  "[C#/kiwoom_open_api_004] 실시간 데이터 조회/수신"
excerpt: "Kiwoom open api로 실시간 데이터 조회/수신 해보기 with C#"
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
  - C#_kiwoom_open_api
tags:
  - C#
  - open api
  - kiwoom
  - 키움
  - 주식
  - 실시간 데이터
  - 조회
  - 수신
last_modified_at: 2022-03-03T20:06:00-05:00
---
*키움 증권 OpenAPI+를 활용해 실시간 데이터 조회/수신을 해보자*
  
# 1. 실시간 데이터 조회 요청/수신?
* 시세조회요청이 성공하면 해당종목의 실시간시세 데이터가 서버에 자동으로 등록됨
* 이후 해당종목 실시간 시세데이터는 OnReceiveRealData() 이벤트로 수신됨
* 시세조회가 필요없고 실시간 시세만 필요한 경우 SetRealReg 함수를 사용하여 특정종목(복수종목 가능)의 실시간시세를 서버에 등록할 수 있음

# 2. 실시간 데이터 조회 요청/수신 사용법
> 방법1. 조회 서비스 이용
> SetInputValue(사용자 호출) -> CommRqData(사용자 호출) -> OnReceiveTrData(이벤트 발생) ->OnReceiveRealData(이벤트 발생)

> 방법2. SetRealReg 함수 이용
> SetRealReg(사용자 호출) -> OnReceiveRealData(이벤트 발생)
  
* 실시간 시세만 필요한 경우 방법2를 이용

# 3. WinForm 구성
* 실시간 데이터 조회 요청/수신 실습을 위해 삼성전자우(005935)의 실시간 현재가 데이터를 받아옴

## 3.1 Event
### 3.1.1 OnReceiveRealData 이벤트 callback 함수 등록
* 앞서 진행한 003번 포스팅의 코드에 하기 코드만 붙여주면 됨
* OnReceiveRealData 이벤트 callback 함수 정의 및 등록을 해줌
* <span style="color:#FF0000">OnReceiveRealData 이벤트</span>는 실시간 이벤트라서 요청한 종목에 대한 실시간 데이터를 <span style="color:#FF0000">**지속적으로 제공**</span>함
* 중간에 멈추던지(DisconnectRealData) 다른 종목을 요청(CommRqData) 할 수 있음

```
// OnReceiveRealData 이벤트 callback 함수 등록
this.axKHOpenAPI.OnReceiveRealData += this.OnReceiveRealDataCallback;
```
```
// OnReceiveRealData 이벤트 callback 함수 정의
private void OnReceiveRealDataCallback(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
{
    if (e.sRealType == "주식체결")
    {
        this.ListBoxLog.Items.Add("현재가 : " + this.axKHOpenAPI.GetCommRealData(e.sRealType, 10).Trim());
        this.ListBoxLog.Items.Add("전일대비 : " + this.axKHOpenAPI.GetCommRealData(e.sRealType, 11).Trim());
        this.ListBoxLog.Items.Add(" ");
    }
}
```

# 4. 결과 화면
* Application 수행 결과는 아래와 같음  
<img src="/assets/images/220303_kiwoom_realtime/realtime.png" width="500" height="250">