//string preset = "29535123p48723487597645723645";
//SumOfAllSeqNumbers(preset);
//Console.WriteLine("\n--------------------------------------------\n");

Console.Write("Skriv in en text: ");
string input = Console.ReadLine();
SumOfAllSeqNumbers(input);

static void SumOfAllSeqNumbers(string userInput)
{
    Console.WriteLine();
    long sumOfAll = 0;
    for (int i = 0; i < userInput.Length; i++)
    {
        char startChar = userInput[i];
        string currentSequence = $"{startChar}";

        for (int j = i + 1; j < userInput.Length; j++)
        {
            char currentChar = userInput[j];

            if (IsNotDigit(currentChar))
            {
                currentSequence = "";
                break;
            }

            currentSequence += currentChar;

            if (startChar == currentChar)
            {
                sumOfAll += long.Parse(currentSequence);
                HighlightedPrint(userInput, i, j);
                break;
            }
        }
    }
    Console.WriteLine($"\nTotal = {sumOfAll}");
}

static void HighlightedPrint(string userInput, int startIndex, int endIndex)
{
    for (int i = 0; i < userInput.Length; i++)
    {
        if (i == startIndex) Console.ForegroundColor = ConsoleColor.Red;

        Console.Write(userInput[i]);

        if (i == endIndex) Console.ForegroundColor = ConsoleColor.Gray;
    }
    Console.WriteLine();
}

static bool IsNotDigit(char c) => char.GetNumericValue(c) == -1;