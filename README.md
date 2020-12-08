# Product-Import

-To run the application goto to Answwers > Publish and open command window and then run the following commands
1.ProductImport.exe import softwareadvice feed-products/softwareadvice.json
2.ProductImport.exe import capterra feed-products/capterra.yaml
3.Test Data is in the root of the publish folder

-To run the Tests
1. Open the solution file from the cloned repository and wait for project to load.
2.Right click on the solution in visual studio and select Run Tests.
3.View the test case code in the ProductImportTestCases project

-To view the Application code
1. Open the solution file from the cloned repository and wait for project to load.
2.View the code in the ProductImport project.
3.Starting point is program.cs file.

-Answers to the Sql Questions are in Answers > SQL Anwers

-Was it your first time writing a unit test, using a particular framework, etc?
1.No it wasn't my first time writing tests but wrote them after quite a while.

-What would you have done differently if you had had more time
1.Could have written better tests cases with mocking libraries etc.
2.A bit more decoupling of code in source provider classes.
3.Separate startup.cs 
