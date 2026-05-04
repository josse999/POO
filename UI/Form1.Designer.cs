namespace UI;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Button myFirstButton;

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
        myFirstButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // myFirstButton
        // 
        myFirstButton.Location = new System.Drawing.Point(50, 50);
        myFirstButton.Name = "myFirstButton";
        myFirstButton.Size = new System.Drawing.Size(120, 40);
        myFirstButton.TabIndex = 0;
        myFirstButton.Text = "Click me!";
        myFirstButton.Click += myFirstButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(myFirstButton);
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion
}