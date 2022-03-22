Random random = new Random();
int rndnr = random.Next(1, 11);

Console.WriteLine("Gæt et nummer imellem 1-10");
int guess = int.Parse(Console.ReadLine());

int i = 0;


while (true)
{
    Console.Clear();

    if (rndnr < guess)
    {
        Console.WriteLine("Tallet er for højt");
        i++;
    }
    else if (rndnr > guess)
    {
        Console.WriteLine("Tallet er for lavt");
        i++;
    }
    else if (rndnr == guess)
    {
        i++;
        if (i <= 5)
        {
            Console.WriteLine("Du har brugt {0} forsøg, godt klaret!", i);
        }
        else Console.WriteLine("Du har brugt {0} forsøg, det er ret dårligt", i);
        break;


    }
    
    Console.WriteLine("Guess a number between 1-10");
    guess = int.Parse(Console.ReadLine());
}


Console.ReadKey();

