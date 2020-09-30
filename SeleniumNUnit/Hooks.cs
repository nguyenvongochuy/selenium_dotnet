using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeleniumNUnit.bases;
using TechTalk.SpecFlow;

namespace SeleniumNUnit
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            Base.openBrowser("chrome");
        }

        [AfterScenario]
        [Scope(Tag = "WebTest")]
        public void AfterScenario()
        {
            
            Base.closeBrowser();

        }
    }
}
