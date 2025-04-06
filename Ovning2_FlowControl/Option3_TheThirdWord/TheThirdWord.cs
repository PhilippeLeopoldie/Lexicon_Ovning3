namespace Option3_TheThirdWord
{
    public static class TheThirdWord
    {
        public static void Run()
        {
            var isValid = false;
            var result = "";
            do
            {
                Console.WriteLine("-------Third Word Extractor-------");
                Console.WriteLine("Enter a sentence of at least 3 words:");
                var input = Console.ReadLine().Trim();
                var inputArray = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (inputArray.Count() >= 3)
                {
                    isValid = true;
                    result = inputArray[2];
                }
            }
            while (!isValid);
            Console.WriteLine(result);
        }
    }
}