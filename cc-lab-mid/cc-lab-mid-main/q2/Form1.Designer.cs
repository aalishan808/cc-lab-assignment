namespace q2;

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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";

        // Create and configure Output TextBox
        this.Output = new System.Windows.Forms.TextBox();
        this.Output.Location = new System.Drawing.Point(20, 20);
        this.Output.Size = new System.Drawing.Size(760, 30);
        this.Output.ReadOnly = true; // Make it read-only for output
        this.Controls.Add(this.Output);

        // Create and configure Compile Button
        this.Compile = new System.Windows.Forms.Button();
        this.Compile.Location = new System.Drawing.Point(20, 70);
        this.Compile.Size = new System.Drawing.Size(100, 30);
        this.Compile.Text = "Generate Password";
        this.Compile.Click += new System.EventHandler(this.Compile_Click);
        this.Controls.Add(this.Compile);
    }

    // Declare Output and Generate controls
    private System.Windows.Forms.TextBox Output;
    private System.Windows.Forms.Button Compile;

    #endregion
}
