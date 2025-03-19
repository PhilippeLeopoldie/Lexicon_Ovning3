// See https://aka.ms/new-console-template for more information
/*int[] numbers = new int[5];
numbers.Count();
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3; 
numbers[3] = 4; 
numbers[4] = 5; 

Console.WriteLine(numbers.Length);*/

string[] names = new string[] { "Eddie","Alex" };

/*for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

foreach (string name in names)
{ 
    Console.WriteLine(name); 
}*/
string zig = "abcdefgh";
char[] charArray = zig.ToCharArray();
Array.Reverse(charArray);
Console.WriteLine(charArray);