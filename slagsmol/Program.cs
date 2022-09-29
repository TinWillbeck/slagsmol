Random generator = new Random();
string restart = ("ja");
Console.WriteLine("Vad heter din fighter?");
string a = Console.ReadLine();
int hpA = 100;
string b = ("");
string villain1 = ("Lars the Great");
string villain2 = ("Rudolph the Ugly");
string villain3 = ("Joseph the Tyrant");
int opponentselect = generator.Next(4);
if (opponentselect == 1)
{
    b = villain1;
}
else if (opponentselect == 2)
{
    b = villain2;
}
else
{
    b = villain3;
}
int hpB = 100;
Console.Clear();
int dmg = generator.Next(3, 17);
Console.WriteLine($"Du kommer att möta {b}!");
Console.ReadLine();
while (restart == "ja")
{
    while (hpA > 0 && hpB > 0)
    {
        Console.WriteLine("NY RUNDA!");

        dmg = generator.Next(3, 17);
        hpB = hpB - dmg;
        Console.WriteLine($"{a} slog {b} och gjorde {dmg} skada, {b} har {hpB} HP!");
        Console.WriteLine("");

        dmg = generator.Next(3, 17);
        hpA = hpA - dmg;
        Console.WriteLine($"{b} slog {a} och gjorde {dmg} skada, {a} har {hpA} HP!");
        Console.WriteLine("");

        Console.WriteLine("Tryck på enter för att gå vidare");
        Console.ReadLine();
        Console.Clear();
    }
    

    if (hpA <= 0)
    {
        Console.WriteLine($"{b} Vann!");
        Console.ReadLine();
        Console.Clear();

    }
    else if (hpA <= 0 && hpB <= 0)
    {
        Console.WriteLine("Oavgort!");
        Console.ReadLine();
        Console.Clear();

    }
    else
    {
        Console.WriteLine($"{a} Vann!");
        Console.ReadLine();
        Console.Clear();

    }
    while (restart == "ja")
    {
    Console.WriteLine("Vill du spela igen?");
    restart = Console.ReadLine().ToLower();
        if (restart == "ja")
        {
            Console.WriteLine("Okej, lycka till!");
            hpA = 100;
            hpB = 100;

        }
        else if (restart == "nej")
        {
            Console.WriteLine("Okej, hejdå!");
        }
        else
        {
            Console.WriteLine("Felaktig input!");
        }
    }
}
Console.ReadLine();