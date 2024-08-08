using calculator.Models;

Calculator operation = new Calculator();

Console.WriteLine($"Choose a mathematical operation: \n" + 
                   " 1 - SUM \n" +
                   " 2 - SUBTRACTION \n" +
                   " 3 - MULTIPLICATION \n" +
                   " 4 - DIVISION \n" +
                   " 5 - POWER \n" +
                   " 6 - SINE \n" +
                   " 7 - COSINE \n" +
                   " 8 - TANGENT \n" +
                   " 9 - SQUARE ROOT");

string chosenOperation = Console.ReadLine();

switch (chosenOperation){
    case "1":
        Console.WriteLine("Enter the first number:");
        int sumXValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int sumYValue = int.Parse(Console.ReadLine());
        operation.Sum(sumXValue, sumYValue);
        break;
    case "2":
        Console.WriteLine("Enter the first number:");
        int subtractionXValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int subtractionYValue = int.Parse(Console.ReadLine());
        operation.Subtract(subtractionXValue, subtractionYValue);    
        break;
    case "3":
        Console.WriteLine("Enter the first number:");
        int multiplicationXValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int multiplicationYValue = int.Parse(Console.ReadLine());
        operation.Multiply(multiplicationXValue, multiplicationYValue);
        break;
    case "4":
        Console.WriteLine("Enter the first number:");
        int divisionXValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int divisionYValue = int.Parse(Console.ReadLine());
        operation.Divide(divisionXValue, divisionYValue);
        break;
    case "5":
        Console.WriteLine("Enter the first number:");
        int powerXValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int powerYValue = int.Parse(Console.ReadLine());
        operation.Power(powerXValue, powerYValue);
        break;
    case "6":
        Console.WriteLine("Enter a number:");
        int sineValue = int.Parse(Console.ReadLine());
        operation.Sine(sineValue);
        break;
    case "7":
        Console.WriteLine("Enter a number:");
        int cosineValue = int.Parse(Console.ReadLine());
        operation.Cosine(cosineValue);
        break;
    case "8":
        Console.WriteLine("Enter a number:");
        int tangentValue = int.Parse(Console.ReadLine());
        operation.Tangent(tangentValue);
        break;
    case "9":
        Console.WriteLine("Enter a number:");
        int squareRootValue = int.Parse(Console.ReadLine());
        operation.SquareRoot(squareRootValue);
        break;
    default:
        Console.WriteLine("Invalid operation chosen");
        break;
}