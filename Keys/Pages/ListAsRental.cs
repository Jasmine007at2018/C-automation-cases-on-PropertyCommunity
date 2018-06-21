using Keys.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys.Pages
{
    class ListAsRental
    {
        internal  ListAsRental()
        {
            PageFactory.InitElements(Driver.driver,this);
        }
        
        //finding items for Owners>Properties
        // Owners 
        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Owners ')]")]
        private IWebElement Owners { get; set; }
        // Properties       
        [FindsBy(How = How.XPath, Using = "html/body/nav/div/ul/li[2]/ul/li[1]/a")]
        private IWebElement Properties { get; set; }

        //finding "List As Rental" item of the first property record
        [FindsBy(How = How.XPath, Using = "//a[@href='/PropertyOwners/Property/ListRental?returnUrl=%2FPropertyOwners&propId=6073']")]
        private IWebElement listAsRental { get; set; }

        //finding  items on "List A Rental" page
        //finding the title
        [FindsBy(How = How.XPath, Using = "//input[@data-bind='textInput : Title']")]
        private IWebElement title { get; set; }

        //fingding the description
        [FindsBy(How = How.XPath, Using = "//textarea[@data-bind='textInput : RentalDescription']")]
        private IWebElement description { get; set; }

        //finding the moving cost
        [FindsBy(How = How.XPath, Using = "//input[@data-bind='textInput : MovingCost']")]
        private IWebElement movingCost { get; set; }

        //finding the targetRent
        [FindsBy(How = How.XPath, Using = "//input[@data-bind='textInput : TargetRent']")]
        private IWebElement targetRent { get; set; }

        //finding the availableDate
        [FindsBy(How = How.XPath, Using = "//input[@name='AvailableDate']")]
        private IWebElement availableDate { get; set; }

        //finding the occupant count
        [FindsBy(How = How.XPath, Using = "//input[@data-bind='textInput : OccupantCount']")]
        private IWebElement occupantCount { get; set; }

        //finding the save button
        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Save')]")]
        private IWebElement saveBtn { get; set; }

        //finding PropertiesForRental tab
        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Properties For Rent')]")]
        private IWebElement propertiesForRental { get; set; }

        //finding searchbox on PropertiesForRental page
        [FindsBy(How = How.XPath, Using = "//input[@id='searchId']")]
        private IWebElement searchBox_Rental { get; set; }

        //finding search button on PropertiesForRental page
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement searchBtn_Rental { get; set; }

        //enter listing retal details
        public void EnterListARetalDetails()
        {
            //click on Owners tab
            Owners.Click();
            
            //click on Properties tab
            Properties.Click();

            //click on "List As Rental" on the first property recording
            listAsRental.Click();

            //open the the data of ListAsRental sheet
            ExcelLib.PopulateInCollection(Base.ExcelPath,"ListAsRental");

            //write the data to title
            title.SendKeys(ExcelLib.ReadData(2,"title"));

            //write the data to description
            description.SendKeys(ExcelLib.ReadData(2, "description"));

            //write the data to movingCost
            movingCost.SendKeys(ExcelLib.ReadData(2, "movingCost"));

            //write the data to targetRent
            targetRent.SendKeys(ExcelLib.ReadData(2, "targetRent"));

            //write the data to availableDate
            availableDate.SendKeys(ExcelLib.ReadData(2, "availableDate"));

            //write the data to occupantCount
            occupantCount.SendKeys(ExcelLib.ReadData(2, "occupantCount"));

            Driver.wait(2);

            //click on save button
            saveBtn.Click();

            Driver.wait(2);

            //choose yes on the save confirmation
            IAlert alert = Driver.driver.SwitchTo().Alert();
            alert.Accept();
        }

        public void ValidateListARetalDetails()
        {
            //open propertiesForRental page
            propertiesForRental.Click();

            //open the the data of ListAsRental sheet
            ExcelLib.PopulateInCollection(Base.ExcelPath,"ListAsRental");

            //expectedResult=the property'name just list as rental
            var expectedResult = ExcelLib.ReadData(2, "title");

            //put in the property name in the search box and search it
            searchBox_Rental.SendKeys(ExcelLib.ReadData(2, "propertyName"));
            searchBtn_Rental.Click();

            // Screenshot
            String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "FinalScreenshot");
            Base.test.Log(LogStatus.Info, "FinalScreenshot: " + img);

            //get the property name of the search result
            var actualResult = Driver.driver.FindElement(By.XPath("//h4[@data-bind='text : Model.Title']")).Text;

            //compare the search result with the expected result
            if (actualResult == expectedResult)
                    //Console.WriteLine("Test Pass");
                    Base.test.Log(LogStatus.Pass, "ValidateListARetalDetails is Passed");
            else
                     // Console.WriteLine("Test Failed");
                    Base.test.Log(LogStatus.Fail, "ValidateListARetalDetails is Failed");

        }

    }
}
