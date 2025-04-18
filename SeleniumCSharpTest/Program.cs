﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of Chrome driver
            using (IWebDriver browser = new ChromeDriver())
            {
                try
                {

                    browser.Navigate().GoToUrl("http://app.cloudqa.io/home/AutomationPracticeForm");

          
                    var wait = new WebDriverWait(browser, TimeSpan.FromSeconds(20));

                    // Locate the input field for the first name based on its  label.
                    // The XPath finds a label containing "First Name", then selects the first input element following it.
                    IWebElement firstNameInput = wait.Until(dr => 
                        dr.FindElement(By.XPath("//label[contains(text(), 'First Name')]/following::input[1]"))
                    );
                    firstNameInput.Clear();
                    firstNameInput.SendKeys("Saad");

                    // For the last name field  search for the label Last Name and get its  input element.
                    IWebElement lastNameInput = browser.FindElement(By.XPath("//label[contains(text(), 'Last Name')]/following::input[1]"));
                    lastNameInput.Clear();
                    lastNameInput.SendKeys("Khan");

                    // Do the same for the email field – find the label Email then its input.
                    IWebElement emailInput = browser.FindElement(By.XPath("//label[contains(text(), 'Email')]/following::input[1]"));
                    emailInput.Clear();
                    emailInput.SendKeys("saadkhan@gmail.com");

                    Console.WriteLine("Input fields have been filled out successfully.");

                    System.Threading.Thread.Sleep(3000);
                }
                catch (WebDriverTimeoutException e)
                {
                    Console.WriteLine("Timeout reached while waiting for an element: " + e.Message);
                }
                catch (NoSuchElementException e)
                {
                    Console.WriteLine("Could not locate an expected element: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected error: " + e.Message);
                }
                finally
                {
                    browser.Quit();
                }
            }
        }
    }
}
