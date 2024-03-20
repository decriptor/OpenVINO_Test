using Microsoft.ML.OnnxRuntime;

Console.WriteLine("Hello, OpenVINO World!");

var options = new SessionOptions();
options.AppendExecutionProvider_OpenVINO("AUTO:GPU,CPU");
