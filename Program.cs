Console.WriteLine("Hallo, Rayen!");

Aufgabe7();
//Aufgabe7_V2();

static void Aufgabe7()
{
    decimal gesamtPreis = 0M;
    decimal zwischenPreis1 = 0M;
    decimal zwischenPreis2 = 0M;
    decimal zwischenPreis3 = 0M;
    decimal zwischenPreis4 = 0M;
    string ausgabe = "Unzulässige eingaben";

    Console.Write("Einzelpreis: ");

    string eingabe = Console.ReadLine();

    decimal einzelPreis = decimal.Parse(eingabe);

    int zaehler = 0;

    Console.Write("Anzahl: ");

    eingabe = Console.ReadLine();

    int anzahl = int.Parse(eingabe);

    if (anzahl < 1000)
    {
        if (anzahl < 100)
        {
            if (anzahl < 10)
            {
                gesamtPreis = (anzahl * einzelPreis);
                ausgabe = $"Gesamtpreis {gesamtPreis:n2}";
            }
            else
            {
                zwischenPreis1 = (9 * einzelPreis);
                int rest = anzahl - 9;
                zwischenPreis2 = (rest * einzelPreis * 0.9M);
                gesamtPreis = zwischenPreis1 + zwischenPreis2;
                ausgabe = $"Gesamtpreis {gesamtPreis:n2}";
            }
        }
        else
        {
            zwischenPreis1 = (9 * einzelPreis);
            zwischenPreis2 = (99 * einzelPreis * 0.9M);
            int rest = anzahl - 99 - 9;
            zwischenPreis3 = (rest * einzelPreis * 0.85M);
            gesamtPreis = zwischenPreis1 + zwischenPreis2 + zwischenPreis3;
            ausgabe = $"Gesamtpreis {gesamtPreis:n2}";
        }
    }
    else
    {
        zwischenPreis1 = (9 * einzelPreis);
        zwischenPreis2 = (99 * einzelPreis * 0.90M);
        zwischenPreis3 = (999 * einzelPreis * 0.85M);

        int rest = anzahl - (999 + 99 + 9);
        zwischenPreis4 = (rest * einzelPreis * 0.80M);
        gesamtPreis = zwischenPreis1 + zwischenPreis2 + zwischenPreis3 + zwischenPreis4;
        ausgabe = $"Gesamtpreis {gesamtPreis:n2}";
    }

    Console.WriteLine($"{ausgabe}");
}

//Diese Methode erfüllt nicht den Zweck der Aufgabe
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
        Console.Write("Der Gesamtpreis beträgt: " + GesamtPreisMitRabatt);
    }

    if (Anzahl >= 100 && Anzahl <= 999)
    {
        //Gesamtpreis berechnen
        Console.WriteLine("Sie erhalten ein Rabatt von 15%");

        GesamtPreis = EinzelPreis * Anzahl;

        decimal GesamtPreisMitRabatt = GesamtPreis - (GesamtPreis * 15 / 100);
        Console.Write("Der Gesamtpreis beträgt: " + GesamtPreisMitRabatt);
    }

    if (Anzahl > 1000)
    {
        //Gesamtpreis berechnen
        Console.WriteLine("Sie erhalten ein Rabatt von 20%");

        GesamtPreis = EinzelPreis * Anzahl;

        decimal GesamtPreisMitRabatt = GesamtPreis - (GesamtPreis * 20 / 100);
        Console.Write("Der Gesamtpreis beträgt: " + GesamtPreisMitRabatt);
    }
}