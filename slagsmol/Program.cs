
Console.WriteLine("Vad heter fighter A?");
string a = Console.ReadLine();
int hpa = 100;

Console.WriteLine("Vad heter fighter B?");
string b = Console.ReadLine();
int hpb = 100;
Console.ReadLine();
Console.Clear();
Random generator = new Random();
int dmg = generator.Next(3, 17);

while (hpa > 0 && hpb > 0){
    Console.WriteLine("NY RUNDA!");
    Console.ReadLine();
    

    dmg = generator.Next(3, 17);
    hpb = hpb - dmg;
    Console.WriteLine($"{a} slog {b} och gjorde {dmg} skada, {b} har {hpb} HP!");

    
    dmg = generator.Next(3, 17);
    hpa = hpa - dmg;
    Console.WriteLine($"{b} slog {a} och gjorde {dmg} skada, {a} har {hpa} HP!");

    Console.WriteLine("Tryck på enter för att gå vidare");
    Console.ReadLine();
    Console.Clear();
}

if (hpa <= 0){
    Console.WriteLine($"{b} Vann!");
}
else if (hpa <= 0 && hpb <= 0){
    Console.WriteLine("Oavgort!");
}
else
{
    Console.WriteLine($"{a} Vann!");    
}


Console.ReadLine();