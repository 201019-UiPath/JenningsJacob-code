﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSharpLib
{
    public class TestDemo
    {
        public void GetFullName(string firstName, string middleName, string lastName)
        {
            if (!String.IsNullOrEmpty(middleName))
            {
                Console.WriteLine($"{firstName} {middleName} {lastName}");
            }
            else
            {
                Console.WriteLine($"{firstName} {lastName}");
            }
        }
        public List<string> LoadFile()
        {
            List<string> output = new List<string>();
            List<string> lines = File.ReadAllLines(@"C:\Revature\201019-UTA0UiPath\JenningsJacob-code\5-UiPathFoundation\Text.txt").ToList();
            for (int i = 0; i < lines.Count - 1;  i++)
            {
                if(i % 2 == 0)
                {
                    output.Add(lines[i]);
                }
            }
            return output;
        }

    }
}