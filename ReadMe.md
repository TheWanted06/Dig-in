# Dig-in
This console application allows the user to enter the details of a single recipe and display the full recipe, including the ingredients and steps, in a neat format. The user can also scale the recipe by a factor of 0.5, 2 or 3, reset the quantities to the original values, or clear all the data to enter a new recipe. The software does not persist user data between runs and stores data only in memory while running.
Requirements

    Microsoft Visual Studio
    .NET Framework

How to Run

    Open the solution file (.sln) in Visual Studio.
    Build the solution to compile the code.
    Run the application by pressing F5 or by clicking the "Start" button in the toolbar.

How to Use

    When the application starts, the user will be prompted to enter the details of the recipe.
    Enter the number of ingredients and steps in the recipe.
    For each ingredient, enter the name, quantity, and unit of measurement.
    For each step, enter a description of what the user should do.
    Once all the details have been entered, the software will display the full recipe in a neat format.
    To scale the recipe, enter a scaling factor of 0.5, 2, or 3 when prompted.
    To reset the quantities to the original values, enter "reset" when prompted.
    To clear all the data and enter a new recipe, enter "clear" when prompted.

Code Structure

The code is written in C# and organized into classes and methods to manage recipe details and user input. The main program is located in the "Program.cs" file, and the recipe class is defined in the "Recipe.cs" file.
Contributing

Contributions to this project are welcome. To contribute, fork the repository and create a new branch for your changes. When you're ready to submit your changes, create a pull request with a description of the changes you made.
License

This project is licensed under the MIT License. See the LICENSE file for more information.
