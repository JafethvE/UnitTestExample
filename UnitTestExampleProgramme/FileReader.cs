﻿using System;
using System.IO;

namespace UnitTestExampleProgramme
{
    class FileReader
    {
        public static string[] GetLinesFromTextFile(string filePath)
        {
            try
            { 
                return File.ReadAllLines(filePath);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void CreateEmptyFile(string filePath)
        {
            try
            {
                File.Create(filePath).Dispose();
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public static void DeleteFile(string filepath)
        {
            try
            {
                File.Delete(filepath);
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    }
}