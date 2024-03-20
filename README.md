# Test OpenVINO EP with both .net framework (net472) and .net (net8.0)

1. Grab archive: https://storage.openvinotoolkit.org/repositories/openvino/packages/2023.3/windows
2. Extract to C:\Program Files (x86)\Intel\openvino_2023.3.0
3. Open cmd (does NOT work in powershell)
4. Run: setupvars.bat
5. Run: OpenVINO test from net472 (fails) and net8.0 (works) in the same cmd window.

Results:

net472:
```cmd
d:\source\OpenVINO_BasicTest\OpenVINO_Test\bin\Debug\net472>.\OpenVINO_Test.exe
Hello, OpenVINO World!

Unhandled Exception: System.EntryPointNotFoundException: Unable to find an entry point named 'OrtSessionOptionsAppendExecutionProvider_OpenVINO' in DLL 'onnxruntime'.
   at Microsoft.ML.OnnxRuntime.NativeMethods.OrtSessionOptionsAppendExecutionProvider_OpenVINO(IntPtr options, Byte[] device_id)
   at Microsoft.ML.OnnxRuntime.SessionOptions.AppendExecutionProvider_OpenVINO(String deviceId)
   at Program.<Main>$(String[] args) in D:\source\OpenVINO_BasicTest\OpenVINO_Test\Program.cs:line 6
```

net8.0:

```cmd
d:\source\OpenVINO_BasicTest\OpenVINO_Test\bin\Debug>.\net8.0\OpenVINO_Test.exe
Hello, OpenVINO World!

d:\source\OpenVINO_BasicTest\OpenVINO_Test\bin\Debug>
```