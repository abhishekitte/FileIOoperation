﻿using FileIOoperation.FileIO;
using System;

namespace FileIOoperation.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO Operations");
            //string path = @"C:\Users\pihu\source\repos\FileIOoperation.cs\FileIOoperation.cs\FileIO\Sample.txt";
            FileReadWriteOperation file = new FileReadWriteOperation();
            file.ReadFromStreamReader();
            Console.ReadLine();
        }
    }
}