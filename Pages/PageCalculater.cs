using Automation.Base;
using Xunit;


namespace Automation.Pages
{
    public class PageCalculater : WebBase
    {
        public string LinkCalcApp = "//a[@id='calculatetest']";
        public string BtnCalculate = "//input[@id='calculate']";
        public string InputNum1 = "//input[@id='number1']";
        public string InputNum2 = "//input[@id='number2']";
        public string SelectCalcOp = "//select[@id='function']";
        public string TextAnswer = "//span[@id='answer']";

        public void OpenCalculatorPage()
        {

            ClickElement(LinkCalcApp);
            WaitForElementToBeVisible(BtnCalculate);
        }

        public void WriteNumbers(int num1, int num2)
        {
            TypeToElement(InputNum1, num1.ToString());
            TypeToElement(InputNum2, num2.ToString());
        }

        public void SelectCalculateOperation(string opName)
        {
            SelectDropboxByVisibleText(SelectCalcOp, opName);
        }

        public void ClickCalculateButton()
        {
            ClickElement(BtnCalculate);
        }

        public void ResultShouldBe(string expectedResult)
        {
            string actualResult = GetElementText(TextAnswer);
            Assert.Equal(expectedResult, actualResult);
        }


    }
}
