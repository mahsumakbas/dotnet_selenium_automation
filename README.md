# dotnet_selenium_automation
It is a Web Automation framework that written in  .Net C# and use Selenium Webdriver. Used POM structure. Using Xunit as unittest library.

It consists of several parts:
* Tests Folder: Define your test cases here. Written in Xunit format. Simply, put "[Fact]" keyword on your test method.
* Pages Folder: It is for test step definitions.
* Wrappers Folder: Instead of using Selenium function directly, used wrapper dunction and they are used in step definitions. 
You can put any other utility etc files that are not directly related with test steps

You can run tests in two methods:
* From IDE(VS Code or VS) you can use Test Explorer
* To Integrate CI/CD pipeline, use following command in terminal: <user profile>\.nuget\packages\xunit.runner.console\<xunit version>\tools\<dotnet version>\xunit.console.exe Automation.dll
You should choose appropirate values for fields between <> 

By default, parallel running is enabled by Xunit and number of threads are depends on number of Virtual CPUs. To disable parallel running, put following statement into Assembly Info file:
[assembly: CollectionBehavior(DisableTestParallelization = true)]