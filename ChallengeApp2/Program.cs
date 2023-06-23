using System.Data;

ulong number = 12345678905821487962;
string numberInString = number.ToString();
char[] letter = numberInString.ToArray();
int[] counters = new int[10];

foreach (var digit in letter)

    if(digit == '0')
    {
        counters[0]++;
    }    
    else if (digit == '1')
    {
        counters[1]++;
    }
    else if (digit == '2')
    {
        counters[2]++;
    }
    else if (digit == '3')
    {
        counters[3]++;
    }
    else if (digit == '4')
    {
        counters[4]++;
    }
    else if (digit == '5')
    {
        counters[5]++;
    }
    else if (digit == '6')
    {
        counters[6]++;
    }
    else if (digit == '7')
    {
        counters[7]++;
    }
    else if (digit == '8')
    {
        counters[8]++;
    }
    else if (digit == '9')
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