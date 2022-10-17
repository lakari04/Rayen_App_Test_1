Console.WriteLine("Hallo, Rayen!");

//Aufgabe7();
Aufgabe7_V2();

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

    int count1;

    int count2;

    int count3;


    if (count <= 9)

    {
        gespreis = (count * cost);

        gespreis = zwischenp;

        // Du sollst den Gesamtpreis ausgeben nicht die Stückzahl, der Wert ist richtig, das label davor aber nicht
        ausgabe = $"Stückzahl {gespreis:n2}";
    }

    if (count >= 10 && count <= 99)

    {
        count1 = count - 9;

        zwischenp1 = (count1 * cost) * 0.9M + (9 * cost);

        gespreis = zwischenp + zwischenp1;

        // Du sollst den Gesamtpreis ausgeben nicht die Stückzahl, der Wert ist richtig, das label davor aber nicht
        ausgabe = $"Stückzahl {gespreis:n2}";
    }

    if (count >= 100 && count <= 999)

    {
        count2 = count - 99;

        zwischenp2 = (count2 * cost) * 0.85M;

        gespreis = zwischenp + zwischenp1 + zwischenp2;

        // Du sollst den Gesamtpreis ausgeben nicht die Stückzahl, der Wert ist richtig, das label davor aber nicht
        ausgabe = $"Stückzahl {gespreis:n2}";
    }

    if (count >= 1000)

    {
        // Ab einer Eingabe 1001 ist nicht mehr unzulässig
        count3 = count - 999;

        zwischenp3 = (count3 * cost) * 0.8M;

        gespreis = zwischenp + zwischenp1 + zwischenp2 + zwischenp3;

        // Du sollst den Gesamtpreis ausgeben nicht die Stückzahl, der Wert ist richtig, das label davor aber nicht
        ausgabe = $"Stückzahl {gespreis:n2}";
    }

    else

    {
        //Bitte mit early return arbeiten
        //D.h. dein programm muss nicht komplett bis nach unten laufen, obwohl du ganz oben schon weisst dass die eingabe unzulässig ist :) Lies dir den link kurz durch
        //https://betterprogramming.pub/are-early-returns-any-good-eed4b4d03866

        ausgabe = "Unzulässige eingaben";
    }


    Console.WriteLine($"{ausgabe}");
}

void Aufgabe7_V2()
{
    // Ganz oben deklarieren wir IMMER die Variablen die wir benötigen
    decimal EinzelPreis = 0;
    int Anzahl = 0;
    decimal GesamtPreis = 0;

    bool EinzelPreisIsNotOk = true;
    bool AnzahlIsNotOk = true;

    //Jetzt fordern wir von Benutzer die Informationen die wir für unsere Berechnung benötigen
    
    //Jetzt halten wir den Benutzer solange in dieser WHILE Schleife fest, bis er ein Zahl eingibt
    //aus der While schleifen kommt man nur raus wenn der Boolean "EinzelPreisIsNotOk" false ist, deshalb haben wir den beim deklarieren gleich auf True gesetzt
    Console.Write("Bitte geben Sie den Einzelpreis ein: ");
    while (EinzelPreisIsNotOk)
    {
        decimal.TryParse(Console.ReadLine(), out EinzelPreis);
        if (EinzelPreis > 0)
            EinzelPreisIsNotOk = false;
        else
            Console.Write("Bitte geben Sie einen gültigen Einzelpreis ein ");
    }
    
    //hier nochmal, wir halten den Benutzer solange in dieser WHILE Schleife fest, bis er ein Zahl eingibt
    Console.Write("Bitte geben Sie die Anzahl ein: ");
    while (AnzahlIsNotOk)
    {
        int.TryParse(Console.ReadLine(), out Anzahl);
        if (Anzahl > 0)
            AnzahlIsNotOk = false;
        else
            Console.Write("Bitte geben Sie eine gültige Anzahl ein ");
    }
    

    // So ab hier haben wir gültige Eingaben und können den Gesamtpreis berechnen, aber zuerst schauen wir uns die Bedigungen an

    //Wir haben 4 unterschiedliche Bedingungen
    //Wenn die Anzahl zwischen 1 und 9 ist, dann 0% Rabatt
    //Wenn die Anzahl zwischen 10 und 99 ist, dann 10% Rabatt
    //Wenn die Anzahl zwischen 100 und 999 ist, dann 15% Rabatt
    //Wenn die Anzahl größer ist als 1000, dann 20% Rabatt
    
    
    // Anzahl > 1 überprüfe ich hier nicht mehr weil an dieser Stelle des programms ist
    // die Variable "Anzahl" immer größe ist als 0, dafür haben wir oben gesorgt mit der While schleife
    if (Anzahl <= 9)
    {
        //Gesamtpreis berechnen
        Console.WriteLine("Sie erhalten leider kein Rabatt");
        Console.Write("Der Gesamtpreis beträgt: " + EinzelPreis * Anzahl);
    }
    
    if (Anzahl >= 10 && Anzahl <= 99)
    {
        //Gesamtpreis berechnen
        Console.WriteLine("Sie erhalten ein Rabatt von 10%");

        GesamtPreis = EinzelPreis * Anzahl;

        decimal GesamtPreisMitRabatt = GesamtPreis - (GesamtPreis * 10 / 100);
        Console.Write("Der Gesamtpreis beträgt: " +  GesamtPreisMitRabatt );
    }
    
    if (Anzahl >= 100 && Anzahl <= 999)
    {
        //Gesamtpreis berechnen
        Console.WriteLine("Sie erhalten ein Rabatt von 15%");

        GesamtPreis = EinzelPreis * Anzahl;

        decimal GesamtPreisMitRabatt = GesamtPreis - (GesamtPreis * 15 / 100);
        Console.Write("Der Gesamtpreis beträgt: " +  GesamtPreisMitRabatt );
    }
    
    if (Anzahl > 1000)
    {
        //Gesamtpreis berechnen
        Console.WriteLine("Sie erhalten ein Rabatt von 20%");

        GesamtPreis = EinzelPreis * Anzahl;

        decimal GesamtPreisMitRabatt = GesamtPreis - (GesamtPreis * 20 / 100);
        Console.Write("Der Gesamtpreis beträgt: " +  GesamtPreisMitRabatt );
    }
    
}