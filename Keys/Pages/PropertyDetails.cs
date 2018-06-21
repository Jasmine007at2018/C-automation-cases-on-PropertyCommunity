using Keys.Global;
using Keys.Test;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;


namespace Keys.Pages
{
    class PropertyDetails
    {
        internal PropertyDetails()
        {
            PageFactory.InitElements(Driver.driver, this);
        }



        //finding "skip" button on dashboard page after login
        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[5]/a[1]")]
        private IWebElement skip { get; set; }
        
        //finding items for Owners>Properties
        // Owners tab
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]")]
        private IWebElement Owners { get; set; }

        // Properties tab  
        [FindsBy(How = How.XPath, Using = "//a[@href='/PropertyOwners']")]
        private IWebElement Properties { get; set; }

        //finding "Add Tenant" button of the first property record
        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'/PropertyOwners/Home/AddTenantDashboard?returnUrl=%2FPropertyOwners&propId=6368')]")]
        private IWebElement addTenant { get; set; }

        //finding "List As Rental" button of the first property record
        [FindsBy(How = How.XPath, Using = "//a[@href='/PropertyOwners/Property/ListRental?returnUrl=%2FPropertyOwners&propId=6073']")]
        private IWebElement listAsRental { get; set; }

        // drop-down menu button of the first property record
        [FindsBy(How = How.XPath, Using = ".//*[@id='main-content']/section/div[1]/div/div[3]/div/div[1]/div[2]/div[1]/div[3]/div/i")]
        private IWebElement menuBtn { get; set; }

        #region items of Tenant Management
        // tenantManagementTab in the drop-down menu       
        [FindsBy(How = How.XPath, Using = ".//*[@id='main-content']/section/div[1]/div/div[3]/div/div[1]/div[2]/div[1]/div[3]/div/div/div[3]/a")]
        //a[@href='/PropertyOwners/Property/PropertyTenants?returnUrl=%2FPropertyOwners&PropId=6384&templateId=1']
        private IWebElement tenantManagementTab { get; set; }

        // Edit button on Tenant Management page
        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Edit')]")]
        private IWebElement edit { get; set; }

        //Remove button on Tenant Management page
        [FindsBy(How = How.XPath, Using = "//button[contains(.,' Remove')]")]
        private IWebElement remove { get; set; }

        //confirm button on Remove page
        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Confirm')]")]
        private IWebElement confirm { get; set; }


        //mainTenantDropdown
        [FindsBy(How = How.XPath, Using = "//select[@id='isMainTenantDropdown']")]
        private IWebElement mainTenantDropdown { get; set; }

        //rent start date on edit tenant page
        [FindsBy(How = How.XPath, Using = ".//*[@class='row']/div/div/input[@name='StartDate']")]
        private IWebElement rentStartDate_edit { get; set; }

        //rent end date on edit tenant page
        [FindsBy(How = How.XPath, Using = ".//*[@id='BasicDetail']/div[4]/div[2]/div/input")]
        private IWebElement rentEndDate_edit { get; set; }

        //rent amount on edit tenant page
        [FindsBy(How = How.XPath, Using = ".//*[@id='BasicDetail']/div[5]/div[1]/div/input")]
        private IWebElement rentAmount_edit { get; set; }

        //paymentFrequency on edit tenant page
        [FindsBy(How = How.XPath, Using = ".//*[@id='BasicDetail']/div[5]/div[2]/div/select")]
        private IWebElement paymentFrequency_edit { get; set; }

        //paymentStartDate on edit tenant page
        [FindsBy(How = How.XPath, Using = ".//*[@id='BasicDetail']/div[6]/div[1]/div/input")]
        private IWebElement paymentStartDate_edit { get; set; }

        //paymentDueDate on edit tenant page
        [FindsBy(How = How.XPath, Using = ".//*[@id='BasicDetail']/div[6]/div[2]/div/select")]
        private IWebElement paymentDueDate_edit { get; set; }

        //next button on edit tenant page
        [FindsBy(How = How.XPath, Using = "//input[@class='btn btn-success']")]
        private IWebElement next_edit { get; set; }

        //next button on Liabilities details page
        [FindsBy(How = How.XPath, Using = ".//*[@id='LiabilityDetail']/div/div[2]/button[2]")]
        private IWebElement next_Liab { get; set; }

        //Submit button on edit page
        [FindsBy(How = How.XPath, Using = "//*[@id='SummaryDetail']/div[10]/div/button[2]")]
        private IWebElement submit { get; set; }



        #endregion






        #region   items of "Add New Property" 
        //finding "Add New Property" button
        [FindsBy(How = How.XPath, Using = "//a[@href='/PropertyOwners/Property/AddNewProperty']")]
        private IWebElement addNewProperty { get; set; }

        //finding IwebElements on PropertyDetails page

        // propertyName input box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='  Enter property name']")]
        private IWebElement propertyName { get; set; }

        // searchAddress input box     
        [FindsBy(How = How.XPath, Using = "//input[@name='searchAddress']")]
        private IWebElement searchAddress { get; set; }

        //description input box
        [FindsBy(How = How.XPath, Using = "//textarea[@class='form-control']")]
        private IWebElement description { get; set; }

        //yearBuilt input box
        [FindsBy(How = How.XPath, Using ="//input[@placeholder='Year Built']")]
        private IWebElement yearBuilt { get; set; }

        //targetRent input box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Rent Amount']")]
        private IWebElement targetRent { get; set; }

        //bedroomsNumber input box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Number of Bedrooms']")]
        private IWebElement bedroomsNumber { get; set; }

        //bathroomsNumber input box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Number of Bathrooms']")]
        private IWebElement bathroomsNumber { get; set; }

        //carparks input box
        [FindsBy(How =How.XPath,Using = "//input[@placeholder='Number of car parks']")]
        private IWebElement carparks { get; set; }

        //Next button on PropertyDetails page
        [FindsBy(How = How.XPath, Using = "//button[@data-bind='click:goF,enable:basicValid']")]
        private IWebElement nextButton { get; set; }
       
        //picture field
        [FindsBy(How = How.XPath, Using = "//div[@class='panel-body']")]
        private IWebElement picture { get; set; }

        //choose files button
        [FindsBy(How = How.XPath, Using = "//input[@accept='image/*']")]
        private IWebElement chooseFile { get; set; }

        //message under property name box
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[1]/div[1]/div/span")]
        private IWebElement messageUnderPropertyName { get; set; }
        
        //finding IwebElements on FinancialDetails page

        //purchasePrice input box
        [FindsBy(How = How.XPath, Using = "//input[@name='purchasePrice']")]
        private IWebElement purchasePrice { get; set; }

        // mortgagePrice input box       
        [FindsBy(How = How.XPath, Using = "//input[@name='mortgagePrice']")]
        private IWebElement mortgagePrice { get; set; }

        //homeValue input box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='  Enter Home Value']")]
        private IWebElement homeValue { get; set; }

        //homeValueType options
        [FindsBy(How = How.XPath, Using = "//select[@data-bind='value : HomeValueType']")]
        private IWebElement homeValueTypeDLL { get; set; }

        //homeValueType: current
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[2]/div[2]/div/select/option[1]")]
        private IWebElement homeValueType_C { get; set; }

        //home value type: estimated
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[2]/div[2]/div/select/option[2]")]
        private IWebElement homeValueType_E { get; set; }

        ////home value type: registered
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[2]/div[2]/div/select/option[3]")]
        private IWebElement homeValueType_R { get; set; }

        //next button on FinancialDetails page
        [FindsBy(How = How.XPath, Using = "//button[@data-bind='click:goT,visible:!IsOwnerOccupied(),enable:IsFinancialValid']")]
        private IWebElement nextBtn_FD { get; set; }

        //Previous button on FinancialDetails page
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[9]/div/button[1]")]
        private IWebElement previousBtn_FD { get; set; }


        //finding IwebElements on TenantDetails page

        //finding tenantEmail box
        [FindsBy(How = How.XPath, Using = "//input[@id='email']")]
        private IWebElement tenantEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='fname']")]
        private IWebElement firstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='lname']")]
        private IWebElement lastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='StartDate']")]
        private IWebElement startDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='EndDate']")]
        private IWebElement endDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='  Enter Rent Amount']")]
        private IWebElement rentAmount { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='psdate']")]
        private IWebElement paymentStartDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='saveProperty']")]
        private IWebElement saveBtn { get; set; }

        #endregion

        //finding the first property name on Owners>Property home page
        [FindsBy(How = How.XPath, Using = "//button[@id='saveProperty']")]
        private IWebElement name { get; set; }

        public void EditTenantWithInvalidData()
        {
            try
            {
                //enter Owners->Properties page
                EnterOwnersPropertiesPage();

                //click on the dropdown menu of the first property record
                menuBtn.Click();

                Thread.Sleep(1000);

                //choose "Management Tenant" from the dropdown menu
                tenantManagementTab.Click();

                //click on "Edit" button on Management Tenant page
                edit.Click();

                //populate data from excel
                ExcelLib.PopulateInCollection(Base.ExcelPath, "AddTenant");

                //delete the old data and then putin the new data but invalid for "Payment Start Date", then press "Enter" key
                paymentStartDate_edit.Clear();
                //paymentStartDate_edit.SendKeys(ExcelLib.ReadData(2, "wrongPaymentStartDate"));
                paymentStartDate_edit.SendKeys("16/04/2018");
                paymentStartDate_edit.SendKeys(OpenQA.Selenium.Keys.Enter);

                var expectedMessage = "Payment start date must be after start date";
                var actualMessage = Driver.driver.FindElement(By.XPath(".//*[@id='BasicDetail']/div[6]/div[1]/div/span")).Text;//the message under "payment start date" input box
                Assert.AreEqual(expectedMessage,actualMessage, "wrong payment start date. Payment start date must be after start date ");
                Base.test.Log(LogStatus.Pass,"Edit with invalid data validated");
            }

            catch(Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message);
            }
        }

        public void EditTenantAndValidate()
        {
            try
            {
                //enter Owners->Properties page
                EnterOwnersPropertiesPage();

                //click on the dropdown menu of the first property record
                menuBtn.Click();

                Thread.Sleep(1000);

                //choose "Management Tenant" from the dropdown menu
                tenantManagementTab.Click();

                //click on "Edit" button on Management Tenant page
                edit.Click();

                //populate data from excel
                ExcelLib.PopulateInCollection(Base.ExcelPath,"AddTenant");

                //delete the old data and then putin the new data for "Rent Start Date"
                rentStartDate_edit.Clear();
                rentStartDate_edit.SendKeys(ExcelLib.ReadData(2,"rentStartDate"));

                //delete the old data and then putin the new data for "End Start Date"
                rentEndDate_edit.Clear();
                rentEndDate_edit.SendKeys(ExcelLib.ReadData(2,"rentEndDate"));

                //delete the old data and then putin the new data for "Rent Amount"
                rentAmount_edit.Clear();
                rentAmount_edit.SendKeys(ExcelLib.ReadData(2, "rentAmount"));

                //delete the old data and then putin the new data for "Payment Start Date", then press "Enter" key
                paymentStartDate_edit.Clear();
                paymentStartDate_edit.SendKeys(ExcelLib.ReadData(2,"paymentStartDate"));
                paymentStartDate_edit.SendKeys(OpenQA.Selenium.Keys.Enter);

                //click on "Next" button
                next_edit.Click();

                //click on "Next" on Liabilities details page
                next_Liab.Click();

                //submit the editing
                submit.Click();               
            }

            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail,"Test Failed", e.Message);
            }


        }

        public void RemoveTenantAndValidate()
        {
            try
            {
                //enter Owners->Properties page
                EnterOwnersPropertiesPage();

                //click on the dropdown menu of the first property record
                menuBtn.Click();

                Thread.Sleep(1000);

                //choose "Management Tenant" from the dropdown menu
                tenantManagementTab.Click();

                //click on "Remove" button on Management Tenant page
                remove.Click();

                //click on "Confirm" button on Management Tenant page
                confirm.Click();


                string ExpectedValue = "mm No Tenants for this Property";
                //No Tenants for this Property
                string ActualValue = Driver.driver.FindElement(By.XPath("//p[contains(.,' No Tenants for this Property')]")).Text;

                //Console.WriteLine();
                if (ExpectedValue == ActualValue)

                   Base.test.Log(LogStatus.Pass,"Test Passed, Tenant removed successfully");

                else
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, Tenant not removed successfully");
                //Assert.AreNotEqual(ExpectedValue, ActualValue, "Test Passed, Tenant not removed successfully");
                Assert.AreEqual(ExpectedValue, ActualValue, "Test Failed");
                          
            }

            catch(Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Test Failed, Tenant Manage Unsuccessfull",e.Message);
            }

            
        }


        //open Owners>Properties home page
        public void EnterOwnersPropertiesPage()
        {
            //maximize the window
            Driver.driver.Manage().Window.Maximize();

            skip.Click();
            //Driver.WaitForElement(Driver.driver,By.XPath("/html/body/div[1]/div/div[2]/div[1]"),20);
            //Driver.wait(500);
            Thread.Sleep(1000);
            Owners.Click();

            Properties.Click();            
        }

        //Enter valid Property Details data
        public void EnterPropertyDetails()
        {
            //open Add New Property page
            addNewProperty.Click();

            //import the sheet including property details
            ExcelLib.PopulateInCollection(Base.ExcelPath, "PropertyDetails");

            //enter data into the following input boxes

            //write data to PropertyName from input data sheet
            propertyName.SendKeys(ExcelLib.ReadData(2, "propertyName"));
            //propertyName.SendKeys("House1 for testing");

            Driver.wait(2);

            //write data to searchAddress from input data sheet
            searchAddress.SendKeys(ExcelLib.ReadData(2, "searchAddress"));
            
            Thread.Sleep(2000);
            searchAddress.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            searchAddress.SendKeys(OpenQA.Selenium.Keys.Enter);

            //write data to searchAddress from input data sheet
            description.SendKeys(ExcelLib.ReadData(2, "description"));

            //write data to yearBuilt from input data sheet
            yearBuilt.SendKeys(ExcelLib.ReadData(2, "yearBuilt"));

            //write data to targetRent from input data sheet
            targetRent.SendKeys(ExcelLib.ReadData(2, "targetRent"));

            //write data to bedroomsNumber from input data sheet
            bedroomsNumber.SendKeys(ExcelLib.ReadData(2, "bedroomsNumber"));

            //write data to bathroomsNumber from input data sheet
            bathroomsNumber.SendKeys(ExcelLib.ReadData(2, "bathroomsNumber"));
            //Thread.Sleep(1000);

            //write data to carparks from input data sheet
            carparks.SendKeys(ExcelLib.ReadData(2, "carparks"));            

            //scrolling down the page
            Driver.wait(5);
            IJavaScriptExecutor Js = Driver.driver as IJavaScriptExecutor;
            Driver.wait(2);
            Js.ExecuteScript("window.scrollBy(0,500);");
            Driver.wait(9);

            //click the picture area to make sure next button to be visible
            picture.Click();

            //click on next button
            nextButton .Click();
            
        }

        //Enter valid Financial Details data
        public void EnterFinancialDetails()
        {
            //choose the "FinancialDetails" sheet to input data
            ExcelLib.PopulateInCollection(Base.ExcelPath, "FinancialDetails");

            //write purchasePrice data from "FinancialDetails" sheet
            purchasePrice.SendKeys(ExcelLib.ReadData(2, "purchasePrice"));

            //write mortgagePrice data from "FinancialDetails" sheet
            mortgagePrice.SendKeys(ExcelLib.ReadData(2, "mortgagePrice"));

            //write homeValue data from "FinancialDetails" sheet
            homeValue.SendKeys(ExcelLib.ReadData(2, "homeValue"));

            //choose "current" as the home value type
            homeValueTypeDLL.Click();
            homeValueType_C.Click();

            //chick on the next button on FinancialDetails page
            nextBtn_FD.Click();
        }

        //Enter valid Tenant Details data
        public void EnterTenantDetails()
        {
            //choose the "TenantDetails" sheet to input data
            ExcelLib.PopulateInCollection(Base.ExcelPath, "TenantDetails");

            //write tenantEmail data from "TenantDetails" sheet
            tenantEmail.SendKeys(ExcelLib.ReadData(2, "tenantEmail"));

            //write firstName data from "TenantDetails" sheet
            firstName.SendKeys(ExcelLib.ReadData(2, "firstName"));

            //write lastName data from "TenantDetails" sheet
            lastName.SendKeys(ExcelLib.ReadData(2, "lastName"));

            //write startDate data from "TenantDetails" sheet
            startDate.SendKeys(ExcelLib.ReadData(2, "startDate"));

            //write endDate data from "TenantDetails" sheet
            endDate.SendKeys(ExcelLib.ReadData(2, "endDate"));

            //write rentAmount data from "TenantDetails" sheet
            rentAmount.SendKeys(ExcelLib.ReadData(2, "rentAmount"));

            //write paymentStartDate data from "TenantDetails" sheet
            paymentStartDate.SendKeys(ExcelLib.ReadData(2, "paymentStartDate"));

            Driver.wait(2);

            //click on save button
            saveBtn.Click();
        }

        //validate if add the new property seccussfully
        public void ValidateAddNewProperty()
        {
            try
            {
                // Screenshot
                String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "FinalScreenshot");
                Base.test.Log(LogStatus.Info, "FinalScreenshot: " + img);


                //open the "PropertyDetails" sheet
                ExcelLib.PopulateInCollection(Base.ExcelPath, "PropertyDetails");

                //name1=name of the property which has just been added.
                var name1 = ExcelLib.ReadData(2, "propertyName");
                Thread.Sleep(2000);

                //name2=name of the property which is the first property displayed on the Owners>Properties page
                var name2 = Driver.driver.FindElement(By.XPath(".//*[@id='main-content']/section/div[1]/div[1]/div[4]/div[1]/div/div/div[2]/div[2]/div[1]/div[1]/div[1]")).Text;

                //Console.WriteLine(name1);
                //Console.WriteLine(name2);

                //if (name1 == name2)

                //    //Console.WriteLine("test pass");
                //    Base.test.Log(LogStatus.Pass, "ValidateAddNewProperty is Passed");
                //else
                //    Base.test.Log(LogStatus.Fail, "ValidateAddNewProperty is Failed");

                string actualvalue = Driver.driver.FindElement(By.XPath(".//*[@id='main-content']/section/div[1]/div[1]/div[4]/div[1]/div/div/div[2]/div[2]/div[1]/div[1]/div[1]")).Text;
                Assert.Equals(actualvalue,  "propertyName");
           //      Assert.IsTrue(actualvalue.Contains("Post published1."), actualvalue + " doesn't contains 'Post published1.'");
                Base.test.Log(LogStatus.Pass, "ValidateAddNewProperty is Passed");
                Assert.Fail(actualvalue, ExcelLib.ReadData(2, "propertyName"), "ValidateAddNewProperty is Passed");
                  

            }

            catch (Exception e)
            {

                //Console.WriteLine("test failed");         
                Base.test.Log(LogStatus.Fail, "ValidateAddNewProperty is Failed",e.Message);
            }
        }

        //Add a new property with valid data and validate if add it successfully
        public void AddNewPropertyAndValidate()
        {
            try
            {
                EnterOwnersPropertiesPage();
                EnterPropertyDetails();
                EnterFinancialDetails();
                EnterTenantDetails();

                //OwnersPropertiesPage();

                // Screenshot
                String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "FinalScreenshot");
                Base.test.Log(LogStatus.Info, "FinalScreenshot: " + img);


                //open the "PropertyDetails" sheet
                ExcelLib.PopulateInCollection(Base.ExcelPath, "PropertyDetails");

                //name1=name of the property which has just been added.
                var name1 = ExcelLib.ReadData(2, "propertyName");
                Thread.Sleep(2000);

                //name2=name of the property which is the first property displayed on the Owners>Properties page
                var name2 = Driver.driver.FindElement(By.XPath(".//*[@id='main-content']/section/div[1]/div[1]/div[4]/div[1]/div/div/div[2]/div[2]/div[1]/div[1]/div[1]")).Text;

                //Console.WriteLine(name1);
                //Console.WriteLine(name2);

                //if (name1 == name2)

                //    //Console.WriteLine("test pass");
                //    Base.test.Log(LogStatus.Pass, "ValidateAddNewProperty is Passed");

                string actualvalue = Driver.driver.FindElement(By.XPath(".//*[@id='main-content']/section/div[1]/div[1]/div[4]/div[1]/div/div/div[2]/div[2]/div[1]/div[1]/div[1]")).Text;
                Assert.Equals(actualvalue, ExcelLib.ReadData(2, "propertyName"));

                try
                {
                    Assert.AreEqual(name1, name2);
                    Base.test.Log(LogStatus.Pass, "ValidateAddNewProperty is Passed");
                }
                catch(AssertionException assEx)
                {
                    Base.test.Log(LogStatus.Fail, "ValidateAddNewProperty is Failed", assEx.Message);
                }

                Console.WriteLine(name2);


                Base.test.Log(LogStatus.Pass, "ValidateAddNewProperty is Passed");
                //Assert.Fail(actualvalue, ExcelLib.ReadData(2, "propertyName"), "ValidateAddNewProperty is Passed");

               
            }

            catch(Exception e)
            {
                Base.test.Log(LogStatus.Fail, "ValidateAddNewProperty is Failed",e.Message);
            }
        }

        //Check if can new a property with invalid data
        public void AddATenantAndValidate()
        {
            EnterOwnersPropertiesPage();
            addTenant.Click();
            
            previousBtn_FD.Click();
            propertyName.Clear();
            propertyName.SendKeys("IV");
            var message = messageUnderPropertyName.Text;
            var errorMessage = "The Property Name field must be between 4-30 alphanumeric characters.";
            if(message==errorMessage)
                Base.test.Log(LogStatus.Pass, "error message test is Passed");
            else
                Base.test.Log(LogStatus.Pass, "error message test is Failed");

            propertyName.Clear();
            propertyName.SendKeys("correct name");
            nextButton.Click();


        }

        public void GoPreviousAndModify()
        {
            EnterOwnersPropertiesPage();
            EnterPropertyDetails();
            previousBtn_FD.Click();
            description.Clear();
            description.SendKeys("modify the description");
            nextButton.Click();
            EnterFinancialDetails();
            EnterTenantDetails();
            ValidateAddNewProperty();

        }

        public void AddAnExistingPropertyAndValidate()
        {
            //open Add New Property page
            addNewProperty.Click();

            //import the sheet including property details
            ExcelLib.PopulateInCollection(Base.ExcelPath, "PropertyDetails");

            //enter an existing property name PropertyName from input data sheet
            propertyName.SendKeys(ExcelLib.ReadData(2, "propertyName"));
            //propertyName.SendKeys("eee");

            Driver.wait(2);
           
            //get the error message reminder from under Property Name
            var actualMessage = Driver.driver.FindElement(By.XPath(".//*[@id='property-details']/div[1]/div[1]/div/span")).Text;
            string errorMessage = "exising property";
            //string errorMessage = "The Property Name field must be between 4-30 alphanumeric characters.";
            if (actualMessage== errorMessage)
                Base.test.Log(LogStatus.Pass, "AddAnExistingPropertyAndValidate is Passed");
            else
                Base.test.Log(LogStatus.Fail, "AddAnExistingPropertyAndValidate is Failed");

            // Screenshot
            String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "FinalScreenshot");
            Base.test.Log(LogStatus.Info, "FinalScreenshot: " + img);
        }

        public void AddAnInvalidPropertyAndValidate()
        {
            //open Add New Property page
            addNewProperty.Click();

            //import the sheet including property details
            ExcelLib.PopulateInCollection(Base.ExcelPath, "PropertyDetails");

            //enter an existing property name PropertyName from input data sheet
            //propertyName.SendKeys(ExcelLib.ReadData(2, "propertyName"));//this code is for existing property case
            propertyName.SendKeys("eee");//invalid data which is less than 4 characters for property name

            Driver.wait(2);

            //get the error message reminder from under Property Name
            var actualMessage = Driver.driver.FindElement(By.XPath(".//*[@id='property-details']/div[1]/div[1]/div/span")).Text;

            //string errorMessage = "exising property";//this code is for existing property case

            string errorMessage = "The Property Name field must be between 4-30 alphanumeric characters.";
            if (actualMessage == errorMessage)
                Base.test.Log(LogStatus.Pass, "AddAnExistingPropertyAndValidate is Passed");
            else
                Base.test.Log(LogStatus.Fail, "AddAnExistingPropertyAndValidate is Failed");

            // Screenshot
            String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "FinalScreenshot");
            Base.test.Log(LogStatus.Info, "FinalScreenshot: " + img);
        }


        public void UploadFile()
        {
            //upload the picture
            chooseFile.SendKeys(@"C:\Users\zhaoxia\Pictures\DR Harker.PNG");
            
        }


    }
}
