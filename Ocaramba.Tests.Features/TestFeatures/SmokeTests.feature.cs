// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Ocaramba.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SmokeTestsFeature : Xunit.IClassFixture<SmokeTestsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "SmokeTests.feature"
#line hidden
        
        public SmokeTestsFeature(SmokeTestsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SmokeTests", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Verify default option selected in dropdown")]
        [Xunit.TraitAttribute("FeatureTitle", "SmokeTests")]
        [Xunit.TraitAttribute("Description", "Verify default option selected in dropdown")]
        [Xunit.TraitAttribute("Category", "Dropdown")]
        public virtual void VerifyDefaultOptionSelectedInDropdown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify default option selected in dropdown", null, new string[] {
                        "Dropdown"});
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 28
 testRunner.Given("Default page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
 testRunner.When("I click \"dropdown\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.And("I see page Dropdown List", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("I check selected option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.Then("Option with text \"Please select an option\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Verify if dropdown option can be selected by text")]
        [Xunit.TraitAttribute("FeatureTitle", "SmokeTests")]
        [Xunit.TraitAttribute("Description", "Verify if dropdown option can be selected by text")]
        [Xunit.TraitAttribute("Category", "Dropdown")]
        public virtual void VerifyIfDropdownOptionCanBeSelectedByText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify if dropdown option can be selected by text", null, new string[] {
                        "Dropdown"});
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 36
 testRunner.Given("Default page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
 testRunner.When("I click \"dropdown\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.And("I see page Dropdown List", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.When("I select option with text \"Option 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.And("I check selected option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.Then("Option with text \"Option 1\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Verify if dropdown option can be selected by index with custom timeout")]
        [Xunit.TraitAttribute("FeatureTitle", "SmokeTests")]
        [Xunit.TraitAttribute("Description", "Verify if dropdown option can be selected by index with custom timeout")]
        [Xunit.TraitAttribute("Category", "Dropdown")]
        public virtual void VerifyIfDropdownOptionCanBeSelectedByIndexWithCustomTimeout()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify if dropdown option can be selected by index with custom timeout", null, new string[] {
                        "Dropdown"});
#line 44
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 45
 testRunner.Given("Default page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
 testRunner.When("I click \"dropdown\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.And("I see page Dropdown List", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.When("I select option with custom timeout \'300\' with index \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.And("I check selected option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.Then("Option with text \"Option 1\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Verify if dropdown option can be selected by index")]
        [Xunit.TraitAttribute("FeatureTitle", "SmokeTests")]
        [Xunit.TraitAttribute("Description", "Verify if dropdown option can be selected by index")]
        [Xunit.TraitAttribute("Category", "Dropdown")]
        public virtual void VerifyIfDropdownOptionCanBeSelectedByIndex()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify if dropdown option can be selected by index", null, new string[] {
                        "Dropdown"});
#line 53
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 54
 testRunner.Given("Default page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 55
 testRunner.When("I click \"dropdown\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.And("I see page Dropdown List", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.When("I select option with index \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.And("I check selected option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.Then("Option with text \"Option 1\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Verify if dropdown option can be selected by value")]
        [Xunit.TraitAttribute("FeatureTitle", "SmokeTests")]
        [Xunit.TraitAttribute("Description", "Verify if dropdown option can be selected by value")]
        [Xunit.TraitAttribute("Category", "Dropdown")]
        public virtual void VerifyIfDropdownOptionCanBeSelectedByValue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify if dropdown option can be selected by value", null, new string[] {
                        "Dropdown"});
#line 62
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 63
 testRunner.Given("Default page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
 testRunner.When("I click \"dropdown\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.And("I see page Dropdown List", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.When("I select option with value \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.And("I check selected option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.Then("Option with text \"Option 2\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Verify if dropdown option can be selected by value with custom timeout")]
        [Xunit.TraitAttribute("FeatureTitle", "SmokeTests")]
        [Xunit.TraitAttribute("Description", "Verify if dropdown option can be selected by value with custom timeout")]
        [Xunit.TraitAttribute("Category", "Dropdown")]
        public virtual void VerifyIfDropdownOptionCanBeSelectedByValueWithCustomTimeout()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify if dropdown option can be selected by value with custom timeout", null, new string[] {
                        "Dropdown"});
#line 71
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 72
 testRunner.Given("Default page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 73
 testRunner.When("I click \"dropdown\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.And("I see page Dropdown List", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.When("I select option with custom timeout \'300\' with value \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.And("I check selected option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.Then("Option with text \"Option 2\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Key Presses Test")]
        [Xunit.TraitAttribute("FeatureTitle", "SmokeTests")]
        [Xunit.TraitAttribute("Description", "Key Presses Test")]
        [Xunit.InlineDataAttribute("\"ESC\"", "\"ESCAPE\"", new string[0])]
        [Xunit.InlineDataAttribute("\"F2\"", "\"F2\"", new string[0])]
        [Xunit.InlineDataAttribute("\"1\"", "\"NUMPAD1\"", new string[0])]
        [Xunit.InlineDataAttribute("\"TAB\"", "\"TAB\"", new string[0])]
        [Xunit.InlineDataAttribute("\"SPACE\"", "\"SPACE\"", new string[0])]
        [Xunit.InlineDataAttribute("\"ARROW DOWN\"", "\"DOWN\"", new string[0])]
        [Xunit.InlineDataAttribute("\"ARROW LEFT\"", "\"LEFT\"", new string[0])]
        [Xunit.InlineDataAttribute("\"ALT\"", "\"ALT\"", new string[0])]
        [Xunit.InlineDataAttribute("\"SHIFT\"", "\"SHIFT\"", new string[0])]
        [Xunit.InlineDataAttribute("\"PAGE UP\"", "\"PAGE_UP\"", new string[0])]
        [Xunit.InlineDataAttribute("\"PAGE DOWN\"", "\"PAGE_DOWN\"", new string[0])]
        [Xunit.InlineDataAttribute("\"DELETE\"", "\"DELETE\"", new string[0])]
        [Xunit.InlineDataAttribute("\"MULTIPLY\"", "\"MULTIPLY\"", new string[0])]
        [Xunit.InlineDataAttribute("\"SUBTRACT\"", "\"SUBTRACT\"", new string[0])]
        public virtual void KeyPressesTest(string key, string message, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Key Presses Test", null, exampleTags);
#line 79
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 80
 testRunner.Given("Default page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 81
 testRunner.When("I click \"key_presses\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.And(string.Format("I press {0}", key), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.Then(string.Format("Valid {0} is displayed", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Do not press any key")]
        [Xunit.TraitAttribute("FeatureTitle", "SmokeTests")]
        [Xunit.TraitAttribute("Description", "Do not press any key")]
        [Xunit.InlineDataAttribute("\"\"", new string[0])]
        public virtual void DoNotPressAnyKey(string key, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Do not press any key", null, exampleTags);
#line 102
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 103
 testRunner.Given("Default page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 104
 testRunner.When("I click \"key_presses\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.When(string.Format("I press {0}", key), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
 testRunner.Then("Results element is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SmokeTestsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SmokeTestsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion