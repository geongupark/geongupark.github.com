---
title:  "[Python_OOP_01] Python 가상환경(venv) 설정 in vscode"
excerpt: "프로젝트마다 다른 패키지 버전을 사용하고 싶다면? venv 가상환경 설정을 해요!"
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
  - Python_OOP
tags:
  - vscode
  - Python
  - Vertual Environment
  - venv
last_modified_at: 2021-07-29T18:06:00-05:00
---

# 1. Download vscode & python
- 개발자들이 극찬하는 Microsoft의 IDE인 vscode를 Download 받기 ([공식 홈페이지](https://code.visualstudio.com/))
- Python 필요한 버전으로 다운 받기 ([공식 홈페이지](https://www.python.org/))

# 1.1 Tip of vscode
- ctrl + j : 터미널 열기
- ctrl + b : 탐색기 숨김/열기
- Python extension for Visual Studio Code 다운받기 (ctrl+shift+x 누른 후 python 검색)

# 2. 가상환경
- 개발 project 별로 패키지 버전을 다르게 쓰고 싶은 경우 가상 환경 사용
- Python 3.3 이후 부터 기본 제공하는 venv 환경을 사용 할 수 있음

## 2.1 venv
- 가상환경으로 conda도 많이 사용하지만 venv가 더 가벼움

### 2.1.1 venv 환경 만들기
- 가상 환경 만들 위치에서 하기 명령 수행
- 주로 가상환경 명으로 venv을 사용
```
> python -m venv .\(가상환경명)
(Ex) python -m venv .\venv
```

### 2.1.2 venv 환경 활성&비활성
- venv 환경 활성을 위해 터미널에서 하기 명령 수행
- Window이며 powershell terminal이라면 하기 명령 수행
- [venv 공식 문서](https://docs.python.org/ko/3/library/venv.html)
```
<venv>\Scripts\Activate.ps1
(Ex) .\venv\Scripts\Activate.ps1
```
※ <span style="color:#FF0000">[참고!]</span> vscode 터미널이 powershell 이면 오류가 발생하니 관리자 권한으로 power shell 실행 후 하기 명령 수행 필요
```
Set-ExecutionPolicy Unrestricted
```

# 참고문헌
- venv 공식 문서 : https://docs.python.org/ko/3/library/venv.html
- powershell 권한 설정 : https://urakasumi.tistory.com/231