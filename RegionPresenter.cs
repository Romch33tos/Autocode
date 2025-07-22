using System;
using System.Windows.Forms;

public class RegionPresenter
{
  private readonly IRegionView _view;
  private readonly RegionModel _model;

  public RegionPresenter(IRegionView view, RegionModel model)
  {
    _view = view;
    _model = model;
    _view.CodeEntered += OnCodeEntered;
    _view.HelpRequested += OnHelpRequested;
  }

  private void OnCodeEntered(object sender, EventArgs e)
  {
    if (int.TryParse(_view.InputCode, out int code))
    {
      string regionName = _model.GetRegionName(code);
      _view.ResultText = $"{regionName}";
    }
    else
    {
      _view.ResultText = "Ошибка: введите числовой код региона";
    }
  }

  private void OnHelpRequested(object sender, EventArgs e)
  {
    MessageBox.Show(
      "Введите две последние цифры кода региона и нажмите\nклавишу Enter. Его название отобразится в окне вывода.",
      "Справка",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information);
  }
}
