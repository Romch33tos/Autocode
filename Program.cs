using System;
using System.Windows.Forms;

static class Program
{
  [STAThread]
  static void Main()
  {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    
    var view = new RegionForm();
    var model = new RegionModel();
    var presenter = new RegionPresenter(view, model);
    
    Application.Run(view);
  }
}
