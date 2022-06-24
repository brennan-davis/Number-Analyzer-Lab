string name = string.Empty;
while (String.IsNullOrEmpty(name))
{
    Console.WriteLine("What is your name?");
    name = Console.ReadLine();
}

bool runProgramLoop = true;
while (runProgramLoop)
{
    bool isIntAndInRange = false;
    int number;

    Console.WriteLine($"\n{name}, please enter a whole number between 1 and 100:");
    do
    {
        bool isInt = int.TryParse(Console.ReadLine(), out number);

        while (!isInt)
        {
            isInt = int.TryParse(Console.ReadLine(), out number);
        }

        if (number >= 1 && number <= 100)
        {
            isIntAndInRange = true;
        }
        else
        {
            Console.WriteLine($"\nSorry, {number} is not between 1-100. Please try again:");
        }
    } while (!isIntAndInRange);

    Console.Write($"\nGreat number, {name}! The number {number} is ");
    if (number % 2 != 0 && number < 60)
    {
        Console.Write("odd and less than 60.\n");
    }
    else if (number % 2 == 0 && number >= 2 && number <= 24)
    {
        Console.Write("even and less than 25.\n");
    }
    else if (number % 2 == 0 && number >= 26 && number <= 60)
    {
        Console.Write("even and between 26 and 60 inclusive.\n");
    }
    else if (number % 2 == 0 && number > 60)
    {
        Console.Write("even and greater than 60.\n");
    }
    else if (number % 2 != 0 && number > 60)
    {
        Console.Write("edd and greater than 60.\n");
    }


    Console.WriteLine($"\nPress ENTER to run the program again. Press any other key to exit the program...");
    ConsoleKeyInfo key = Console.ReadKey();
    if(key.KeyChar != 13) runProgramLoop = false;
}
Console.WriteLine($"Thank you for using my program, {name}!");
