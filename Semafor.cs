Console.WriteLine("stojis u semaforu? (True/False)");
bool Jede = bool.Parse(Console.ReadLine());
Console.WriteLine("Jsi pod vlivem alkoholu? (True/False)");
bool drunk = bool.Parse(Console.ReadLine());

while (Jede)
{
    Console.WriteLine("jaka je barva semaforu: 1 - zelena, 2 - oranzova, 3 - cervena");
    int Barva = int.Parse(Console.ReadLine());
    if (drunk)
    {
        Console.WriteLine("Jsi pod vlivem alkoholu, prejel jsi 4 deti a 2 duchodce a umrel jsi v nemocnici na otravu alkoholem.");
        Jede = false;
    }
    else
    {
    switch (Barva)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Jdi");
            break;

        case 2:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Pockej");

            break;

        case 3:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Stuj");
            break;
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("stojis u semaforu? (True/False)");
    if (Console.ReadLine() == "False")
    {
        Jede = false;
        Console.WriteLine("obejmi strom <3");
    }


    }

}

    Console.ReadKey();
