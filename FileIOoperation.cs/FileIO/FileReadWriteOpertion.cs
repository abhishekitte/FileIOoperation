﻿using System;
using System.IO;

namespace FileIOoperation.FileIO
{
    class FileReadWriteOperation
    {
        public bool FilExists(string path)
        {
            //File is a class
            if (File.Exists(path))
            {
                Console.WriteLine("File exists");
                return true;
            }
            else
            {
                Console.WriteLine("File not exists");
                return false;
            }
        }

        //Method to read all lines in a file 
        public void ReadAllLinesInFile()
        {
            try
            {
                string[] lines;
                string path = @"H:\visualstudio\FileIOoperation\FileIOoperation\FileIO\Sample.txt";
                //Reads all lines in file one by one 
                lines = File.ReadAllLines(path);
                if (lines.Length != 0)
                {
                    foreach (var i in lines)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Method to read all texts from the file
        public void ReadAllTextInFile()
        {
            try
            {
                string text;
                string path = @"C:\Users\pihu\source\repos\FileIOoperation.cs\FileIOoperation.cs\FileIO\Sample.txt";
                //Read all lines in a file at once
                text = File.ReadAllText(path);
                if (text.Length != 0)
                {
                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine("File does not contain any text");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Copying existing file in to new one
        public void CopyMethod(string path)
        {
            //It will automatically create new file for write operation
            string destination = @"C:\Users\pihu\source\repos\FileIOoperation.cs\FileIOoperation.cs\FileIO\Sample1.txt";
            try
            {
                File.Copy(path, destination);
                Console.WriteLine("file is copied successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}