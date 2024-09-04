//https://www.ithsdistans.se/mod/assign/view.php?id=46606

using System.Diagnostics.Metrics;
using System;

static string SumOfAllSeqNumbersInString(string userInput)
{
    // Spara strängen som en array för att kunna räkna på det som heltal.
    //int[] numberIntArray = new int[userInput.Length];
    //for (int i = 0; i < userInput.Length; i++)
    //{
    //    numberIntArray[i] = (int)char.GetNumericValue(userInput[i]);
    //}

    // loop som börjar på index 0 och sen kollar framåt efter ett index med samma värde.
    string savedSum = "";
    for (int i = 0; i < userInput.Length; i++)
    {
        // loopar på alla char i stringen.
        // t.ex. 29535123p ... 
        string tempSum = "";
        for (int j = i; j < userInput.Length; j++)
        {
            // 2 sen loopa -> tills vi hittar en 2 eller -1
            if (numberIntArray[j] == -1)
            {
                tempSum = "";
                break;
            }
            tempSum += numberIntArray[j];
            if (numberIntArray[j] == numberIntArray[i])
            {
                savedSum += tempSum;
                break;
            }
        }
    }
    // kolla om det finns någon -1 emellan för att avbryta

    // inget -1 är en giltlig sekvens och talet ska läggas till i summan
    // samt vi skriver ut strängen med röd text.

    // returnera summan...
    return savedSum;
}

string preset = "29535123p48723487597645723645";
string sum = SumOfAllSeqNumbersInString(preset);
Console.WriteLine($"Total = {sum}");

//static void exercise12()
//{
//    Console.Write("Mata in en text: ");
//    string text = Console.ReadLine();
//    Console.Write("Välj bokstav: ");
//    char bokstav = // siffra vi ska markera.
//    bool red = false;
//    foreach (char c in text) // byta till en for loop istället som byter mellan "start" och "slut" index.
//    {
//        if (c == bokstav) red = !red;
//        if (c == bokstav && red) Console.ForegroundColor = ConsoleColor.Red;
//        Console.Write(c);
//        if (c == bokstav && !red) Console.ForegroundColor = ConsoleColor.Gray;
//    }
//    Console.ForegroundColor = ConsoleColor.Gray;
//}

// // 2352

//metod... no output / string input...

//forloop... char1
//    för att köra 0->längd

//    string tempSum = char1 //2...

//    forloop char2... index char1+1
//        tempSum += char2 // 23...235...2352
//        if char != nummer (-1)
//            break;
//        else if
//            char1 == char2
//            result += tempsum int parse
//            print rad med färg från tecken på index char1 till char2 (for loops för enklare med index.)
//            Börja med att skriva ut hela rad och tempSum ... 

//            break

//cw Totalen är: xxxxxx


//char1 är aktuella värdet i ytterloopen
//char2 är aktuella värdet i innerloopen
