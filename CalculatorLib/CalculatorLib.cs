
namespace CalculatorLib;
public class Calculator
{
    // Good Practice : Name correctly the FUCKING MEthods
    public static double Add (double Num1, double Num2)
    {
        return Num1 + Num2;
    }

    public static double Subtract (double Num1, double Num2)
    {
        return Num1 - Num2;
    }

    public static double Multiply (double Num1, double Num2)
    {
        return Num1 * Num2;
    }

    public static double Divide (double Num1, double Num2)
    {
        if (Num2 == 0)
        {
            throw new DivideByZeroException("If you know what happens, why do you try it?");
        }
        return Num1 / Num2;
    }

}

