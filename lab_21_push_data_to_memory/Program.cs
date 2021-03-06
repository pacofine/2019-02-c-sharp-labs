﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_21_push_data_to_memory
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var memoryStream = new MemoryStream())
            {
                byte[] buffer = new byte[100];
                //memorystream.Write(buffer);

                memoryStream.Flush(); //send data

                memoryStream.Position = 0; // reset pointer to start

                //read data
                var reader = new StreamReader(memoryStream);
                Console.WriteLine(reader.ReadToEnd());
            }    
        }
    }
}
