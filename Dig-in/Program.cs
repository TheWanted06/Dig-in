using Dig_in;

Console.WriteLine("Hi there. Welcome to Dig-in");

Console.WriteLine("Type [W] to write a new recipe or [L] to list the current available recepts" );
string input1 = Console.ReadLine();

List<Recipe> recipes = new List<Recipe>();
while(input1 != null && input1 != "L")
{
    recipes.Add(AddRecipe());
    Console.WriteLine("Type [W] to write a new recipe or [L] to list the current available recepts");
    input1 = Console.ReadLine();
}
if(input1 == "L")
{
    NewDisplay(recipes);
}

void NewDisplay(List<Recipe> recipes)
{
    recipes.Sort();
    int num = recipes.Count;
    int i = 1;
    foreach (var recps in recipes)
    {
        Console.WriteLine($"{i} {recps.Name} ( {recps.TotalCalories} calories)");
        i++;

    }
    input1 = Console.ReadLine();
    while(input1!= null && Int32.TryParse(input1, out int t))
    {
        while(t >0 && t <= num)
        {
            showRecipe(recipes, t);
        }
    }

}

void showRecipe(List<Recipe> recipes, int t)
{

    throw new NotImplementedException();
}

Recipe AddRecipe()
{
    Recipe recipe = new Recipe();

    Console.WriteLine("Please enter the Name of Recipe");
    string name = Console.ReadLine();
    recipe.Name = name;

    Console.WriteLine("\nPlease enter the number of ingredients");
    string Ingrd = Console.ReadLine();
    int numIngrd = Convert.ToInt32(Ingrd);
    //recipe.ingediants.Capacity = numIngrd;
    for (int i = 0; i < numIngrd; i++)
    {
        recipe.ingediants.Add(AddIngredient());
    }


    Console.WriteLine("How many steps does this recipe require?");
    string steps = Console.ReadLine() ;
    int numSteps = Convert.ToInt32(steps); 
    recipe.steps.Capacity = numSteps;
    for (int j = 0; j < numSteps; j++)
    {
        Step step = AddSteps(j);
        recipe.steps.Add(step);
    }

    return recipe;

}


Ingredient AddIngredient()
{
    Ingredient ingredient = new Ingredient();

    Console.WriteLine("What is the name of the Ingredient?");
    string name = Console.ReadLine();
    ingredient.name = name;

    Console.WriteLine("What is the Unit of Measurement?");
    string uom= Console.ReadLine();
    ingredient.UOM = uom;

    Console.WriteLine("What is the quantity used");
    int Qnt = Convert.ToInt32(Console.ReadLine()); 
    ingredient.Quantity =  Qnt;

    Console.WriteLine("How many calories does it have?");
    int Cal = Convert.ToInt32(Console.ReadLine());
    ingredient.Quantity = Cal;

    Console.WriteLine("Which food group does it belong to? Type\n" +
        "1 for Strach\n" +
        "2 for Fruits\n" +
        "3 for Vegetables\n" +
        "4 for Grains\n" +
        "5 for Proteins\n" +
        "6 for Fats and Oils ");
    int foodtype = Convert.ToInt32(Console.ReadLine());
    switch(foodtype)
    {
        case 1:
            ingredient.Food_Group = Ingredient.FoodType.Starches; 
            break;
        case 2:
            ingredient.Food_Group = Ingredient.FoodType.Fruits;
            break;
        case 3:
            ingredient.Food_Group = Ingredient.FoodType.Vegetables;
            break;
        case 4:
            ingredient.Food_Group = Ingredient.FoodType.Grains;
            break;
        case 5:
            ingredient.Food_Group = Ingredient.FoodType.Protein;
            break;
        case 6:
            ingredient.Food_Group = Ingredient.FoodType.FatsAndOils;
            break;
    }

    return ingredient;
}

Step AddSteps(int j)
{
    Step step = new Step();
    
    step.step = j;
    Console.WriteLine("Step" + j);
    string thestep = Console.ReadLine();

    return step;
}


//int num1;

//Console.WriteLine("Please enter the number of ingredients");
//num1 = Convert.ToInt32(Console.ReadLine());
//string[,] ing = new string[num1, 2];
//int[] ingNum = new int[num1];

//Console.WriteLine("\n***************************\n");

//string ingName;
//int ingQuant;
//string ingMeasurement;

//for (int i = 0; i < num1; i++)
//{
//    Console.WriteLine("What is the name of the ingredient");
//    ingName = Console.ReadLine();
//    Console.WriteLine("Nice! At what quantity");
//    ingQuant = Convert.ToInt32(Console.ReadLine().Trim());
//    Console.WriteLine("What unit of measurement is that");
//    ingMeasurement = Console.ReadLine(); ;

//    ing[i, 0] = ingName;
//    ingNum[i] = ingQuant;
//    ing[i, 1] = ingMeasurement;
//    Console.WriteLine("-----------");
//}

//Console.WriteLine("How many steps does this recipe require?");
//int NumSteps = Convert.ToInt32(Console.ReadLine());
//string[] steps = new string[NumSteps];
//string thestep;

//for (int i = 0; i < NumSteps; i++)
//{
//    Console.WriteLine($"Step {i + 1} \n\t");
//    thestep = Console.ReadLine();
//    steps[i] = thestep;

//}

//Display(1);
//Console.WriteLine("Would you like the measurements to be sized up or size down?\n" +
//    "Type [1] to size it to 1x of the original.\n" +
//    "Type [2] to size it to 2x of the original\n" +
//    "Type [3] to size it to 3x of the original or\n" +
//    "Type [5] to size it to 0.5x of original\n");
//string input = Console.ReadLine();

//if (input == "2")
//{
//    Display(2);
//}
//if (input == "3")
//{
//    Display(3);
//}
//if (input == "5")
//{
//    Display(5);
//}
//if (input == "5")
//{
//    Display(5);
//}


//void Display(double n)
//{
//    Console.WriteLine("... \nGot it!\n\n");
//    Console.WriteLine("********************************\n" +
//                        "           INGREDIENTS          \n" +
//                        "********************************");
//    if (n != 1)
//    {
//        double[] ingQua = new double[num1];
//        double current;
//        double newIngQua;


//        for (int i = 0; i < num1; i++)
//        {
//            current = Convert.ToDouble(ingNum[i]);
//            if (n == 5)
//            {
//                newIngQua = current * 0.5;
//            }
//            else
//            {
//                newIngQua = current * n;
//            }

//            ingQua[i] = newIngQua;
//            Console.WriteLine($"{ingQua[i]} { ing[i, 1]} of {ing[i, 0]}\n");
//        }
//    }
//    else
//    {
//        for (int i = 0; i < num1; i++)
//        {
//            Console.WriteLine($"{ingNum[i]} { ing[i, 1]} of {ing[i, 0]}\n");
//        }
//    }

//    for (int i = 0; i < steps.Length; i++)
//    {
//        Console.WriteLine($"        STEP{i}     \n" +
//                            $"{steps[i]}");
//    }

//}
Console.ReadKey();


