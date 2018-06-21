using Keys.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys.Pages
{
    class TenantManagement
    {
        internal TenantManagement()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        //finding items for Owners>Properties
        // Owners 
        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Owners ')]")]
        private IWebElement Owners { get; set; }
        // Properties       
        [FindsBy(How = How.XPath, Using = "html/body/nav/div/ul/li[2]/ul/li[1]/a")]
        private IWebElement Properties { get; set; }

        //finding items for TenantManagement
        // drop-down menu button
        [FindsBy(How = How.XPath, Using = ".//*[@id='main-content']/section/div[1]/div/div[3]/div/div[1]/div[2]/div[1]/div[3]/div/i")]
        private IWebElement menuBtn { get; set; }
        // Properties       
        [FindsBy(How = How.XPath, Using = "//a[@href='/PropertyOwners/Property/PropertyTenants?returnUrl=%2FPropertyOwners&PropId=6368&templateId=1']")]
        private IWebElement tenantManagementTab { get; set; }
               
        // Edit button 
        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Edit')]")]
        private IWebElement edit { get; set; }

        //// Properties       
        //[FindsBy(How = How.XPath, Using = "html/body/nav/div/ul/li[2]/ul/li[1]/a")]
        //private IWebElement Properties { get; set; }


    }
}
