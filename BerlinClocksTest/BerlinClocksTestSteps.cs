using System;
using TechTalk.SpecFlow;

namespace BerlinClocksTest
{
    [Binding]
    public class BerlinClocksTestSteps
    {
        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeİs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string multilineText)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
