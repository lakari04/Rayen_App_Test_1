// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Aufgabe7();

static void Aufgabe7()

{

    Console.Write("Einzelpreis: ");

    string eingabe = Console.ReadLine();

    decimal cost = decimal.Parse(eingabe);

 

    Console.Write("Anzahl: ");

    eingabe = Console.ReadLine();

    int count = int.Parse(eingabe);

       

    decimal gespreis;

    decimal zwischenp = 0M;

    decimal zwischenp1 = 0M;

    decimal zwischenp2 = 0M;

    decimal zwischenp3 = 0M;

    string ausgabe;

    int count1 ;

    int count2;

    int count3;




    if(count<=9)

    {

        gespreis = (count * cost);

        gespreis = zwischenp;

        ausgabe = $"Stückzahl {gespreis:n2}";

    }

    if (count>=10 && count<=99)

    {

        count1 = count - 9;

        zwischenp1 = ( count1 * cost) * 0.9M + (9 * cost);

        gespreis = zwischenp + zwischenp1;

        ausgabe = $"Stückzahl {gespreis:n2}";

    }

    if (count>=100 && count<=999)

    {

        count2 = count - 99;

        zwischenp2 = (count2 * cost) * 0.85M ;

        gespreis = zwischenp + zwischenp1 + zwischenp2;

        ausgabe = $"Stückzahl {gespreis:n2}";

    }

    if (count >= 1000)

    {

        count3 = count - 999;

        zwischenp3 = (count3 * cost) * 0.8M;

        gespreis = zwischenp + zwischenp1 + zwischenp2 + zwischenp3;

        ausgabe = $"Stückzahl {gespreis:n2}";

    }

    else

    {

        ausgabe = "Unzulässige eingaben";

    }

 

    Console.WriteLine($"{ausgabe}");

 

}