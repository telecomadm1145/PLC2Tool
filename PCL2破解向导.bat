@echo off
title 向导
echo PCL2破解向导
echo 步骤简介
echo 0.把PCL2放入工作目录
echo 1.检查PCL2是否是内测版
echo 2.de4dot反混淆PCL2
echo 3.dnspy打开PCL2
echo 4.解锁PCL2
echo 5.检查金色主题
echo 6.使用PCL2配置工具配置注册表
echo 按任意键开始向导
echo 如果遇到任何问题，请到qq群1045839144
pause 1>nul
REM 步骤0
:stage0
cls
echo 步骤0
echo 请把PCL2内测版放入工作目录，并命名为PCL2.exe
echo 按任意键检测PCL2是否存在
pause 1>nul
:stage0c
IF EXIST PCL2.exe (
echo 检测到PCL2
echo 按任意键进入下一步
pause 1>nul
) ELSE (
echo 未检测到PCL2
echo 按任意键重新检测
pause 1>nul
goto stage0c
)
REM 步骤1
:stage1
cls
echo 步骤1
echo 请确认PCL2是内测版/公测版
echo 非内测版/公测版无法解锁
echo 这不是一个向导bug
echo 而是PCL2特性
echo 按任意键进入下一步
pause 1>nul
REM 步骤2
:stage2
cls
echo 步骤2
echo 使用de4dot反混淆PCL2
echo 按任意键开始
pause 1>nul
:stage2c
where DE4DOT-X64.exe 1>nul
IF NOT ERRORLEVEL 1 (
echo 检测到de4dot
echo 按任意键开始自动化反混淆
pause 1>nul
) ELSE (
echo 未检测到de4dot
echo 请从    https://github.com/0xd4d/de4dot    下载或编译最新版
echo 按任意键重新检测
pause 1>nul
goto stage2c
)
:stage2d
DE4DOT-X64 PCL2.exe
timeout 5
IF EXIST PCL2-cleaned.exe (
echo Done!
echo 按任意键进入下一步
pause 1>nul
) else (
echo de4dot反混淆失败
echo 按任意键重试
pause 1>nul
goto stage2d
)
:stage3
cls
echo 步骤3
echo 使用dnspy打开PCL2
echo 按任意键打开
pause 1>nul
:stage3c
where dnspy.exe 1>nul
IF NOT ERRORLEVEL 1 (
echo 检测到dnspy
echo 按任意键打开dnspy
pause 1>nul
) else (
echo 未检测到dnspy
echo 请从    https://github.com/0xd4d/dnspy    下载或编译最新版
echo 按任意键重新检测
pause 1>nul
goto stage3c
)
start dnspy PCL2-cleaned.exe
timeout 19
:stage4
cls
echo 步骤四
echo 解锁金色主题
echo 金色主题检查函数应该在SecureRemoveRsa内（善用程序集搜索功能，搜索方法）
echo 右键编辑函数
echo 然后改为return true;
echo 点击编译
echo 然后点击左上角文件->保存模块
echo 点击确认就好
echo 懂了吗？
echo 管你懂没懂，下一步就对了
echo 按任意键进入下一步骤
pause 1>nul
:stage5
cls
echo 步骤五
echo 检查金色主题
echo 按任意键启动PCL2
pause 1>nul
start pcl2.exe
timeout 300
REM https://github.com/VBSSCBGroup/PLC2Tool/releases/download/v0.1/Debug.7z
:stage6
cls
echo 步骤六
echo 使用PCL2配置工具配置注册表
echo 按任意键启动PCL2配置工具
pause 1>nul
:stage6c
where PLC2Tool.exe 1>nul
IF NOT ERRORLEVEL 1 (
echo 检测到PCL2配置工具
echo 按任意键开始自动化反混淆
pause 1>nul
) ELSE (
echo 未检测到PCL2配置工具
echo 请从    https://github.com/VBSSCBGroup/PLC2Tool    下载或编译最新版
echo (    https://github.com/VBSSCBGroup/PLC2Tool/releases/download/v0.1/Debug.7z    )
echo 按任意键重新检测
pause 1>nul
goto stage6c
)
PLC2Tool
:stage7
echo 步骤七
echo 已完成！请检查你的PCL2
echo 按任意键退出向导
timeout 5 1>nul