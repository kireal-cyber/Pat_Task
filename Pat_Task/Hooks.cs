using Reqnroll;
using EHU.Drivers;

namespace EHU.StepDefinitions
{
    [Binding]
    public sealed class Hooks
    {
        [AfterScenario]
        public void AfterScenario()
        {
            WebDriverSingleton.QuitDriver();
        }
    }
}
