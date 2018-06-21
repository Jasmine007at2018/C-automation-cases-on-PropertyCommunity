using Keys.Global;
using Keys.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Keys.Test
{
    class Sprint_1
    {
        [TestFixture]
        [Category("Sprint_5")]
        class Sprint_1_Administration : Base
        {

            // Add a new user in the Account Managment
            [Test]
            public void Register_CreateNewUser()
            {
                // creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Register New Customer");
                Register obj = new Register();
                obj.register();

               // Console.WriteLine("Test pass");

            }

            [Test]
            public void OwnersProperties_AddNewProperty()
            {
                // creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Add New Property on Owners>Properties page");

                OwnersProperties obj = new OwnersProperties();               
                obj.AddNewProperty();

                if (Driver.driver.Title == "Properties | Add New Property")
                {
                    Console.WriteLine("Test pass");
                }
             }

            [Test]
            public void AddNewPropertyAndValidate()
            {
                // creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("AddNewPropertyAndValidate");
                //test = extent.StartTest("TestCheck");
                PropertyDetails obj = new PropertyDetails();
                obj.AddNewPropertyAndValidate();
                //obj.OwnersPropertiesPage();
                //obj.EnterPropertyDetails();
                //obj.EnterFinancialDetails();
                //obj.EnterTenantDetails();

                //obj.OwnersPropertiesPage();
                //obj.ValidateAddNewProperty();
            }

            [Test]
            public void AddNewPropertyWithExistingDataAndValidate()
            {
                // creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("AddNewPropertyWithExistingDataAndValidate");
                PropertyDetails obj = new PropertyDetails();
                obj.EnterOwnersPropertiesPage();
                obj.AddAnExistingPropertyAndValidate();
               
            }

            //Edit Tenant and Validate
            [Test]
            public void EditTenantAndValidate()
            {
                //creates a toggle for the given test, adds all log events under ir
                test = extent.StartTest("Edit Tenant and Validate");

                //create an PropertyDetails object
                PropertyDetails obj = new PropertyDetails();

                //call the method to edit tenant and validate
                obj.EditTenantAndValidate(); 
            }

            //Edit Tenant with invalid data
            [Test]
            public void EditTenantWithInvalidData()
            {
                //create a toggle for the given test, adds all log events under it
                test = extent.StartTest("Edit Tenant with invalid data");

                //create an PropertyDetails object
                PropertyDetails obj = new PropertyDetails();

                //call the method to edit tenant with invalid data
                obj.EditTenantWithInvalidData();
            }

            //Remove Tenant and Validate
            [Test]
            public void RemoveTenantAndValidate()
            {
                //creates a toggle for the given test, adds all log events under ir
                test = extent.StartTest("Remove Tenant and Validate");

                //create an PropertyDetails object
                PropertyDetails obj = new PropertyDetails();

                //call the method to remove tenant and validate
                obj.RemoveTenantAndValidate();
            }

            [Test]
            public void GoPreviousAndModifyDataAndValidate()
            {
                // creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("GoPreviousAndModifyData");
                PropertyDetails obj = new PropertyDetails();
                obj.GoPreviousAndModify();              
            }

            [Test]
            public void AddNewPropertyWithInvalidDataAndValidate()
            {
                // creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("AddNewPropertyWithInvalidDataAndValidate");
                PropertyDetails obj = new PropertyDetails();
                obj.EnterOwnersPropertiesPage();
                obj.AddAnInvalidPropertyAndValidate();
            }

                     
            [Test]
            public void AddTenant()
            {
                // creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Add Tenant");
                AddTenant obj = new AddTenant();
                obj.AddTenantDetails();
            }

            [Test]
            public void ListAsRentalAndValidate()
            {
                // creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("User can list a rental");
                ListAsRental obj = new ListAsRental();
                obj.EnterListARetalDetails();
                obj.ValidateListARetalDetails();

            }

            [Test]
            public void CheckDetailsInRentalListing()
            {
                //create a toggle for the given test, add all log events under it
                test = extent.StartTest("Check Details in Rental Listing");
                Rental_Listings_and_Tenant_Applications obj = new Rental_Listings_and_Tenant_Applications();
                obj.OpenRentListAndApp();
                obj.CheckDetails();

            }

            [Test]
            public void ListARentalFromProperty()
            {
                //create a toggle for the given test, add all log events under it
                test = extent.StartTest("List A Rental From Rental Listings and Tenant Applications");
                Rental_Listings_and_Tenant_Applications obj = new Rental_Listings_and_Tenant_Applications();

                //call method to open Owners->RentalListings&Applications page
                obj.OpenRentListAndApp();

                //call method to check if have located to Owners->RentalListings&Applications page  
                obj.CheckOwners_RLAndAppPage();

                //call method to List A Rental and validate
               
                obj.CheckListedRental(obj.ListARental());

                //call method to check if return to Owners->RentalListings&Applications page  
               // obj.CheckOwners_RLAndAppPage();


            }


        }


    }
}
