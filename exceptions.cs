using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
    class exceptions
    {
    public static void Main(String[] args)
    {
        #region IOException
        //try
        //{
        //    File.Open("C:\\abc.txt", FileMode.Open);
        //}
        //catch (FileNotFoundException)
        //{
        //    Console.WriteLine("Not found");
        //}
        //catch (IOException)
        //{
        //    Console.WriteLine("IO");
        //}

        #endregion
        #region DivideByZeroException
        //try
        //{
        //    int num1, num2;
        //    int result;
        //    Console.WriteLine("Enter 1st number");
        //    num1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter 2nd number");
        //    num2 = int.Parse(Console.ReadLine());

        //    result = num1 / num2;
        //    Console.WriteLine(result);
        //}
        //catch(DivideByZeroException e)
        //{
        //    Console.WriteLine(e.Message);
        //}

        #endregion
        #region NullReferenceException
        //try {
        //    string str1 = null;
        //    str1.Substring(5);
        //}
        //catch(NullReferenceException e)
        //{
        //    Console.WriteLine(e.Message);
        //}


        #endregion
        #region IndexOutofRange
        //try
        //{
        //    int[] Arr = { 10, 20, 30 };
        //    Console.WriteLine(Arr[5]);
        //}
        //catch (IndexOutOfRangeException ex)
        //{
        //    Console.WriteLine("Exception caught: {0}", ex);
        //}

        #endregion
        #region OutOFMemory
        //StringBuilder sr = new StringBuilder(15,15);
        //sr.Append("String defined");
        //try
        //{
        //    sr.Insert(0,"String 2",1);
        //}
        //catch(OutOfMemoryException e)
        //{
        //    Console.WriteLine("Out of Memory"+ e.Message);
        //}
        #endregion
        #region SystemException
        //try
        //{
        //    string name = "virat";
        //    int result = int.Parse(name);

        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //}
        #endregion
        #region Multiple Exception
        //try
        //{
        //    int num1;
        //    int num2;
        //    int result;

        //   Console.WriteLine("Enter 1st number");
        //   num1 = int.Parse(Console.ReadLine());
        //   Console.WriteLine("Enter 2nd number");
        //   num2 = int.Parse(Console.ReadLine());

        //  result = num1 / num2;
        //  Console.WriteLine(result);
        //}
        //catch(DivideByZeroException e)
        //{
        //    Console.WriteLine("Cant Divide by zero",e);
        //}
        //catch(FormatException ex)
        //{
        //    Console.WriteLine("Only Integer Values",ex);
        //}
        #endregion

    }
    }

