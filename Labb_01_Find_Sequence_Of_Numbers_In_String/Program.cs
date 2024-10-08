﻿Console.Write("Skriv in en text: ");
string input = Console.ReadLine();
SumOfAllSeqNumbers(input);

static void SumOfAllSeqNumbers(string input)
{
    Console.WriteLine();
    ulong result = 0;

    for (int i = 0; i < input.Length; i++)
    {
        char startChar = input[i];
        string currentSequence = string.Empty;

        for (int j = i; j < input.Length; j++)
        {
            char currentChar = input[j];

            if (!char.IsAsciiDigit(currentChar)) break;

            currentSequence += currentChar;

            if (j != i && startChar == currentChar)
            {
                result += ulong.Parse(currentSequence);
                HighlightedPrint(input, i, j);
                break;
            }
        }
    }
    Console.WriteLine($"\nTotal = {result}");
}

/// Takes a string and highlights the text in red from startIndex to endIndex
static void HighlightedPrint(string input, int startIndex, int endIndex)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (i == startIndex) Console.ForegroundColor = ConsoleColor.Red;

        Console.Write(input[i]);

        if (i == endIndex) Console.ForegroundColor = ConsoleColor.Gray;
    }
    Console.WriteLine();
}