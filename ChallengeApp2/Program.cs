﻿using System.Data;

ulong number = ulong.MaxValue;
string numberInString = number.ToString();
char[] digit = numberInString.ToArray();
int[] counters = { 0,0,0,0,0,0,0,0,0,0 };

foreach (var letter in digit)
    if(letter == '0')
    {
        counters[0]++;
    }    
    else if (letter == '1')
    {
        counters[1]++;
    }
    else if (letter == '2')
    {
        counters[2]++;
    }
    else if (letter == '3')
    {
        counters[3]++;
    }
    else if (letter == '4')
    {
        counters[4]++;
    }
    else if (letter == '5')
    {
        counters[5]++;
    }
    else if (letter == '6')
    {
        counters[6]++;
    }
    else if (letter == '7')
    {
        counters[7]++;
    }
    else if (letter == '8')
    {
        counters[8]++;
    }
    else if (letter == '9')
    {
        counters[9]++;
    }
Console.WriteLine("0 ==> " + counters[0]);
Console.WriteLine("1 ==> " + counters[1]);
Console.WriteLine("2 ==> " + counters[2]);
Console.WriteLine("3 ==> " + counters[3]);
Console.WriteLine("4 ==> " + counters[4]);
Console.WriteLine("5 ==> " + counters[5]);
Console.WriteLine("6 ==> " + counters[6]);
Console.WriteLine("7 ==> " + counters[7]);
Console.WriteLine("8 ==> " + counters[8]);
Console.WriteLine("9 ==> " + counters[9]);