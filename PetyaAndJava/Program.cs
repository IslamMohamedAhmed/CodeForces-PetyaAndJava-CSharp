using static System.Console;
using static System.Convert;
using static System.Math;


long n;

try
{
    n = ToInt64(ReadLine());

    if (n <= 127)
    {
        WriteLine("byte");
    }
    else if(n <= 32767) {
        WriteLine("short");
    }
    else if(n<= 2147483647)
    {
        WriteLine("int");
    }
    else
    {
        WriteLine("long");
    }
}
catch(Exception e)
{
    WriteLine("BigInteger");
}