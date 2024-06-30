# Miacademy Ilona Project

This repository contains the automation tests for Miacademy using NUnit. The tests are designed to ensure the functionality of the application pages.

## Project Structure

The project is organized as follows:
miacademy_ilona/
├── PageClasses/
│   ├── ApplicationPage.cs
│   ├── HomePage.cs
│   ├── OnlineSchoolPage.cs
│   └── StudentApplicationPage.cs
├── PageObjects/
│   ├── Base.cs
│   └── BasePage.cs
├── SourceShop/
│   ├── Links.cs
│   ├── Locators.cs
│   └── RandomDataGenerator.cs
├── Tests/
│   └── InitialApplicationTest.cs

## Getting Started

To get started with the project, follow these steps:

### Prerequisites

- .NET SDK
- NUnit
- A compatible IDE (e.g., Visual Studio)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/miacademy_ilona.git
   cd miacademy_ilona
   ```

2. Restore dependencies:

   ```bash
   dotnet restore
   ```

3. Build the project:

   ```bash
   dotnet build
   ```

### Running Tests

To run the tests, use the following command:

```bash
dotnet test

InitialApplicationTests

This test class contains tests for verifying the initial application form.
Test: TestInitialApplicationForm

This test verifies that the initial application form is filled out correctly and navigates to the student information page.
	•	Opens the Home Page URL.
	•	Clicks on the online high school link.
	•	Clicks the apply link on the online school page.
	•	Fills out the application form with random data.
	•	Fills out the second parent information with random data.
	•	Clicks random checkboxes.
	•	Selects a random calendar date.
	•	Clicks the next button.
	•	Verifies that the student information page is displayed.
Utilities

	•	RandomDataGenerator.cs: Generates random data for test inputs.
	•	Links.cs: Contains URL links used in the tests.
	•	Locators.cs: Contains element locators used in the page classes.

