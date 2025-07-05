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
    this.resultTextBox = new TextBox();
    this.inputLabel = new Label();
    this.codeTextBox = new TextBox();
    this.menuStrip = new MenuStrip();
    this.helpToolStripMenuItem = new ToolStripMenuItem();
    this.menuStrip.SuspendLayout();
    this.SuspendLayout();
    
    // resultTextBox
    this.resultTextBox.Location = new Point(20, 30);
    this.resultTextBox.Size = new Size(300, 80);
    this.resultTextBox.Multiline = true;
    this.resultTextBox.ReadOnly = true;
    this.resultTextBox.BackColor = Color.White;
    this.resultTextBox.Font = new Font("Segoe UI", 11F);
    this.resultTextBox.WordWrap = true;
    this.resultTextBox.TabStop = false;
    
    // inputLabel
    this.inputLabel.Text = "Код региона:";
    this.inputLabel.Location = new Point(20, 120);
    this.inputLabel.AutoSize = true;
    this.inputLabel.Font = new Font("Segoe UI", 11F);
    
    // codeTextBox
    this.codeTextBox.Location = new Point(125, 120);
    this.codeTextBox.Size = new Size(40, 30);
    this.codeTextBox.Font = new Font("Segoe UI", 11F);
    this.codeTextBox.MaxLength = 2;
    this.codeTextBox.TextAlign = HorizontalAlignment.Center;
    
    // menuStrip
    this.menuStrip.Items.Add(this.helpToolStripMenuItem);
    
    // helpToolStripMenuItem
    this.helpToolStripMenuItem.Text = "Справка";
    
    // RegionForm
    this.Text = "Автокод";
    this.Size = new Size(350, 200);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Controls.Add(this.resultTextBox);
    this.Controls.Add(this.inputLabel);
    this.Controls.Add(this.codeTextBox);
    this.Controls.Add(this.menuStrip);
    this.MainMenuStrip = this.menuStrip;
    
    this.menuStrip.ResumeLayout(false);
    this.menuStrip.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private TextBox resultTextBox;
  private Label inputLabel;
  private TextBox codeTextBox;
  private MenuStrip menuStrip;
  private ToolStripMenuItem helpToolStripMenuItem;
}
