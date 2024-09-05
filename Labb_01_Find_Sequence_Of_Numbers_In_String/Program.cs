Console.Write("Skriv in en text: ");
string input = Console.ReadLine();
SumOfAllSeqNumbers(input);

///  Takes a string and prints the sequenses where there is 
///  a repeted number with numbers inbetween but not any other characters
///  and then sums the matching sequenses together.
static void SumOfAllSeqNumbers(string input)
{
    Console.WriteLine();
    long sumOfAll = 0;

    for (int i = 0; i < input.Length; i++)
    {
        char startChar = input[i];
        if (CharIsNotDigit(startChar)) continue;

        string currentSequence = $"{startChar}";

        for (int j = i + 1; j < input.Length; j++)
        {
            char currentChar = input[j];

            if (CharIsNotDigit(currentChar)) break;

            currentSequence += currentChar;

            if (startChar == currentChar)
            {
                sumOfAll += long.Parse(currentSequence);
                HighlightedPrint(input, i, j);
                break;
            }
        }
    }
    Console.WriteLine($"\nTotal = {sumOfAll}");
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

/// Checking a character with ascii conversion if its a number is outside the scope of 0-9 
static bool CharIsNotDigit(char c) => ((c - '0') < 0 || (c - '0') > 9);

// Test cases

//string preset = "29535123p48723487597645723645";
//SumOfAllSeqNumbers(preset);
//Console.WriteLine("\n--------------------------------------------\n");

//string asciiDumb = "295८35123៦487234875976፫45723645";
//SumOfAllSeqNumbers(asciiDumb);
//Console.WriteLine("\n--------------------------------------------\n");