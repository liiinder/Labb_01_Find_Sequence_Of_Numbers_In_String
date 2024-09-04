# Första labben i kursen "Programmering med C#"

Skapa en konsollapplikation som ber användaren mata in en text (string) i konsollen.
Den inmatade strängen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
siffror förekommer där emellan.


ex. 3463 är ett korrekt sådant tal, men 34363 är det inte eftersom det finns
ytterligare en 3:a i talet, förutom start och slutsiffran. Strängar med bokstäver i
t.ex 95a9 är inte heller ett korrekt tal.

## Tankebana för att få fram en algoritm skriven i keep.google.com på tåget hem från skolan.

input -> 2352

```
metod... no output / string input...

forloop... char1 loopa igenom hela strängen en i taget.

    string tempSum = char1 //2...

    forloop char2... index char1+1 / 
char2 börjar alltid på nästa char sen går den tills den antingen hittar en bokstav eller en likadan siffra

        tempSum += char2 // 23...235...2352

        if char != nummer (-1)
            break;

        else if char1 == char2
            result += tempsum int parse

            print rad med färg från tecken på index char1 till char2

            Börja med att skriva ut hela rad och tempSum ... 

            break

Tar loopen slut och den inte hittar samma tecken så spelar det ingen roll, detta då det bara är när det blir träff som print anropet och summan sparas till resultat variabeln

cw Totalen är: xxxxxx
```

char1 är aktuella värdet i ytterloopen  
char2 är aktuella värdet i innerloopen

Använda for-loopar istället för foreach pga enklare indexhantering