// what does this function do?
/*
int[] numbers = new int[] { -4, -7, 0, 3, -9, 12, 1 };
unknownFunction(numbers);

int unknownFunction(int[] a)
{
    int r = int.MaxValue;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] < r)
        {
            r = a[i];
        }
    }

    return r;
}

// returns the lowes value of the array
// a.length = 7 (size of the array
// if (a[i] < r) = is the index of the array less than the stored value of r
//on end return the lowest value within the array
*/

/*
using System;

Console.WriteLine("Give me a text that I should put to Lower Case.");
char[] myText = Console.ReadLine().ToCharArray();
ToLower(myText);
Console.WriteLine($"Result: {new string(myText)}");

// What is wrong with this function?
void ToLower(char[] chars)
{
    for (int i = 0; i < chars.Length; i++)
    {
        if (chars[i] > 'A' && chars[i] < 'Z' + 1)
        {
            chars[i] = (char)(chars[i] + 32);
        }
    }
}

//It looks through the array at what Char is at what index
//(chars[i] > 'A' && chars[i] < 'Z' + 1) Validates the Char if its in between A-Z 
//chars[i] = (char)(chars[i] - 63); the problem here is that it takes the Char at that index, For example "H" and then it takes the value of H in ascii and minus 63
//This then outputs the symbol in the ascii which is located at H-63
//To fix this we need to +32 instead of -63
*/


/*
using System;
using System.Linq;

Console.WriteLine("Give me numbers separated by comma that I should Sum Up.");
int[] numbers = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
Console.WriteLine($"Result: {SumOfNumbers(numbers)}");

// What is wrong with this function?
int SumOfNumbers(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum;
}

//The problem with the code is i <= numbers.Length
//Solution is i < numbers.Length
*/


/*
using System;

int[] numbers = { 500, 600, 700 };
Console.WriteLine($"I am calculating the average of: {string.Join(", ", numbers)}: {Average(numbers)}");

numbers = new[] { 1_000_000_000, 1_000_000_001, 1_000_000_002, 1_000_000_003, 1_000_000_004 };
Console.WriteLine($"I am calculating the average of: {string.Join(", ", numbers)}: {Average(numbers)}");

// What's wrong with this function?
int Average(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum / numbers.Length;
}

//Same as the previous example we need to change <= to just <. It's because it goes one element beyond the last valid index of the array
*/

using System;

int minDamage = 100;
int maxDamage = 1100;
int maxLevel = 100;

Console.WriteLine("What level are you at?");
int level = int.Parse(Console.ReadLine());


Console.WriteLine($"Your damage at that level: {DamageAtLevel(level)}");


int DamageAtLevel(int level)
{
    // Calculate the damage increase per level, ensuring floating-point precision
    double damageIncreasePerLevel = (double)(maxDamage - minDamage) / maxLevel;

    // Calculate the damage, capping it at maxDamage
    return (int)Math.Min(minDamage + level * damageIncreasePerLevel, maxDamage);
}
