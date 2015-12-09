﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objectivity.Test.Automation.Common;
using Objectivity.Test.Automation.Common.Extensions;
using Objectivity.Test.Automation.Common.Types;

namespace Objectivity.Test.Automation.Tests.PageObjects.PageObjects.TheInternet
{
    public class NewWindowPage : ProjectPageBase
    {
        private readonly ElementLocator
    newWindowPageLocator = new ElementLocator(Locator.CssSelector, "h3");
        
        public NewWindowPage(DriverContext driverContext) : base(driverContext)
        {
        }

        public bool IsNewWindowH3TextVisible(string text)
        {
            return Driver.GetElement(newWindowPageLocator).IsElementTextEqualsToExpected(text);
        }

        public bool IsPageTile(string title)
        {
            return Driver.IsPageTitle(title, 2);
        }
    }
}