namespace Calculadora;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Sum = new System.Windows.Forms.Button();
        Divide = new System.Windows.Forms.Button();
        Subtract = new System.Windows.Forms.Button();
        Multuiply = new System.Windows.Forms.Button();
        Register1 = new System.Windows.Forms.Button();
        Register2 = new System.Windows.Forms.Button();
        numOne = new System.Windows.Forms.TextBox();
        numTwo = new System.Windows.Forms.TextBox();
        Resultado = new System.Windows.Forms.Label();
        R = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // Sum
        // 
        Sum.Location = new System.Drawing.Point(159, 123);
        Sum.Name = "Sum";
        Sum.Size = new System.Drawing.Size(119, 111);
        Sum.TabIndex = 5;
        Sum.Text = "+";
        Sum.UseVisualStyleBackColor = true;
        Sum.Click += Sum_Click;
        // 
        // Divide
        // 
        Divide.Location = new System.Drawing.Point(326, 123);
        Divide.Name = "Divide";
        Divide.Size = new System.Drawing.Size(119, 111);
        Divide.TabIndex = 6;
        Divide.Text = "/";
        Divide.UseVisualStyleBackColor = true;
        Divide.Click += Divide_Click;
        // 
        // Subtract
        // 
        Subtract.Location = new System.Drawing.Point(159, 260);
        Subtract.Name = "Subtract";
        Subtract.Size = new System.Drawing.Size(119, 111);
        Subtract.TabIndex = 7;
        Subtract.Text = "-";
        Subtract.UseVisualStyleBackColor = true;
        Subtract.Click += button4_Click;
        // 
        // Multuiply
        // 
        Multuiply.Location = new System.Drawing.Point(326, 260);
        Multuiply.Name = "Multuiply";
        Multuiply.Size = new System.Drawing.Size(119, 111);
        Multuiply.TabIndex = 8;
        Multuiply.Text = "x";
        Multuiply.UseVisualStyleBackColor = true;
        Multuiply.Click += Multuiply_Click;
        // 
        // Register1
        // 
        Register1.Location = new System.Drawing.Point(451, 39);
        Register1.Name = "Register1";
        Register1.Size = new System.Drawing.Size(116, 27);
        Register1.TabIndex = 11;
        Register1.Text = "Register";
        Register1.UseVisualStyleBackColor = true;
        Register1.Click += Register1_Click;
        // 
        // Register2
        // 
        Register2.Location = new System.Drawing.Point(451, 77);
        Register2.Name = "Register2";
        Register2.Size = new System.Drawing.Size(116, 27);
        Register2.TabIndex = 12;
        Register2.Text = "Register";
        Register2.UseVisualStyleBackColor = true;
        Register2.Click += Register2_Click;
        // 
        // numOne
        // 
        numOne.Location = new System.Drawing.Point(183, 39);
        numOne.Name = "numOne";
        numOne.Size = new System.Drawing.Size(239, 27);
        numOne.TabIndex = 13;
        numOne.TextChanged += numOne_TextChanged;
        // 
        // numTwo
        // 
        numTwo.Location = new System.Drawing.Point(183, 77);
        numTwo.Name = "numTwo";
        numTwo.Size = new System.Drawing.Size(239, 27);
        numTwo.TabIndex = 14;
        numTwo.TextChanged += numTwo_TextChanged;
        // 
        // Resultado
        // 
        Resultado.Location = new System.Drawing.Point(159, 410);
        Resultado.Name = "Resultado";
        Resultado.Size = new System.Drawing.Size(100, 23);
        Resultado.TabIndex = 16;
        Resultado.Click += Resultado_Click;
        // 
        // R
        // 
        R.Location = new System.Drawing.Point(53, 410);
        R.Name = "R";
        R.Size = new System.Drawing.Size(100, 23);
        R.TabIndex = 17;
        R.Text = "Resultado";
        R.Click += R_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(R);
        Controls.Add(Resultado);
        Controls.Add(numTwo);
        Controls.Add(numOne);
        Controls.Add(Register2);
        Controls.Add(Register1);
        Controls.Add(Multuiply);
        Controls.Add(Subtract);
        Controls.Add(Divide);
        Controls.Add(Sum);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label R;
    private System.Windows.Forms.Label Resultado;

    private System.Windows.Forms.TextBox numOne;
    private System.Windows.Forms.TextBox numTwo;

    private System.Windows.Forms.Button Register1;
    private System.Windows.Forms.Button Register2;

    private System.Windows.Forms.Button Sum;
    private System.Windows.Forms.Button Divide;
    private System.Windows.Forms.Button Subtract;
    private System.Windows.Forms.Button Multuiply;

    #endregion
}