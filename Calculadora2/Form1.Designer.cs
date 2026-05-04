namespace Calculadora2;

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
        Register = new System.Windows.Forms.Button();
        numOneBox = new System.Windows.Forms.TextBox();
        numTwoBox = new System.Windows.Forms.TextBox();
        Sum = new System.Windows.Forms.Button();
        Subtrack = new System.Windows.Forms.Button();
        Multiply = new System.Windows.Forms.Button();
        Divide = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // Register
        // 
        Register.Location = new System.Drawing.Point(375, 64);
        Register.Name = "Register";
        Register.Size = new System.Drawing.Size(110, 31);
        Register.TabIndex = 0;
        Register.Text = "Register";
        Register.UseVisualStyleBackColor = true;
        Register.Click += Register_Click;
        // 
        // numOneBox
        // 
        numOneBox.Location = new System.Drawing.Point(112, 51);
        numOneBox.Name = "numOneBox";
        numOneBox.Size = new System.Drawing.Size(257, 27);
        numOneBox.TabIndex = 1;
        numOneBox.TextChanged += numOneBox_TextChanged;
        // 
        // numTwoBox
        // 
        numTwoBox.Location = new System.Drawing.Point(112, 84);
        numTwoBox.Name = "numTwoBox";
        numTwoBox.Size = new System.Drawing.Size(257, 27);
        numTwoBox.TabIndex = 2;
        numTwoBox.TextChanged += numTwoBox_TextChanged;
        // 
        // Sum
        // 
        Sum.Location = new System.Drawing.Point(76, 140);
        Sum.Name = "Sum";
        Sum.Size = new System.Drawing.Size(155, 112);
        Sum.TabIndex = 3;
        Sum.Text = "+";
        Sum.UseVisualStyleBackColor = true;
        Sum.Click += Sum_Click;
        // 
        // Subtrack
        // 
        Subtrack.Location = new System.Drawing.Point(261, 140);
        Subtrack.Name = "Subtrack";
        Subtrack.Size = new System.Drawing.Size(155, 112);
        Subtrack.TabIndex = 4;
        Subtrack.Text = "-";
        Subtrack.UseVisualStyleBackColor = true;
        Subtrack.Click += Subtrack_Click;
        // 
        // Multiply
        // 
        Multiply.Location = new System.Drawing.Point(76, 280);
        Multiply.Name = "Multiply";
        Multiply.Size = new System.Drawing.Size(155, 112);
        Multiply.TabIndex = 5;
        Multiply.Text = "x";
        Multiply.UseVisualStyleBackColor = true;
        Multiply.Click += Multiply_Click;
        // 
        // Divide
        // 
        Divide.Location = new System.Drawing.Point(261, 280);
        Divide.Name = "Divide";
        Divide.Size = new System.Drawing.Size(155, 112);
        Divide.TabIndex = 6;
        Divide.Text = "/";
        Divide.UseVisualStyleBackColor = true;
        Divide.Click += Divide_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(Divide);
        Controls.Add(Multiply);
        Controls.Add(Subtrack);
        Controls.Add(Sum);
        Controls.Add(numTwoBox);
        Controls.Add(numOneBox);
        Controls.Add(Register);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button Register;
    private System.Windows.Forms.TextBox numOneBox;
    private System.Windows.Forms.TextBox numTwoBox;
    private System.Windows.Forms.Button Sum;
    private System.Windows.Forms.Button Subtrack;
    private System.Windows.Forms.Button Multiply;
    private System.Windows.Forms.Button Divide;

    #endregion
}