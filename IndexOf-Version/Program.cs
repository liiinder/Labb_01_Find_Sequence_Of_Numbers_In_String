// Labb 1 version "oläsligt..."
static void Labb1Short(string input)
{
    ulong result = 0;
    for (int i = 0; i < input.Length; i++)
    {
        int seqLength = input.Substring(i + 1).IndexOf(input[i]) + 2; 
        if (seqLength == 1) continue; 
        if (!ulong.TryParse(input.Substring(i, seqLength), out ulong currSum)) continue;
        result += currSum;
        Console.Write("\n" + input.Substring(0, i));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(input.Substring(i, seqLength));
        Console.ResetColor();
        Console.Write(input.Substring(i + seqLength));
    }
    Console.WriteLine($"\n\nTotal = {result}");
}

static string askUser()
{
    Console.Write("Skriv in en text: ");
    return Console.ReadLine();
}

//Labb1Short(askUser());
Labb1Short("29535123p48723487597645723645");

// Loopa tecken för tecken

// Kolla strängen från nästa tecken och till slutet efter ett matchande tecken
// i = 2 -> substring -> 35123p48723487597645723645 -> indexOf(5) -> 1 -> + 2 = 3 

// Är längden 1 så betyder det att raden ovan returnerade -1 (+2) och det inte finns en matchning

// Parsa substringen och spara ev summa i currSum.
// Om det finns bokstäver i substrängen "continue;"
// då vi inte vill spara och skriva ut denna

// Spara delresultatet och skriv ut raden