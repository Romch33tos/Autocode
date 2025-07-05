using System;
using System.Windows.Forms;

public partial class RegionForm : Form, IRegionView
{
  public RegionForm()
  {
    InitializeComponent();
    SetupEvents();
  }

  private void SetupEvents()
  {
    codeTextBox.KeyDown += (sender, e) => 
    {
      if (e.KeyCode == Keys.Enter)
      {
        e.SuppressKeyPress = true;
        CodeEntered?.Invoke(this, EventArgs.Empty);
        InputCode = string.Empty;
      }
    };
    
    helpToolStripMenuItem.Click += (sender, e) => HelpRequested?.Invoke(this, EventArgs.Empty);
  }

  public string InputCode
  {
    get => codeTextBox.Text;
    set => codeTextBox.Text = value;
  }

  public string ResultText
  {
    get => resultTextBox.Text;
    set => resultTextBox.Text = value;
  }

  public event EventHandler CodeEntered;
  public event EventHandler HelpRequested;
}
