namespace s30422_assignment3_calculator;

public class Calculator
{
    private double a;
    private double b;
    private string _operator;

    public Calculator(double a, double b, string @operator)
    {
        this.a = a;
        this.b = b;
        _operator = @operator.Trim();
    }

    public double Execute()
    {
        switch (_operator)
        {
            case "+":
            {
                return a + b;
            }
            case "-":
            {
                return a - b;
            }
            case "*":
            {
                return a * b;
            }
            case "/":
            {
                if (b == 0) 
                    throw new DivideByZeroException();
                
                return a / b;
            }
            default:
            {
                throw new ArgumentException($"Unknown operator \"{_operator}\"");
            }
        }
    }
}