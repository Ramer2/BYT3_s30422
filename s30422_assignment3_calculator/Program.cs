using s30422_assignment3_calculator;

// addiing two numbers
var adder = new Calculator(4, 5, "+");
Console.WriteLine(adder.Execute());

// subtracting two numbers
var subtractor = new Calculator(6, 9, "-");
Console.WriteLine(subtractor.Execute());

// multiplying two numbers
var multiplier = new Calculator(1, 2, "*");
Console.WriteLine(multiplier.Execute());

// dividing two numbers
var divider = new Calculator(3, 6, "/");
Console.WriteLine(divider.Execute());

// didivng by zero
var dividerByZero = new Calculator(1, 0, "/");
try
{
    dividerByZero.Execute();
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Caught division by zero exception: {ex.Message}");
}

// unknown opperation
var unknownOperatoion = new Calculator(10, 10, "whatever");
try
{
    unknownOperatoion.Execute();
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Caught argument exception: {ex.Message}");
}