using Keys.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Keys.Pages
{
    class AddTenant
    {
        internal AddTenant()
        {
            PageFactory.InitElements(Driver.driver,this);
        }

        //finding items for Owners>Properties

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]")]
        private IWebElement blank { get; set; }

        // Owners 
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]")]
        private IWebElement Owners { get; set; }
        // Properties       
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]/div/a[1]")]
        private IWebElement Properties { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='main-content']/section/div[1]/div/div[3]/div/div[1]/div[2]/div[2]/div/a[1]")]
        private IWebElement addTenant { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='BasicDetail']/div/div[2]/div[1]/div/input")]
        private IWebElement tenantEmail { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='BasicDetail']/div/div[3]/div[1]/div/input")]
        private IWebElement firstName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='BasicDetail']/div/div[3]/div[2]/div/input")]
        private IWebElement lastName { get; set; }

       // [FindsBy(How = How.XPath, Using = ".//*[@id='BasicDetail']/div[4]/div[1]/div/input")]
        //private IWebElement rentStartDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='BasicDetail']/div/div[4]/div[1]/div/input")]
        private IWebElement rentStartDate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='BasicDetail']/div/div[4]/div[2]/div/input")]
        private IWebElement rentEndDate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='BasicDetail']/div/div[5]/div[1]/div/input")]
        private IWebElement rentAmount { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='BasicDetail']/div/div[5]/div[2]/div/select")]
        private IWebElement paymentFrequency { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='BasicDetail']/div/div[6]/div[1]/div/input")]
        private IWebElement paymentStartDate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='BasicDetail']/div/div[6]/div[2]/div/select")]
        private IWebElement paymentDueDate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='BasicDetail']/div/div[6]/div[2]/div/select/option[2]")]
        private IWebElement paymentDueDate2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[@data-day='08/04/2018']")]
        private IWebElement date { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='BasicDetail']/div/div[7]/div/div/input[1]")]
        private IWebElement nextBtn { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='BasicDetail']/div/div[7]/div/div/input[2]")]
        private IWebElement cancelBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LiabilityDetail']/div/div[1]/div/a")]
        private IWebElement addNewLiability { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LiabilityDetail']/div/div[1]/div/table/tbody/tr[1]/td[2]/input")]
        private IWebElement bondAmount { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LiabilityDetail']/div/div[1]/div/table/tbody/tr[1]/td[3]/input")]
        private IWebElement saveBond { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@data-bind='click:gotoSummary']")]
        private IWebElement next_Lia { get; set; }

        ////button[contains(.,'Submit')]
        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Submit')]")]
        private IWebElement submit { get; set; }

        public void AddTenantDetails()
        {
            //try
            //{
                blank.Click();

                Thread.Sleep(2000);
                //click on Owners tab
                Owners.Click();

                //click on Properties tab
                Properties.Click();

                addTenant.Click();

                ExcelLib.PopulateInCollection(Base.ExcelPath, "AddTenant");
                var rent_StartDate = ExcelLib.ReadData(2, "rentStartDate");
                //tenantEmail.SendKeys(ExcelLib.ReadData(2, "tenantEmail"));

                tenantEmail.SendKeys("tenant@qq.com");
                //firstName.SendKeys(ExcelLib.ReadData(2, "firstName"));
                //lastName.SendKeys(ExcelLib.ReadData(2, "lastName"));
                //firstName.SendKeys("dsgdg");
                //Thread.Sleep(3000);
                //lastName.SendKeys("sdfsw");

                //rentStartDate.SendKeys("05/04/2018");
                Thread.Sleep(3000);
                rentStartDate.Clear();
                Driver.wait(2);
                rentStartDate.SendKeys(ExcelLib.ReadData(2, "rentStartDate"));
                Driver.wait(2);
                rentStartDate.SendKeys(OpenQA.Selenium.Keys.Enter);
                // Driver.driver.FindElement(By.XPath("//td[@data-day='07/04/2018']")).Click();

                rentEndDate.Clear();
                Driver.wait(2);
                rentEndDate.SendKeys(ExcelLib.ReadData(2, "rentEndDate"));
                Driver.wait(2);

                rentAmount.SendKeys(ExcelLib.ReadData(2, "rentAmount"));

                paymentStartDate.Clear();
                Driver.wait(2);
                paymentStartDate.SendKeys(ExcelLib.ReadData(2, "paymentStartDate"));
                paymentStartDate.SendKeys(OpenQA.Selenium.Keys.Enter);

                Thread.Sleep(1000);
                nextBtn.Click();

                addNewLiability.Click();

                bondAmount.SendKeys(ExcelLib.ReadData(2, "bondAmount"));

                next_Lia.Click();

                submit.Click();
            //}

            //catch (Exception e)
            //{
            //    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail,e.Message);
            //}



        }

    }
}
