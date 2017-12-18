# Automation Docler Holding

01) Download the project from this repository.

02) Open the code on Visual Studio either clicking on AutomationDoclerHolding.sln file or through Visual Studio, under File -> Open -> Project/Solution.

03) You'll need the Test Explorer window in order to run the test cases. To open this window, go to TEST -> Windows -> Test Exporer on Visual Studio's menu.

04) You can either run all the tests at once, clicking on the "Run All" button or select the test cases you want to run, click with the right button and click on "Run Selected Tests".

After you execute the test cases, you can check the logs on the Logs folder.

The test cases 03, 07, 11, 12, 15, 16, 19, 20, 23, 24, 27, 28 and 32 are supposed to fail. They will fail until the defects that I have opened are solved. After that, they are supposed to pass.

I created the code using the Page Object Model, having that said, the code structure is divided by Pages and Workflows. You'll find a Page class for each Page of the website, along with its own Workflow class, for example: There is a HomePage.cs file and a HomeWorkflow.cs file. The HomeWorkflow represents the workflow of the home page.

PageBase class: Each Page Class inherits from the page base. I did it this way so every page can use the buttons from the Menu without me needing to create multiple buttons.

BaseWorkflow class: The same idea from the PageBase class.

Logger Class: This is the class that I created to generate the logs of the automation.

Well. I guess that's it :) If you need further instructions, have any questions or suggestions about my code, please let me know and I'll be glad to help you out!
