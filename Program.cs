using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ExceptionHandling
{
    class ErrorFile
    {
        public static void Main(string[] args)
        {
            try
            {
                //divideByZero
                //int num1 = 10;
                //int num2 = 0;
                //int result = num1 / num2;

                //ArrayOutOfRange
                //int[] Arr = { 10, 20, 30 };
                //Console.WriteLine(Arr[5]);

                //FileNotFound
                //User Exception
                //string strpath = @"F:\Abc.txt";
                //if(!File.Exists(strpath))
                //{
                //    throw new Exception("File Not Found");
                //    //Console.WriteLine("File Not found");

                //}

                //FormatException
                //string str = "3.999";
                //int res = int.Parse(str);

                //NullReferenceException

                string str1 = null;
                str1.Substring(5);


            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception caught: {0}", ex.Message);
                WriteLog(ex);
                ReadLog();
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception caught: {0}", ex);
                WriteLog(ex);
                ReadLog();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Exception caught: {0}", ex);
                WriteLog(ex);
                ReadLog();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Exception caught: {0}", ex);
                WriteLog(ex);
                ReadLog();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: {0}", ex);
                WriteLog(ex);
                ReadLog();
            }
            



            void WriteLog(Exception ex)
            {
                string Path = @"F:\Assignments\C#\ErrorFile.txt";
                if (!File.Exists(Path))
                {
                    File.Create(Path).Dispose();
                }
                StreamWriter Sw = File.AppendText(Path);
                Sw.WriteLine("Error Message: "+ex.Message);
                Sw.WriteLine("----------------------------");
                Sw.Close();

            }
             void ReadLog()
            {
                string Path = @"F:\Assignments\C#\ErrorFile.txt";
                StreamReader Sr = new StreamReader(Path);
                string Exceptions;
                while ((Exceptions = Sr.ReadLine()) != null)
                {
                    Console.WriteLine(Exceptions);
                }
                Sr.Close();
            }


        }
    }
        }





    







