@echo off
set path=%cd%\SkypeAdsRemover.exe
IF EXIST %path% (
REM Do one delete this line
) ELSE (
set /p path="Enter full path to SkypeAdsRemover.exe: "
)
set /p skypeprofile="Enter your skype profile: "
%SystemRoot%\system32\schtasks.exe /Create /tn "SkypeAdsRemover" /sc MINUTE /mo 1 /tr "%path% %skypeprofile%"