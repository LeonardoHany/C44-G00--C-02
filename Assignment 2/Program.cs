using System;

class Program
{
    static void Main()
    {
        #region 1. Write a program that allows the user to enter a number then print it.
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        Console.WriteLine($"You entered: {input}");
        #endregion
        
        #region 2. Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
        string nonNumericString = "123abc";
        Console.WriteLine($"Trying to convert '{nonNumericString}' to integer...");

        try
        {
            int result = int.Parse(nonNumericString);
            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        // What happens: int.Parse() throws FormatException with non-numeric characters.
        #endregion
        
        #region 3. Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
        double num1 = 10.5;
        double num2 = 3.2;

        double addition = num1 + num2;
        double subtraction = num1 - num2;
        double multiplication = num1 * num2;
        double division = num1 / num2;

        Console.WriteLine($"Addition: {num1} + {num2} = {addition}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {subtraction}");
        Console.WriteLine($"Multiplication: {num1} * {num2} = {multiplication}");
        Console.WriteLine($"Division: {num1} / {num2} = {division}");

        // Precision example
        double precisionTest = 0.1 + 0.2;
        Console.WriteLine($"Precision example: 0.1 + 0.2 = {precisionTest}");
        // What happens: Floating-point numbers may have precision issues due to binary representation.
        #endregion
        
        #region 4. Write C# program that Extract a substring from a given string.
        string originalString = "Hello, World! Welcome to C# programming.";
        Console.WriteLine($"Original string: {originalString}");

        string substring1 = originalString.Substring(7, 5); // Starting at index 7, length 5
        Console.WriteLine($"Substring (index 7, length 5): '{substring1}'");

        string substring2 = originalString.Substring(15); // From index 15 to end
        Console.WriteLine($"Substring (from index 15 to end): '{substring2}'");

        string word = originalString.Split(' ')[0]; // First word
        Console.WriteLine($"First word: '{word}'");
        #endregion
        
        #region 5. Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
        int originalValue = 10;
        int copyValue = originalValue;

        Console.WriteLine($"Original value: {originalValue}");
        Console.WriteLine($"Copy value: {copyValue}");

        copyValue = 20;

        Console.WriteLine($"After modification - Original: {originalValue}, Copy: {copyValue}");
        // What happens: Value types store actual data. When assigned, a copy is made. Modifying one doesn't affect the other.
        #endregion
        
        #region 6. Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
        int[] array1 = { 1, 2, 3 };
        int[] array2 = array1;

        Console.WriteLine($"Array1: [{string.Join(", ", array1)}]");
        Console.WriteLine($"Array2: [{string.Join(", ", array2)}]");

        array2[0] = 10;

        Console.WriteLine($"After modification - Array1: [{string.Join(", ", array1)}]");
        Console.WriteLine($"After modification - Array2: [{string.Join(", ", array2)}]");
        // What happens: Reference types store memory addresses. Both variables point to the same object. Modifying through either affects both.
        #endregion
        
        #region 7. Write C# program that take two string variables and print them as one variable
        string string1 = "Hello";
        string string2 = "World";

        string combinedString = string1 + " " + string2;
        Console.WriteLine($"Combined string: {combinedString}");
        #endregion
    }
}

/*
8. Which of the following statements is correct about the C#.NET code snippet given below?
Answer: 2. A value 1 will be assigned to d.
Reason: (30 < 20) is false, !(false) is true, Convert.ToInt32(true) is 1
*/
/*
9. Which of the following is the correct output for the C# code given below?
Answer: 4. 6 1
Reason: 13/2 = 6 (integer division), 13%2 = 1 (remainder)
*/
/*
10. What will be the output of the C# code given below?
Answer: 4. 7 7
Reason: !(1 <= 0) is true, so first branch executes
++num makes num=2, z++ uses z=5 then increments to 6
2+5=7, then ++z makes z=7
*/