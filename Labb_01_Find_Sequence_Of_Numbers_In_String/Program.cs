//Console.Write("Skriv in en text: ");
//string input = Console.ReadLine();
//SumOfAllSeqNumbers(input);

///  Takes a string and prints the sequenses where there is 
///  a repeted number with numbers inbetween but not any other characters
///  and then sums the matching sequenses together.
static void SumOfAllSeqNumbers(string input)
{
    Console.WriteLine();
    ulong sumOfAll = 0;

    for (int i = 0; i < input.Length; i++)
    {
        char startChar = input[i];
        string currentSequence = string.Empty;

        for (int j = i; j < input.Length; j++)
        {
            char currentChar = input[j];

            if (!char.IsAsciiDigit(currentChar)) break;

            currentSequence += currentChar;

            if (startChar == currentChar && j != i)
            {
                sumOfAll += ulong.Parse(currentSequence);
                HighlightedPrint(input, i, j);
                break;
            }
        }
    }
    Console.WriteLine($"\nTotal = {sumOfAll}");
}

/// Takes a string and highlights the text in red from startIndex to endIndex
//static void HighlightedPrint(string input, int startIndex, int endIndex, string color = "Green")
//{
//    for (int i = 0; i < input.Length; i++)
//    {

//        if (i == startIndex)
//        {
//            if (color == "Green") Console.ForegroundColor = ConsoleColor.Green;
//            if (color == "Red") Console.ForegroundColor = ConsoleColor.Red;
//        }
//        Console.Write(input[i]);

//        if (i == endIndex) Console.ForegroundColor = ConsoleColor.Gray;
//    }
//    Console.WriteLine();
//}

static void HighlightedPrint(string input, int startIndex, int endIndex)
{
    endIndex++;
    int length = endIndex - startIndex;

    string start = input.Substring(0, startIndex);
    string middle = input.Substring(startIndex, length);
    string end = input.Substring(endIndex);

    Console.Write(start);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(middle);
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(end + "\n");
}

/// Checking a character with ascii/unicode conversion if its outside the scope of the numbers 0-9
/// Without this method it will allow lots of other characters to be seen as numbers seen on this page.
/// https://stackoverflow.com/questions/2866738/whats-the-deal-with-char-getnumericvalue
//static bool CharIsNotDigit(char c) => ((c - '0') < 0 || (c - '0') > 9);

// Test cases

string preset = "29535123p48723487597645723645";
Console.WriteLine("29535123p48723487597645723645");
Console.WriteLine("preset.Lenght " + preset.Length);
SumOfAllSeqNumbers(preset);
Console.WriteLine("\n--------------------------------------------\n");

//string asciiDumb = "295८35123៦487234875976፫45723645";
//SumOfAllSeqNumbers(asciiDumb);
//Console.WriteLine("\n--------------------------------------------\n");
/// Would have worked to not use my method and use TryParse or char.IsAsciiDigit instead.


//int padding = 45;
//Console.WriteLine("char.IsDigit('८') = ".PadLeft(padding) + char.IsDigit('८'));
//Console.WriteLine("char.IsAsciiDigit('८') = ".PadLeft(padding) + char.IsAsciiDigit('८'));
//Console.WriteLine("char.IsAsciiDigit('८') = ".PadLeft(padding) + char.IsAscii('८'));
//Console.WriteLine("char.GetNumericValue('८') = ".PadLeft(padding) + char.GetNumericValue('८'));
//Console.WriteLine("Int32.TryParse(\"८\", out int result1) = ".PadLeft(padding) + Int32.TryParse("८", out int result1));
//Console.WriteLine("Int32.TryParse(\"८\", out int result1) = ".PadLeft(padding) + Int32.TryParse('८'.ToString(), out int result4));
//Console.WriteLine("Int32.TryParse(\"B\", out int result2) = ".PadLeft(padding) + Int32.TryParse("B", out int result2));
//Console.WriteLine("Int32.TryParse(\"123\", out int result3) = ".PadLeft(padding) + Int32.TryParse("123", out int result3));