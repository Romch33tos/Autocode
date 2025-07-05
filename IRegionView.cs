using System;

public interface IRegionView
{
  string InputCode { get; set; }
  string ResultText { get; set; }
  event EventHandler CodeEntered;
  event EventHandler HelpRequested;
}
