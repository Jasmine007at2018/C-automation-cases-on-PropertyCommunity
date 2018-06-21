using Keys.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Keys.Pages
{
    class Rental_Listings_and_Tenant_Applications
    {
        internal Rental_Listings_and_Tenant_Applications()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        //finding "skip" button on dashboard page after login
        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[5]/a[1]")]
        private IWebElement skip { get; set; }

        //Owners menu obj
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div[1]")]
        private IWebElement owners  { get; set; }

        //Rental Listings&Applications menu item obj
        [FindsBy(How = How.XPath, Using = ("/html/body/div[1]/div/div[2]/div[1]/div/a[2]"))]
        private IWebElement rLAndRA { get; set; }

        
        //search box
        [FindsBy(How = How.XPath, Using = (".//*[@id='search-wrap']/form/div/input"))]
        private IWebElement searchBox { get; set; }

        ////address of street  //span[@data-bind='text : StreetAddress']
        //[FindsBy(How = How.XPath, Using = ("//span[@data-bind='text : StreetAddress']"))]
        //private IWebElement address { get; set; }

        //Details button
        [FindsBy(How = How.XPath, Using = ("//div[@class='ui mini basic teal button']"))]
        private IWebElement detailsBtn { get; set; }

        //name displayed area
        [FindsBy(How = How.XPath, Using = ("//h3[@data-bind='text: Model.Title']"))]
        private IWebElement propertyName { get; set; }

        //Address displayed area        
        [FindsBy(How = How.XPath, Using = ("//span[@data-bind='text: StreetAddress']"))]
        private IWebElement address { get; set; }

        //Address displayed area        
        [FindsBy(How = How.XPath, Using = ("//span[@data-bind='numeric:Model.TargetRent']"))]
        private IWebElement rent { get; set; }

        //Address displayed area        
        [FindsBy(How = How.XPath, Using = ("//span[@data-bind='text:RentalPaymentType']"))]
        private IWebElement rentalPaymentType { get; set; }

        //Address displayed area        
        [FindsBy(How = How.XPath, Using = ("/html/body/div[2]/section/div[3]/div[2]/div[2]/div[1]/div/div[7]/div/div[2]/span"))]
        private IWebElement availableDate { get; set; }

        //Address displayed area        
        [FindsBy(How = How.XPath, Using = ("//textarea[@data-bind='textInput : RentalDescription']"))]
        private IWebElement description { get; set; }

        //List A Rental button
        //[FindsBy(How = How.ClassName, Using = ("ui teal button"))]//a[@class='ui teal button']
        [FindsBy(How =How.XPath,Using = ".//*[@id='main-content']/section/div[1]/div[2]/div/div[2]/a")]
        private IWebElement listARentalBtn { get; set; }

        //title of List Rental Property page
        [FindsBy(How = How.XPath, Using = ("/html/body/div[2]/section/div[1]/div/div/h2"))]
        private IWebElement titleOfLRP { get; set; }

        //select property box
        [FindsBy(How = How.XPath, Using = ("//select[@data-bind='value : PropertyId']"))]
        private IWebElement selPropertyBox { get; set; }

        //title box
        [FindsBy(How = How.XPath, Using = ("/html/body/div[2]/section/div[1]/form/div[2]/div[1]/input[1]"))]
        private IWebElement title { get; set; }

        //description box
        [FindsBy(How = How.XPath, Using = ("/html/body/div[2]/section/div[1]/form/div[2]/div[2]/textarea"))]
        private IWebElement description_LRP { get; set; }

        //Moving Cost box
        [FindsBy(How = How.XPath, Using = ("//input[@data-bind='textInput : MovingCost']"))]
        private IWebElement movingCost { get; set; }

        //Target Rent box
        [FindsBy(How = How.XPath, Using = ("//input[@data-bind='textInput : TargetRent']"))]
        private IWebElement targetRent { get; set; }

        //Furnishing box
        [FindsBy(How = How.XPath, Using = ("/html/body/div[2]/section/div[1]/form/div[3]/div[2]/input"))]
        private IWebElement furnishing { get; set; }

        //AvailableDate box
        [FindsBy(How = How.Name, Using = ("AvailableDate"))]
        private IWebElement availableDate_LRP { get; set; }

        //Ideal Tenant box
        [FindsBy(How = How.XPath, Using = ("//input[@data-bind='textInput : IdealTenant']"))]
        private IWebElement idealTenant { get; set; }

        //Occupant Count box
        [FindsBy(How = How.XPath, Using = ("//input[@data-bind='textInput : OccupantCount']"))]
        private IWebElement occupantCount { get; set; }

        //Pets Allowed  box
        [FindsBy(How = How.XPath, Using = (".//*[@id='main-content']/section/div[1]/form/div[5]/div[2]/select"))]
        private IWebElement petsAllowed { get; set; }

        //Pets Allowed "Yes" box
        [FindsBy(How = How.XPath, Using = (".//*[@id='main-content']/section/div[1]/form/div[5]/div[2]/select/option[1]"))]
        private IWebElement petsYes { get; set; }

        //Pets Allowed "No" box
        [FindsBy(How = How.XPath, Using = (".//*[@id='main-content']/section/div[1]/form/div[5]/div[2]/select/option[2]"))]
        private IWebElement petsNo { get; set; }

        //choose file button
        [FindsBy(How = How.Id, Using = ("file-upload"))]
        private IWebElement fileUpload { get; set; }

        //Save button
        [FindsBy(How = How.XPath, Using = ("//button[contains(.,'Save')]"))]
        private IWebElement saveBtn { get; set; }

        //Cancel button
        [FindsBy(How = How.Id, Using = ("//button[contains(.,'Cancel')]"))]
        private IWebElement cancelBtn { get; set; }






        //method to List A Rental
        public String ListARental()
        {
           
            try {
                String expectedTitle = "List Rental Property";
                String actualTitle = null;

                //click on List A Rental button
                listARentalBtn.Click();
                Driver.wait(2);

                //check if locate to List Rental Property page
                actualTitle = titleOfLRP.Text;
                if (expectedTitle == actualTitle)
                {
                    Base.test.Log(LogStatus.Pass, "has been located to List Rental Property page ");
                }
                else
                {
                    Base.test.Log(LogStatus.Fail, "has not been located to List Rental Property page ");
                }

                Assert.AreEqual(expectedTitle, actualTitle, "has not been located to List Rental Property page");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message);
            }

            //prepare values for boxes on List Rental Property page
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ListAsRental");
            try
            {               
                //get the address for rental from excel sheet
                String addressForTest = ExcelLib.ReadData(2, "address");

                //starting input values for boxes on List Rental Property page
                //select the property under testing in the excel sheet from the Select Property Box
                selPropertyBox.Click();
                Driver.wait(2);

                ICollection<IWebElement> addressesInBox = selPropertyBox.FindElements(By.TagName("option"));

                //get the amount of addresses in select property box
                int i=addressesInBox.Count;
                //Console.WriteLine("The amount is : "+i);
                int j = 1;

                foreach (IWebElement addressOfProperty in addressesInBox)
                {
                    //Console.WriteLine(addressOfProperty.Text);
                    if (addressOfProperty.Text.Equals(addressForTest))
                    {
                        addressOfProperty.Click();
                        break;
                    }
                    else if (j < i)
                    {
                        j++;
                    }else
                    {
                        Base.test.Log(LogStatus.Fail,"No address for testing");
                    }
                }

                title.SendKeys(ExcelLib.ReadData(2, "title"));
                description.SendKeys(ExcelLib.ReadData(2, "description"));
                movingCost.SendKeys(ExcelLib.ReadData(2, "movingCost"));
                targetRent.SendKeys(ExcelLib.ReadData(2, "targetRent"));
                furnishing.SendKeys(ExcelLib.ReadData(2, "furnishing"));
                availableDate_LRP.Clear();
                availableDate_LRP.SendKeys(ExcelLib.ReadData(2, "availableDate"));
                idealTenant.SendKeys(ExcelLib.ReadData(2, "IdealTenant"));
                occupantCount.SendKeys(ExcelLib.ReadData(2, "occupantCount"));

                //choose Yes or No for "pets allowed"
                petsAllowed.Click();
                if (ExcelLib.ReadData(2, "Pets Allowed ") == "Yes") petsYes.Click();
                else petsNo.Click();

                //upload picture for the house
                fileUpload.SendKeys(Base.PicturePath + ExcelLib.ReadData(2, "Choose File"));

                //click on save and confirm save
                saveBtn.Click();
                Driver.driver.SwitchTo().Alert().Accept();

                //check if return to RentalListings&Applications page
                CheckOwners_RLAndAppPage();

                

            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message);
            }

            return ExcelLib.ReadData(2, "title");

        }

        //method to check if the property has been listed as a rental
        public void CheckListedRental(String title)
        {
            //get the address from the excel sheet corresponding to the title
            //String address = null;

            //search rental via title
            searchBox.SendKeys(title);
            searchBox.SendKeys(OpenQA.Selenium.Keys.Enter);

            Driver.wait(5);

            //get the first record's title and address
            //Console.WriteLine(Driver.driver.FindElement(By.XPath("/html/body/div[2]/section/div[1]/div[3]/div/div[1]/div[2]/div[1]/div[1]")).Text);

            //Get the list of search results 
            //IReadOnlyCollection<IWebElement> rentalList = Driver.driver.FindElements(By.XPath(".//*[@class='item']/div[2]/div/div/a"));
            
            //get the title list
            IList<IWebElement> rentalList = Driver.driver.FindElements(By.XPath(".//*[@class='item']/div[2]/div/div/a"));
            
            //get the title and address list
            //IList<IWebElement> rentalList = Driver.driver.FindElements(By.XPath("/html/body/div[2]/section/div[1]/div[3]/div/div/div[2]/div[1]/div[1]"));

            foreach (IWebElement rental in rentalList)
            {
                //Console.WriteLine(rental.Text + "  is the title&address");

                if (rental.Text==title)
                {
                    Base.test.Log(LogStatus.Pass, "Has been listed as rental successfully");
                    break;
                }
                Assert.AreEqual(rental.Text, title,"Has not been listed as rental");
            }


        }


        //method to open Owners->RentalListings&Applications page
        public void OpenRentListAndApp()
        {
            
            //maximize the window
            Driver.driver.Manage().Window.Maximize();
            Driver.wait(2);

            try
            {
                //skip Quick Buttons
                skip.Click();
                Driver.wait(2);
            } catch (Exception)
            { Console.WriteLine("No skip page"); }

            //click on Owners menu obj
            owners.Click();
            Driver.wait(2);

            //click on Rental Listings&Applications menu item obj
            rLAndRA.Click();
        }

        //method to check if locate to Owners->RentalListings&Applications page
        public void CheckOwners_RLAndAppPage()
        {
            String expectedTitle = null;
            String actualTitle = null;

            Driver.wait(2);

            //check if have located to Owners->RentalListings&Applications page           
            //actualTitle = Driver.driver.FindElement(By.XPath("//h2[@class='ui header']")).Text;
            actualTitle = Driver.driver.FindElement(By.XPath("html/body/div[2]/section/div/div/div/h2")).Text;
            
            expectedTitle = "Rental Listings and Tenant Applications";
            Assert.IsNotNull(actualTitle);

            if (actualTitle == expectedTitle)
            {
                Base.test.Log(LogStatus.Pass, "Have located to Owners->RentalListings&Applications page");
            }
            else
            {
                Base.test.Log(LogStatus.Fail, "Have not located to Owners->RentalListings&Applications page");
            }
            Assert.AreEqual(actualTitle, expectedTitle, "Title is Wrong.");

        }

        public void CheckDetails()
        {
            try
            {
                //click on the Details button
                detailsBtn.Click();
                Driver.wait(2);

                //check if items of the property are displayed correctly
                Assert.AreEqual(propertyName.Text, "Testing house1", "Property Name is wrong");
                Assert.IsTrue(address.Text.Contains("34 Great North Road"), "Property Address is wrong");
                Assert.AreEqual(rent.Text, "400.00", "Property Rent is wrong");
                Assert.AreEqual(rentalPaymentType.Text, "Weekly", "RentalPaymentType is wrong");
                //Base.test.Log(LogStatus.Info, availableDate.Text);
                Assert.AreEqual(availableDate.Text, "Mar 26, 2018", "AvailableDate is wrong");
                Assert.AreEqual(description.Text, "This is the testing house1", "Description is wrong");

                Base.test.Log(LogStatus.Pass,"Items of the property are displayed correctly");

                //propertyName
                //searchAddress
                //description
                //bedroomsNumber
                //Moving Cost:
                //Furnishing:
                //Ideal Tenant:
                //Pets Allowed:
                //Available Date:

            } catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message);
            }
        }







    }
}
