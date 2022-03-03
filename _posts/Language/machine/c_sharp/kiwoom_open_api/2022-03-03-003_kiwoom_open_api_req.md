---
title:  "[C#/kiwoom_open_api_003] 조회/수신"
excerpt: "Kiwoom open api로 조회/수신 해보기 with C#"
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
  - 조회
  - 수신
last_modified_at: 2022-03-03T18:06:00-05:00
---
*키움 증권 OpenAPI+를 활용해 조회/수신을 해보자*
  
# 1. 조회 요청/수신?
* OpenAPI가 제공하는 데이터중에서 원하는 데이터를 서버에 요청해서 수신 받는 것을 말함
* 하나의 TR(Transaction)단위로 처리
* TR은 서버와 데이터를 주고받을때 약속된 규약 (KOA Studio 내 개발자 가이드 참고)
* 각 TR은 Input/Output을 가짐
* Input은 사용하는 TR에 따라 항목이 달라지며 사용자가 입력
* Output은 요청에 대한 서버의 응답으로 TR에 따라 싱글 또는 복수개가 전달 됨

# 2. 조회 요청/수신 사용법
> [1] SetInputValue(사용자 호출) -> [2] CommRqData(사용자 호출) -> [3] OnReceiveTrData(이벤트 발생)
1. 조회 요청하고자 하는 TR의 입력값(input) 셋팅
2. 서버에 TR 조회 요청
3. 서버는 TR 요청에 대한 결과를 이벤트를 통해 전달
4. 수신한 데이터중 필요한 항목에 해당하는 값을 구함

# 3. WinForm 구성
* 조회 요청/수신 실습을 위해 삼성전자(005930)의 주식기본정보요청(opt10001)을 해봄
* Text box로 종목 코드 번호를 입력받아 서버에 주식 기본정보를 요청하고 결과를 받아옴
* 도구상자로부터 Button(주식기본정보 요청), TextBox(종목 코드 입력) 끌어옴

## 3.1 UI
### 3.1.1 Textbox, Button(주식기본정보 요청)
* KOA Studio에서 주식 기본정보 TR 요청을 위한 text box와 button 추가


## 3.2 Event
### 3.2.1 Button(주식기본정보 요청) click event
* Text box로부터 받은 종목 코드를 setting 해줌
* 서버에 주식 기본정보(opt10001) TR 요청
```
private void buttonSearchPrice_Click(object sender, EventArgs e)
{
    // Text box로부터 받은 종목 코드
    string itemCode = this.textBoxItemCode.Text.Trim();

    if (itemCode == "") // 종목코드가 빈칸이면
    {
        this.ListBoxLog.Items.Add("Invalid item code...");
    }
    else
    {
        // OPT10001 TR에 대한 Input parameter 설정
        this.axKHOpenAPI.SetInputValue("종목코드", itemCode);
        // 서버에 OPT10001 TR 요청
        int ret = this.axKHOpenAPI.CommRqData("주식기본정보", "OPT10001", 0, "1001");
        if (ret == 0) // 종목 코드 정상
        {
            this.ListBoxLog.Items.Add("Getting price...O.K.");
        }
        else // 종목 코드 비 정상
        {
            this.ListBoxLog.Items.Add("Unable to get price...");
        }
    }
}
```


### 3.2.2 OnReceiveTrData 이벤트 등록
* axKHOpenAPI 내 OnReceiveTrData 이벤트의 callback 함수 등록
* TR 요청에 대한 결과를 OnReceiveTrData 이벤트로 확인 가능
```
// OnReceiveTrData 이벤트에 callback 함수 맵핑
this.axKHOpenAPI.OnReceiveTrData += this.OnReceiveTrDataPrice;
```
```
// Callback 함수
private void OnReceiveTrDataPrice(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
{
    // sRQName : TR 요청 시 받은 첫 번째 input parameter
    if (e.sRQName == "주식기본정보")
    {
        int repeatCnt = this.axKHOpenAPI.GetRepeatCnt(e.sTrCode, e.sRQName);

        for (int i = 0; i <= repeatCnt; i++)
        {
            // GetCommData를 통해 event로 부터 받은 output 중 필요한 data 가져오기
            this.ListBoxLog.Items.Add(this.axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim());
            this.ListBoxLog.Items.Add(this.axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim());
            this.ListBoxLog.Items.Add(this.axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Trim().Substring(1));
            this.ListBoxLog.Items.Add(" ");
        }
    }
}
```

# 4. 결과 화면
* Application 수행 결과는 아래와 같음  
<img src="/assets/images/220303_kiwoom_search_req/search_button.png" width="500" height="250">