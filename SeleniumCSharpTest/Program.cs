// using System;
// using OpenQA.Selenium;
// using OpenQA.Selenium.Chrome;
// using OpenQA.Selenium.Support.UI;

// namespace SeleniumCSharpTest
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create an instance of ChromeDriver using a "using" block so it closes automatically
//             using (IWebDriver driver = new ChromeDriver())
//             {
//                 try
//                 {
//                     // Navigate to the automation practice form
//                     driver.Navigate().GoToUrl("http://app.cloudqa.io/home/AutomationPracticeForm");

//                     // Increase explicit wait timeout to allow the page elements to load
//                     WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

//                     // For First Name:
//                     // Locate the label containing "First Name" and then get the first following input element.
//                     IWebElement firstNameField = wait.Until(d => 
//                         d.FindElement(By.XPath("//label[contains(text(),'First Name')]/following::input[1]"))
//                     );
//                     firstNameField.Clear();
//                     firstNameField.SendKeys("John");

//                     // For Last Name:
//                     // Locate the label containing "Last Name" and then get the first following input element.
//                     IWebElement lastNameField = driver.FindElement(By.XPath("//label[contains(text(),'Last Name')]/following::input[1]"));
//                     lastNameField.Clear();
//                     lastNameField.SendKeys("Doe");

//                     // For Email:
//                     // Locate the label containing "Email" and then get the first following input element.
//                     IWebElement emailField = driver.FindElement(By.XPath("//label[contains(text(),'Email')]/following::input[1]"));
//                     emailField.Clear();
//                     emailField.SendKeys("john.doe@example.com");

//                     Console.WriteLine("All fields updated successfully!");

//                     // Optionally pause for a few seconds to view the result before closing the browser
//                     System.Threading.Thread.Sleep(3000);
//                 }
//                 catch (WebDriverTimeoutException ex)
//                 {
//                     Console.WriteLine("Element was not found within the timeout: " + ex.Message);
//                 }
//                 catch (NoSuchElementException ex)
//                 {
//                     Console.WriteLine("An element was not found: " + ex.Message);
//                 }
//                 catch (Exception ex)
//                 {
//                     Console.WriteLine("An error occurred: " + ex.Message);
//                 }
//                 finally
//                 {
//                     // Close the browser and end the session.
//                     driver.Quit();
//                 }
//             }
//         }
//     }
// }
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Chrome driver.
            using (IWebDriver browser = new ChromeDriver())
            {
                try
                {
                    // Open the automation practice form page.
                    browser.Navigate().GoToUrl("http://app.cloudqa.io/home/AutomationPracticeForm");

                    // Use an explicit wait to allow the page to fully load.
                    var wait = new WebDriverWait(browser, TimeSpan.FromSeconds(20));

                    // Locate the input field for the first name based on its accompanying label.
                    // The XPath finds a label containing "First Name", then selects the first input element following it.
                    IWebElement firstNameInput = wait.Until(dr => 
                        dr.FindElement(By.XPath("//label[contains(text(), 'First Name')]/following::input[1]"))
                    );
                    firstNameInput.Clear();
                    firstNameInput.SendKeys("John");

                    // For the last name field, search for the label "Last Name" and get its subsequent input element.
                    IWebElement lastNameInput = browser.FindElement(By.XPath("//label[contains(text(), 'Last Name')]/following::input[1]"));
                    lastNameInput.Clear();
                    lastNameInput.SendKeys("Doe");

                    // Do the same for the email field – find the label "Email" then its input.
                    IWebElement emailInput = browser.FindElement(By.XPath("//label[contains(text(), 'Email')]/following::input[1]"));
                    emailInput.Clear();
                    emailInput.SendKeys("john.doe@example.com");

                    Console.WriteLine("Input fields have been filled out successfully.");

                    // Pause briefly to observe the filled-out form (optional)
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
                    // Shut down the browser instance.
                    browser.Quit();
                }
            }
        }
    }
}
