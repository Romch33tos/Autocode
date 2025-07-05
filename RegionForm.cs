using System;

public class RegionForm : IRegionView
{
  private readonly RegionFormUI _ui;

  public RegionForm()
  {
    _ui = new RegionFormUI();
    _ui.CodeEntered += (s, e) => CodeEntered?.Invoke(this, e);
    _ui.HelpRequested += (s, e) => HelpRequested?.Invoke(this, e);
  }

  public string InputCode
  {
    get => _ui.InputCode;
    set => _ui.InputCode = value;
  }

  public string ResultText
  {
    get => _ui.ResultText;
    set => _ui.ResultText = value;
  }

  public event EventHandler CodeEntered;
  public event EventHandler HelpRequested;

  public void Show()
  {
    _ui.Show();
  }
}
