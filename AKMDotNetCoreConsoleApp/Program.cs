﻿// See https://aka.ms/new-console-template for more information
using AKMDotNetCoreConsoleApp.AKMDotNetCoreExamples;
using AKMDotNetCoreConsoleApp.DapperExamples;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

AKMDotNetCoreExample adoDotNetExample = new AKMDotNetCoreExample();
adoDotNetExample.Run();

//DapperExample dapperExample = new DapperExample();
//dapperExample.Run();


Console.ReadKey();