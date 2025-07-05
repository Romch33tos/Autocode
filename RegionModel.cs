using System.Collections.Generic;

public class RegionModel
{
  private readonly Dictionary<int, string> _regionCodes;

  public RegionModel()
  {
    _regionCodes = new Dictionary<int, string>
    {
      { 1, "Республика Адыгея" },
      { 2, "Республика Башкортостан" },
      { 99, "г. Москва"}
    };
  }

  public string GetRegionName(int code)
  {
    return _regionCodes.TryGetValue(code, out var regionName)
        ? regionName
        : "Регион с таким кодом не найден";
  }
}
