namespace Calculadora2;

public class Calculator
{
    private float numOne;
    private float numTwo;

    public Calculator()
    {

    }

    public float Sum()
    {
        return numOne + numTwo;
    }

    public float Subtract()
    {
        return numOne - numTwo;
    }

    public float Multiply()
    {
        return numOne * numTwo;
    }

    public float Divide()
    {
        return numOne / numTwo;
    }

    public void SetNumOne(float x)
    {
        numOne = x;
    }

    public void SetNumTwo(float x)
    {
        numTwo = x;
    }
}