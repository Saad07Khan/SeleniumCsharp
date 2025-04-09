# SeleniumCSharpTest

This C# Selenium project is designed to automatically fill out three fields—First Name, Last Name, and Email—on a practice webpage. The main idea is that the script continues to work even if the position or some properties of the HTML elements (for "First Name", "Last Name", and "Email") change.

## Overview

This project is built using:
- **.NET SDK** (for creating and running a C# console application)
- **Selenium WebDriver** (for automating browser actions)
- **ChromeDriver** (to drive tests in Google Chrome)

**Approach:**  
The script uses relative XPath locators based on label text instead of absolute positions. For example, it locates the "First Name" field by finding the label containing the text "First Name" and then selecting the first following input element. This approach will minimize breakage if the layout or hierarchical structure of the page change, as long as the relationship between the label and the input field is intact.

## Prerequisites

Before starting you should install:
- **.NET SDK:**  
  Download and install from [https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download).  
  Verify the installation by running:
  ```bash
  dotnet --version
