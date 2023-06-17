# Mad Scientist

This project is a simulation of a mad scientist's experiment. The code is written in C# and consists of a class that calculates the molar mass of a chemical formula.

The `Program` class contains the `Main` method, which is the entry point of the program. It prompts the user to enter a chemical formula, then calls the `MadChemist` method to calculate the molar mass of the formula. The molar mass is then printed to the console.

The `MadChemist` method takes a chemical formula and an optional name for the formula. It initializes several variables to keep track of the elements in the formula, the number of each element, and the total molar mass. It then loops through each character in the formula, extracting the element names and the number of atoms of each element. It reads the molar masses of the elements from a file called 'periodic table.txt', and adds the molar mass of each element to the total molar mass. The total molar mass is then returned.

The code demonstrates the use of classes, methods, loops, arrays, string manipulation, file I/O, and console I/O in C#.
