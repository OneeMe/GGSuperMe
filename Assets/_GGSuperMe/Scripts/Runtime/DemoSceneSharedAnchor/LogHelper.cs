﻿/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2024 PICO Developer
// SPDX-License-Identifier: MIT
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using UnityEngine;
using System.IO;
using System;


public class LogHelper
{
    [Header("Save log type")]
    public bool _Log = true;
    public bool _Warning = true;
    public bool _Assert = true;
    public bool _Exception = true;
    public bool _Error = true;

    string fileName
    {
        get
        {
            return $"log_{DateTime.Now}";
        }
    }

    private void CaptureLog()
    {
        UnityEngine.Application.logMessageReceivedThreaded += CaptureLogThread;
        Debug.Log("Log begin.");
    }

    private void CaptureLogThread(string condition, string stackTrace, LogType type)
    {
        string error = "";
        switch (type)
        {
            case LogType.Error:
                error = StackTraceUtility.ExtractStackTrace();
                if (!_Error)
                {
                    return;
                }
                break;
            case LogType.Assert:
                if (!_Assert)
                {
                    return;
                }
                break;
            case LogType.Warning:
                if (!_Warning)
                {
                    return;
                }
                break;
            case LogType.Log:
                if (!_Log)
                {
                    return;
                }
                break;
            case LogType.Exception:
                error = StackTraceUtility.ExtractStackTrace();
                if (!_Exception)
                {
                    return;
                }
                break;
            default:
                break;
        }
        string log = type + $" >> {DateTime.Now.ToString()} \n {condition} \n {error} \n";
        SaveLog(log);
    }

    void SaveLog(string log)
    {
        string path;
        if (UnityEngine.Application.platform == RuntimePlatform.Android)
        {
            path = UnityEngine.Application.persistentDataPath + "/log.txt";
        }
        else
        {
            path = "log.txt";
        }
        if (File.Exists(path))
        {
            File.AppendAllText(path, log);
        }
        else
        {
            File.WriteAllText(path, log);
        }
    }

    public static void LogInfo(string tag, string msg)
    {
        Log(tag, msg, LogType.Log);
    }
    public static void LogWarning(string tag, string msg)
    {
        Log(tag, msg, LogType.Warning);
    }
    public static void LogError(string tag, string msg)
    {
        Log(tag, msg, LogType.Error);
    }
    static void Log(string tag, string msg, LogType logType)
    {
        string str = $"[{tag}] {msg}";
        if (logType == LogType.Log)
            Debug.Log(str);
        else if (logType == LogType.Warning)
            Debug.LogWarning(str);
        else
            Debug.LogError(str);
    }
}
