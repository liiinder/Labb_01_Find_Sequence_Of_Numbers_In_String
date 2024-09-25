Console.Write("Skriv in en text: ");
string input = Console.ReadLine();
ulong sumOfAll = 0;
for (int i = 0; i < input.Length - 1; i++)
{
    int reminderStart = input[(i + 1)..].IndexOf(input[i]) + i + 2;
    if (reminderStart - i == 1 || !ulong.TryParse(input[i..reminderStart], out ulong currSum)) continue;
    sumOfAll += currSum;
    Console.Write("\n" + input[..i]);
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write(input[i..reminderStart]);
    Console.ResetColor();
    Console.Write(input[reminderStart..]);
}
Console.WriteLine($"\n\nTotal = {sumOfAll}");

/* 
    Steg för steg...

--- Loop --------------------------------------------------------------------------------------------------------------------

    En loop som går igenom alla tecken och för varje tecken så vill vi leta efter ett matchande tecken
    
    Exempel:
    --------
    string input = "29535123p48723487597645723645";
    Om i = 2 så returnerar input[(i + 1)..] substrängen 35123p48723487597645723645

    Sedan kollar vi om det finns en matchande siffra i denna substräng med
    indexOf(5) -> vilket kommer returnera 1 ( 3[5]123p48723487597645723645 )
    Om det inte finns en träff returneras -1

    Vi är ute efter indexet i orginal strängen på tecknet efter matchningen
        29535[1]23p48723487597645723645 -> index = 5

    Då första tecknet i substrängen har index (i + 1) i orginalsträngen
    så behöver vi lägga till (i + 1) till vårat svar för att få indexet på matchningen i orginalsträngen
    MEN eftersom vi vill ha tecknet efter lägger vi på (i + 2).

--- IF-sats -----------------------------------------------------------------------------------------------------------------

    Kollar efter 2 saker:
    ---------------------
    1. (reminderStart - i == 1) -> längden på den matchande substrängen, är den 1 betyder det att vi inte hittat någon matchning
    2. TryParse kommer kolla om strängen går att parsa till en long och returnera true/false och spara i variabeln "currSum",
       går det inte parsa så returneras true (då vi använder ! före och vänder på svaret).
    
    Om något av dessa är sant så går vi vidare i loopen med ( continue; )

--- Utskrift ----------------------------------------------------------------------------------------------------------------

    input[..i]               - Substring från start till tecknet innan i (sista är exkluderande)
        29

    input[i..reminderStart]  - Substring från i till tecknet innan reminderStart
        535

    input[reminderStart..]   - Substring från reminderStart till slutet av strängen.
        123p48723487597645723645

*/