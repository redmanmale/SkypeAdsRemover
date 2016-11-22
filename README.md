# SkypeAdsRemover

[![Build status](https://ci.appveyor.com/api/projects/status/y5r9euuwx5fdf0dd/branch/master?svg=true)](https://ci.appveyor.com/project/redmanmale/skypeadsremover)

Simple app that edit your Skype config file to remove ads panel completely.  
This app doesn't touch hosts or any system files, just Skype config and only for selected profile.  
Windows-only!

## Installation & usage

After building this project in output directory would be two files: `install.bat` and `SkypeAdsRemover.exe`  
`install.bat` creates task in Windows Task Scheduler to run `SkypeAdsRemover.exe` every minute for provided Skype profile.  
Or you could set it up manually.
