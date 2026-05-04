namespace Calculadora;

public partial class Form1 : Form
{
    private Calculator calc = new Calculator();
    public Form1()
    {
        InitializeComponent();
    }
    

    private void Register1_Click(object sender, EventArgs e)
    {
        calc.SetNumOne(float.Parse(numOne.Text));
    }

    private void Register2_Click(object sender, EventArgs e)
    {
        calc.SetNumTwo(float.Parse(numTwo.Text));
    }

    private void Sum_Click(object sender, EventArgs e)
    {
        float resultado = calc.Sum();
        Resultado.Text = resultado.ToString();
    }

    private void Divide_Click(object sender, EventArgs e)
    {
        float resultado = calc.Divide();
        Resultado.Text = resultado.ToString();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        float resultado = calc.Subtract();
        Resultado.Text = resultado.ToString();
    }

    private void Multuiply_Click(object sender, EventArgs e)
    {
        float resultado = calc.Multiply();
        Resultado.Text = resultado.ToString();
    }

    private void numOne_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void numTwo_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void R_Click(object sender, EventArgs e)
    {
        
    }

    private void Resultado_Click(object sender, EventArgs e)
    {
        
    }
}