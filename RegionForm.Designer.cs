using System.Drawing;
using System.Windows.Forms;

partial class RegionForm
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
    {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    resultTextBox = new TextBox();
    inputLabel = new Label();
    codeTextBox = new TextBox();
    menuStrip = new MenuStrip();
    helpButton = new ToolStripMenuItem();
    menuStrip.SuspendLayout();
    SuspendLayout();
    
    resultTextBox.BackColor = Color.White;
    resultTextBox.Font = new Font("Segoe UI", 11F);
    resultTextBox.Location = new Point(15, 30);
    resultTextBox.Multiline = true;
    resultTextBox.Name = "resultTextBox";
    resultTextBox.ReadOnly = true;
    resultTextBox.Size = new Size(300, 84);
    resultTextBox.TabIndex = 0;
    resultTextBox.TabStop = false;
  
    inputLabel.AutoSize = true;
    inputLabel.Font = new Font("Segoe UI", 11F);
    inputLabel.Location = new Point(15, 123);
    inputLabel.Name = "inputLabel";
    inputLabel.Size = new Size(100, 20);
    inputLabel.TabIndex = 1;
    inputLabel.Text = "Код региона:";
   
    codeTextBox.Font = new Font("Segoe UI", 11F);
    codeTextBox.Location = new Point(121, 120);
    codeTextBox.MaxLength = 2;
    codeTextBox.Name = "codeTextBox";
    codeTextBox.Size = new Size(39, 27);
    codeTextBox.TabIndex = 2;
    codeTextBox.TextAlign = HorizontalAlignment.Center;
    
    menuStrip.Items.AddRange(new ToolStripItem[] { helpButton });
    menuStrip.Location = new Point(0, 0);
    menuStrip.Name = "menuStrip";
    menuStrip.Size = new Size(329, 24);
    menuStrip.TabIndex = 3;
    
    helpButton.Name = "helpButton";
    helpButton.Padding = new Padding(6, 0, 0, 0);
    helpButton.Size = new Size(63, 20);
    helpButton.Text = "Справка";
    helpButton.Click += (sender, e) => HelpRequested?.Invoke(this, EventArgs.Empty);
   
    ClientSize = new Size(329, 161);
    Controls.Add(resultTextBox);
    Controls.Add(inputLabel);
    Controls.Add(codeTextBox);
    Controls.Add(menuStrip);
    FormBorderStyle = FormBorderStyle.FixedDialog;
    MainMenuStrip = menuStrip;
    MaximizeBox = false;
    Name = "RegionForm";
    StartPosition = FormStartPosition.CenterScreen;
    Text = "  Автокод";
    menuStrip.ResumeLayout(false);
    menuStrip.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
  }

  private TextBox resultTextBox;
  private Label inputLabel;
  private TextBox codeTextBox;
  private MenuStrip menuStrip;
  private ToolStripMenuItem helpButton;
}
