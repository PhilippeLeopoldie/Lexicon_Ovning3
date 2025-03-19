using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTraining;

internal class CodeChallengesPersonal
{
    /*public static string LongestCommonPrefix(string[] word)
   {
       if (word.Length == 0) return "";
       var prefix = word[0];
       for (var i = 1; i < word.Length; i++)
       {
           while (word[i].IndexOf(prefix) != 0)
           {
               prefix = prefix.Substring(0, prefix.Length - 1);

           }
       }
       return prefix;
   }*/


    /*  The task is to implement a function that takes a day of the week (as a string) 
     and returns whether it's a weekday or a weekend day.
      Feel free to use a switch statement for this task*/
    /*public static string DayOfWeek(string day)
    {
        var result="";
        switch(day.ToLower())
        {
          case "monday":
          case "tuesday":
          case "wednesday":
          case "thursday":
          case "friday":
            result="weekday";
            break;

          case "saturday":
          case "sunday":
            result= "weekendday";
            break;
          default:
          result="not a week day";
          break;
        }
        return result;
    }*/

    /*  The task is to implement a function that takes a day of the week (as a string) 
     and returns whether it's a weekday or a weekend day.
      Feel free to use a switch statement for this task*/
    public static string DayOfWeekVersion2(string day)
    {
        return day.ToLower() switch
        {
            "monday" or
            "tuesday" or
            "wednesday" or
            "thursday" or
            "friday" => "weekday",

            "saturday" or
            "sunday" => "weekendday",

            _ => "not a day"
        };
    }


    /*You are given two strings word1 and word2.
   Merge the strings by adding letters in alternating order, starting with word1.
    If a string is longer than the other, 
    append the additional letters onto the end of the merged string.*/
    /*public static string MergeAlternately(string word1, string word2)
    {
        var word1Length = word1.Length;
        var word2Length = word2.Length;
        var result = "";
        if (word1Length == word2Length || word1Length < word2Length)
        {
            for (int wordPosition = 0; wordPosition < word1Length; wordPosition++)
            {
                result += word1[wordPosition].ToString() + word2[wordPosition].ToString();
            }
            if (word1Length < word2Length)
            {
                result += word2.Substring(word1Length, word2Length - word1Length);
            }
        }
        else {
            for (int wordPosition = 0; wordPosition < word2Length; wordPosition++)
            {
                result += word1[wordPosition].ToString() + word2[wordPosition].ToString();
            }
            result += word1.Substring(word2Length, word1Length - word2Length);
        }
        return result;
    }*/


    /*check for gap between characters of a string*/
    /*public static void CheckForGapInString(string inputString)
    {
        char[] sortedChars = inputString.ToLower().Distinct().OrderBy(c => c).ToArray();

        for (int i = 0; i < sortedChars.Length - 1; i++)
        {
            char currentChar = sortedChars[i];
            char expectedNextChar = (char)(currentChar + 1);
            char actualNextChar = sortedChars[i + 1];

            if (expectedNextChar != sortedChars[i + 1])
            {
                Console.WriteLine($"Gap found between '{currentChar}' and '{actualNextChar}' should be '{expectedNextChar}' instead");
            }
        }

    }*/


    /*check for gap between numbers */
    /*public static void CheckForGapInNumbers(int inputNumber)
    {
        var inputToString = inputNumber.ToString();
        var inputLength = inputToString.Length;
        for(int i =0 ; i< inputLength -1; i++)
        {
          var currentDigit = int.Parse(inputToString[i].ToString());
          var nextExpectedDigit = currentDigit+1;
          var actualNextDigit = int.Parse(inputToString[i+1].ToString());

          if(nextExpectedDigit != actualNextDigit)
          {
            Console.WriteLine($"there is a gap between {currentDigit} and {actualNextDigit} , it should be {nextExpectedDigit} instead");
          }
        }
    }*/

    public static string CheckForGapInNumbersVersion2(int number)
    {
        var stringOfNumber = number.ToString();
        for (int i = 0; i < stringOfNumber.Length - 1; i++)
        {
            var currentDigit = stringOfNumber[i] - '0';
            var nextDigit = stringOfNumber[i + 1] - '0';

            if (nextDigit - currentDigit > 1) return $"there is a gap between  {currentDigit} and {nextDigit}";

        }
        return $"There is no gap in {number}";
    }

    /*public static bool ContainsDuplicate(int[] numbers)
    {
        var counter = 0;

        for(var i=0; i<nums.Length; i++)
        {
            for(var j =i+1; j<nums.Length; j++)
            {
                if(nums[i]==nums[j]) counter++;
                if(counter==1) return true;
            }
            counter=0;
        }

        return false;
      
        //var array = new int[1, 2, 3];
        
    }*/
    public static bool ContainsDuplicateVersion2(int[] numbers)
    {
        var sortedNumbers = numbers.OrderBy(x => x).ToArray();
        for (int i = 0; i < sortedNumbers.Length - 1; i++)
        {
            if (sortedNumbers[i] == sortedNumbers[i + 1])
            {
                return true;
            }
        }
        return false;
    }

    public static bool ContainsDuplicateVersion3(int[] numbers)
    {
        var seenNumbers = new HashSet<int>();

        foreach (int number in numbers)
        {
            if (seenNumbers.Contains(number)) return true;
            seenNumbers.Add(number);
        }
        return false;
    }


    /*public static int PivotIndex(int[] nums)
    {
        int lSum = nums[0];
        int rSum = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            rSum += nums[i];
        }
        if (0 == rSum)
            return 0;
        for (int l = 1; l < nums.Length; l++)
        {
            rSum -= nums[l];
            if (lSum == rSum)
                return l;
            lSum += nums[l];

        }
        return -1;
    }*/

    public static string ReverseWord(string word)
    {
        return new string(word.Reverse().ToArray());
    }

    //replace vowel with the next letter in the alphabet
    public static string VowelChanger(string word)
    {
        var finalWord = new StringBuilder();
        var vowels = "aeiouy";
        foreach (var letter in word)
        {
            if (vowels.Contains(letter))
            {
                finalWord.Append((char)(letter + 1));
            }
            else
            {
                finalWord.Append(letter);
            }
        }
        return finalWord.ToString();
    }

    // replace every vowel with the next letter in the alphabet
    public static string VowelChangerVersion2(string word)
    {
        var vowel = "aeiouy";
        var finalWord = new StringBuilder(word);


        foreach (var letter in vowel)
        {
            finalWord.Replace(letter, (char)(letter + 1));
        }

        return finalWord.ToString();

    }
}
