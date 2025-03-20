using System.Text;

namespace CodeTraining;

public static class CodeChallengesKattis
{
    /*------------------from https://open.kattis.com/ --------------------------------------------*/

    public static void FizzBuzz(int x, int y, int z)
    {
        for (int i = 1; i <= z; i++)
        {
            if (i % x != 0 && i % y != 0) Console.WriteLine(i);
            else if (i % x == 0 && i % y == 0) Console.WriteLine("FizzBuzz");
            else if (i % x == 0) Console.WriteLine("Fizz");
            else Console.WriteLine("Buzz");
        }
    }

    public static int getDifferences(int x, int y)
    {
        return Math.Abs(x - y);
    }

    public static void AlphabetConvertor(string line)
    {
        var transcript = new StringBuilder();
        foreach (var letter in line.ToLower())
        {
            transcript.Append(letter switch
            {
                'a' => "@",
                'b' => "8",
                'c' => "(",
                'd' => "|)",
                'e' => "3",
                'f' => "#",
                'g' => "6",
                'h' => "[-]",
                'i' => "|",
                'j' => "_|",
                'k' => "|<",
                'l' => "1",
                'm' => "[]\\/[]",
                'n' => "[]\\[]",
                'o' => "0",
                'p' => "|D",
                'q' => "(,)",
                'r' => "|Z",
                's' => "$",
                't' => "']['",
                'u' => "|_|",
                'v' => "\\/",
                'w' => "\\/\\/",
                'x' => "}{",
                'y' => "`/",
                'z' => '2',
                _ => letter.ToString()
            });
        }
        Console.WriteLine(transcript.ToString());
    }

    public static string AlphabetConvertorVersion2( string line)
    {
        var transcript = new StringBuilder();
        var dictionary = new Dictionary<char, string>
        {
             {'a' , "@"},{'b',"8"}// and so on...
        };

        foreach(var letter in line)
        {
            transcript.Append(dictionary.GetValueOrDefault(Char.ToLower(letter),letter.ToString()));
        }
        return transcript.ToString();
    }

    /*-----------------------------------------------------------------------------*/
    // After taking the online test, I double-checked my answers and corrected my mistakes afterward.

    public static int getGreatestNumber(int[] array)
    {
        return array.OrderDescending().ToArray()[0] ;
    }

   
    public static int getGreatestNumberVersion2(int[] numbers)
    {
        Array.Sort(numbers);
        return numbers[numbers.Length - 1];
    }

    public static string IsEvenOrOdd(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }

    public static string Fibonacci(int number)
    {
        // expected output: 6 (sequence: 0, 1, 1, 2, 3, 5)

        var sequenceResult = " (sequence: ";

        if (number == 0) return $"{number}{sequenceResult += number})";
        if (number == 1) return $"{number}{sequenceResult += "0, "+number})";
        // index 1 in the sequence
        var previousValue = 0;
        var currentValue = 1;
        var nextValue = previousValue + currentValue;// value = 1
        sequenceResult += $"{previousValue}, {currentValue}";

        for (int i = 2; i < number ; i++)
        {
            previousValue = currentValue;
            currentValue = nextValue;
            nextValue = previousValue + currentValue;
            sequenceResult += $", {currentValue}";
        }
        return $"{number} {sequenceResult})";
    }

}


    


