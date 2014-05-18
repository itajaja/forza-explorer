namespace ForzaExplorer.Services
{
  public class TestConfigurationService : IConfigurationService
  {
    public TestConfigurationService()
    {
      HomePath = @"C:\Users\g.tagliabue\";
    }

    public string HomePath { get; private set; }
  }
}