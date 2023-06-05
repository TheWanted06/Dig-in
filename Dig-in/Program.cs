Console.WriteLine("Hi there. Welcome to Dig-in");
Console.WriteLine("Type (W) to write a new recipe or [L] to list the current available recept" );

int num1;

Console.WriteLine("Please enter the number of ingredients");
num1 = Convert.ToInt32(Console.ReadLine());
string[,] ing = new string[num1, 2];
int[] ingNum = new int[num1];

Console.WriteLine("\n***************************\n");

string ingName;
int ingQuant;
string ingMeasurement;

for (int i = 0; i < num1; i++)
{
    Console.WriteLine("What is the name of the ingredient");
    ingName = Console.ReadLine();
    Console.WriteLine("Nice! At what quantity");
    ingQuant = Convert.ToInt32(Console.ReadLine().Trim());
    Console.WriteLine("What unit of measurement is that");
    ingMeasurement = Console.ReadLine(); ;

    ing[i, 0] = ingName;
    ingNum[i] = ingQuant;
    ing[i, 1] = ingMeasurement;
    Console.WriteLine("-----------");
}

Console.WriteLine("How many steps does this recipe require?");
int NumSteps = Convert.ToInt32(Console.ReadLine());
string[] steps = new string[NumSteps];
string thestep;

for (int i = 0; i < NumSteps; i++)
{
    Console.WriteLine($"Step {i + 1} \n\t");
    thestep = Console.ReadLine();
    steps[i] = thestep;

}

Display(1);
Console.WriteLine("Would you like the measurements to be sized up or size down?\n" +
    "Type [1] to size it to 1x of the original.\n" +
    "Type [2] to size it to 2x of the original\n" +
    "Type [3] to size it to 3x of the original or\n" +
    "Type [5] to size it to 0.5x of original\n");
string input = Console.ReadLine();

if (input == "2")
{
    Display(2);
}
if (input == "3")
{
    Display(3);
}
if (input == "5")
{
    Display(5);
}
if (input == "5")
{
    Display(5);
}


void Display(double n)
{
    Console.WriteLine("... \nGot it!\n\n");
    Console.WriteLine("********************************\n" +
                        "           INGREDIENTS          \n" +
                        "********************************");
    if (n != 1)
    {
        double[] ingQua = new double[num1];
        double current;
        double newIngQua;


        for (int i = 0; i < num1; i++)
        {
            current = Convert.ToDouble(ingNum[i]);
            if (n == 5)
            {
                newIngQua = current * 0.5;
            }
            else
            {
                newIngQua = current * n;
            }

            ingQua[i] = newIngQua;
            Console.WriteLine($"{ingQua[i]} { ing[i, 1]} of {ing[i, 0]}\n");
        }
    }
    else
    {
        for (int i = 0; i < num1; i++)
        {
            Console.WriteLine($"{ingNum[i]} { ing[i, 1]} of {ing[i, 0]}\n");
        }
    }

    for (int i = 0; i < steps.Length; i++)
    {
        Console.WriteLine($"        STEP{i}     \n" +
                            $"{steps[i]}");
    }

}
Console.ReadKey();


