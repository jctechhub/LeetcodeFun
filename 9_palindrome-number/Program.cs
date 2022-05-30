// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var num = 1245421;
var result = IsPalindrome(num);

Console.WriteLine(result);


 static bool IsPalindrome(int x)
{

    if (x < 0 || (x % 10 == 0 && x != 0)) return false;


    int reverseNumber = 0;
    while (x > reverseNumber)
    {
        Console.WriteLine("---");
        reverseNumber = reverseNumber * 10 + x % 10;
        Console.WriteLine(reverseNumber);
        x /= 10;
        Console.WriteLine(x);
    }

    return x == reverseNumber || x == reverseNumber / 10;

}