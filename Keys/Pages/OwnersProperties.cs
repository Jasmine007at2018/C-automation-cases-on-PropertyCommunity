using Keys.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys.Test
{
    class OwnersProperties
    {
        internal OwnersProperties()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        // Owners 
        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Owners ')]")]
        private IWebElement Owners { get; set; }

        // Properties       
        [FindsBy(How = How.XPath, Using = "html/body/nav/div/ul/li[2]/ul/li[1]/a")]
        private IWebElement Properties { get; set; }

        //Add New Property
        [FindsBy(How = How.XPath, Using = "//a[@href='/PropertyOwners/Property/AddNewProperty']")]
        private IWebElement addNewProperty { get; set; }
       
        //Click on "Add New Property"
        public void AddNewProperty()
        {
            Owners.Click();//select "Onwers"
            Properties.Click();//select "Properties"            
            addNewProperty.Click();//click on "Add New Property"
        }
    }
}





