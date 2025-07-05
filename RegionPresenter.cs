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
      "1. Введите две последние цифры кода и нажмите Enter.\n2. Название региона отобразится в окне вывода.",
      "Помощь",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information);
  }
}
