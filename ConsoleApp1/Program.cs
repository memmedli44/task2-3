﻿using Microsoft.Win32.SafeHandles;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region taks 1
        //l1:
        //    Console.WriteLine("4 reqemli ededi daxil edin");
        //    string strvalue = Console.ReadLine();
        //    bool tru = int.TryParse(strvalue, out int value);
        //    int say = (int)Math.Log10((int)value) + 1;
        //    if (!tru)
        //    {
        //        goto l1;
        //    }
        //    if (say != 4)
        //    {
        //        goto l1;
        //    }
        //    int sum = 0;
        //    while (value>0)
        //    {
        //        int resudie = value % 10;
        //        value /= 10;
        //        sum += resudie;
        //    }
        //    Console.WriteLine(sum);
        #endregion

        #region Task 2
        //l1:
        //    Console.Write("6 reqemli ededi daxil edin:");
        //    string streded=Console.ReadLine();
        //    bool yoxla = int.TryParse(streded, out int eded);


        //    if (!yoxla) 
        //    {
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(eded) + 1 != 6)
        //    {
        //        goto l1;
        //    }
        //    eded /= 1000;
        //    int sum=0;
        //    while (eded>0)
        //    {
        //        int qaliq = eded % 10;
        //        eded=eded / 10;
        //        sum+=qaliq;

        //    }
        //    Console.WriteLine(sum);
        #endregion

        #region task 3
        //l1:
        //    Console.Write("9 reqemli ededi daxil edin:");
        //    string streded = Console.ReadLine();
        //    bool yoxla = int.TryParse(streded, out int eded);


        //    if (!yoxla)
        //    {
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(eded) + 1 != 9)
        //    {
        //        goto l1;
        //    }
        //    eded /= 1000;
        //    int sum = 0;
        //    while (eded>999)
        //    {
        //        int qaliq = eded % 10;
        //        eded = eded / 10;
        //        sum += qaliq;

        //    }
        //    Console.WriteLine(sum);

        #endregion

        #region task 4

        //l1:
        //    Console.Write("5 reqemli ededi daxil edin:");
        //    string streded = Console.ReadLine();
        //    bool yoxla = int.TryParse(streded, out int eded);


        //    if (!yoxla)
        //    {
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(eded) + 1 != 5)
        //    {
        //        goto l1;
        //    }
        //   int  qaliq1 = eded % 10;
        //    eded /= 10000;
        //   int sum= qaliq1 + eded;

        //    Console.WriteLine(sum);
        #endregion

        #region taks 5
        //l1:
        //    Console.WriteLine("6 reqemli ededi daxil edin");
        //    string strvalue = Console.ReadLine();
        //    bool tru = int.TryParse(strvalue, out int value);
        //    int say = (int)Math.Log10((int)value) + 1;
        //    if (!tru)
        //    {
        //        goto l1;
        //    }
        //    if (say != 6)
        //    {
        //        goto l1;
        //    }

        //   int valueilk= value / 100000;
        //    int resudie = value % 100000;
        //    int final = resudie * 10 + valueilk;
        //    Console.WriteLine(final);
        #endregion

        #region task 6
        //l1:
        //Console.Write("8 reqemli ededi daxil edin:");
        //string streded = Console.ReadLine();
        //bool yoxla = int.TryParse(streded, out int eded);


        //if (!yoxla)
        //{
        //    goto l1;
        //}
        //if ((int)Math.Log10(eded) + 1 != 8)
        //{
        //    goto l1;
        //}
        //int qaliq1 = eded % 10;
        //int qaliq2 = eded / 10000000;
        //int sum=(eded - qaliq2 * 10000000 - qaliq1) / 10;
        //Console.WriteLine(sum);

        #endregion

        #region taks 7 
        //l1:
        //Console.WriteLine("4 reqemli eded daxil edin");
        //string streded=Console.ReadLine();
        //bool say= int.TryParse(streded, out int eded);
        //if (!say)
        //{
        //    goto l1;
        //}

        //int sum= 0;
        //while (eded>0)
        //{
        //    int qaliq = eded % 10;
        //    eded=eded/10;
        //    sum = sum * 10 + qaliq;

        //}
        //decimal add = (8 * 10000 + sum)*10+8;
        //Console.WriteLine(add);

        #endregion

        #region task 8  

        //Console.WriteLine("4 reqemli eded daxil edin");
        //string streded = Console.ReadLine();
        //bool say = int.TryParse(streded, out int eded);
        //if (!say)
        //{
        //    goto l1;
        //}

        //int qaliq = eded % 10;
        //int qaliq3 = eded % 1000;
        //int eded3=qaliq3/ 100;
        //int cem = qaliq + eded3;
        //Console.WriteLine(cem);

        #endregion

        #region task 9
        //l1:
        //    Console.Write("9 reqemli eded daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        goto l1;
        //    }
        //    if (((int)Math.Log10(value) + 1) != 9)
        //    {
        //        goto l1;
        //    }
        //    int sum = 0;
        //    while (value > 0) 
        //    {
        //        int remainder=value% 10;
        //        value /= 100;
        //        sum = sum * 10 + remainder;
        //    }
        //    int result = 0;
        //    while (sum > 0)
        //    {
        //        int remainder = sum % 10;
        //        sum /= 10;
        //         result=result*10 + remainder;
        //    }
        //    Console.WriteLine(result);
        #endregion

        #region task 10            
        //l1:
        //    Console.Write("9 reqemli eded daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        goto l1;
        //    }
        //    if (((int)Math.Log10(value) + 1) != 9)
        //    {
        //        goto l1;
        //    }
        //int newValue = 0;
        //while (value > 0)
        //{
        //    int qaliq = value % 10;
        //    value /= 10;
        //    newValue = newValue * 10 + qaliq;


        //}
        //Console.WriteLine(newValue);
        //int resultFirst = 0;
        //int scndResult = 0;
        //int scndValue = newValue;     
        //while (scndValue > 0)
        //{
        //    int qaliq2 = scndValue % 10;
        //    scndValue /= 100;
        //    resultFirst = resultFirst * 10 + qaliq2;

        //}
        //newValue = newValue / 10;
        //while (newValue > 0)
        //{

        //    int qaliq3 = newValue % 10;
        //    newValue /= 100;
        //    scndResult = scndResult * 10 + qaliq3;

        //}
        //int lastResult = scndResult + resultFirst;

        //Console.WriteLine(lastResult);
        //Console.WriteLine(scndResult);
        //Console.WriteLine(resultFirst);

        #endregion

        #region task 11
        //l1:
        //    Console.Write(" ededi daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l1;
        //    }
        //    if (((int)Math.Log10(value) + 1) != 8)
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l1;
        //    }
        //    int sum = 0;
        //    while(value> 0)
        //    {
        //        int remainder = value % 100;
        //        value /= 100;
        //        sum += remainder;
        //    }
        //    int firstStep = sum * 100 + 99;
        //    decimal lastStep = firstStep * 0.72m;
        //    Console.WriteLine(lastStep);


        #endregion

        #region task 12
        //l1:
        //    Console.Write("ilk ededi daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l1;
        //    }
        //    if (((int)Math.Log10(value) + 1) != 5)
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l1;
        //    }
        //l2:
        //    Console.Write("ikinci ededi daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int scndValue))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edilmemisdir ");
        //        goto l2;
        //    }
        //    if (((int)Math.Log10(scndValue) + 1) != 5)
        //    {
        //        Console.WriteLine("ededi duzgun daxil edilmemisdir ");
        //        goto l2;
        //    }
        //    int FirstStep = value % 10;
        //    int sum= 0;
        //    while(value> 0)
        //    {
        //        int remainderFirst= value % 10;
        //        value /= 10;
        //        sum += remainderFirst;
        //    }
        //    int sum2 = 1;
        //    while(scndValue> 0)
        //    {
        //        int remainderScnd=scndValue% 10;
        //        scndValue /= 10;
        //        sum2 *= remainderScnd;
        //    }
        //    int firsResult = sum + sum2;
        //    int lastResult = firsResult * 10 + FirstStep;
        //    Console.WriteLine(lastResult);

        #endregion

        #region task 13

        //l1:
        //    Console.Write("ilk ededi daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l1;
        //    }
        //    if (((int)Math.Log10(value) + 1) != 5)
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l1;
        //    }
        //l2:
        //    Console.Write("ilk ededi daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int scndValue))
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l2;
        //    }
        //    if (((int)Math.Log10(scndValue) + 1) != 5)
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l2;
        //    }
        //l3:
        //    Console.Write("ilk ededi daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int thirdvalue))
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l3;
        //    }
        //    if (((int)Math.Log10(thirdvalue) + 1) != 5)
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l3;
        //    }
        //    int firstStep = (10 * (value / 10000) + value % 10) + (10 * (scndValue / 10000) + scndValue % 10) + (10 * (thirdvalue / 10000) + thirdvalue % 10);
        //    decimal result = firstStep + firstStep / 2;
        //    Console.WriteLine(result);

        #endregion

        #region TASK 14

        //l1:
        //    Console.Write("ilk ededi daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l1;
        //    }
        //    if (((int)Math.Log10(value) + 1) != 6)
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l1;
        //    }
        //l2:
        //    Console.Write(" ededi daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int scndValue))
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l2;
        //    }
        //    if (((int)Math.Log10(scndValue) + 1) != 6)
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l2;
        //    }
        //l3:
        //    Console.Write(" ededi daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int thirdvalue))
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l3;
        //    }
        //    if (((int)Math.Log10(thirdvalue) + 1) != 6)
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l3;
        //    }
        //l4:
        //    Console.Write(" ededi daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int valueFour))
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l4;
        //    }
        //    if (((int)Math.Log10(valueFour) + 1) != 7)
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l4;
        //    }
        //int sum1 = value / 1000 + scndValue / 1000 + thirdvalue / 1000;
        //int sum2 = 0;
        //int sum3 = 1;
        //int newValue = 0;
        //while (valueFour > 999)
        //{
        //    int remainder = valueFour % 10;
        //    valueFour /= 10;
        //    newValue = newValue * 10 + remainder;
        //}
        //while (valueFour > 0)
        //{
        //    int remainder = valueFour % 10;
        //    valueFour /= 10;
        //    sum3*=remainder;
        //}
        //while (newValue > 0)
        //{
        //    int  remainder= newValue % 10;
        //    newValue /= 10;
        //    sum2=sum2*10 + remainder;
        //}
        //int firstStep = sum1 + sum2;
        //int secondStep = firstStep - sum3;
        //int persentFirst = secondStep * 60 / 100;
        //int firstResult = persentFirst * 100 + 60;
        //decimal lastResult = firstResult * 0.72m;

        //Console.WriteLine(lastResult);
        #endregion

        #region task 15
        //l1:
        //    Console.Write("ilk ededi daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l1;
        //    }
        //    if (((int)Math.Log10(value) + 1) != 3)
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l1;
        //    }
        //l2:
        //    Console.Write(" ededi daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int scndValue))
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l2;
        //    }
        //    if (((int)Math.Log10(scndValue) + 1) != 3)
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l2;
        //    }
        //l3:
        //    Console.Write(" ededi daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int thirdvalue))
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l3;
        //    }
        //    if (((int)Math.Log10(thirdvalue) + 1) != 6)
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l3;
        //    }
        //l4:
        //    Console.Write(" ededi daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int valueFour))
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l4;
        //    }
        //    if (((int)Math.Log10(valueFour) + 1) != 6)
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l4;
        //    }
        //l5:
        //    Console.Write(" ededi daxil et: ");

        //    if (!int.TryParse(Console.ReadLine(), out int fifthvalue))
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l5;
        //    }
        //    if (((int)Math.Log10(fifthvalue) + 1) != 7)
        //    {
        //        Console.Write("ededi duzgun daxil edilmemisdir ");
        //        goto l5;
        //    }
        //    int stepFirst = value + scndValue;
        //    int stepTwo = (int)Math.Pow(stepFirst % 100, 2);
        //    int stepThree = stepTwo + (value * 1000 + scndValue);
        //    int stepFour = stepThree - fifthvalue % 100000;
        //    int stepFive = (thirdvalue + valueFour) % 1000;
        //    int stepSix = stepFour + stepFive;
        //    int sum = 0;
        //    int newnumber = fifthvalue;
        //    while (fifthvalue > 0)
        //    {
        //        int remainder = fifthvalue % 10;
        //        fifthvalue /= 10;
        //        sum += remainder;

        //    }
        //    int sum2 = 0;
        //    while (sum > 0)
        //    {
        //        int remainder = sum % 10;
        //        sum /= 10;
        //        sum2 = sum2 * 10 + remainder;
        //    }
        //    int stepSeven = stepSix + sum2;
        //    int step = stepSeven * 100 + 11;
        //    int sum3 = 0;
        //    while (newnumber > 0)
        //    {
        //        int remainder = newnumber % 10;
        //        newnumber /= 100;
        //        sum3 = sum3 * 10 + remainder;

        //    }
        //    int sum4 = 0;
        //    while (sum3 > 0)
        //    {
        //        int remainder = sum3 % 10;
        //        sum3 /= 10;
        //        sum4 = sum4 * 10 + remainder;
        //    }
        //    long lastStep = step - sum4;
        //    long persent = (long)lastStep % 10;
        //    long result = 1000 * (lastStep / 10) + 880 + persent;

        //    Console.WriteLine(lastStep);
        //    Console.WriteLine(result);

            #endregion


        }


    }
}