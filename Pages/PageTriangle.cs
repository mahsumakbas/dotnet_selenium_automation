using Automation.Base;
using Xunit;

namespace Automation.Pages
{
    public class PageTriangle : WebBase
    {
        public string LinkTriangleApp = "//a[@id='triangleapp']";
        public string BtnIdentifyType = "//button[@id='identify-triangle-action']";
        public string InputSide1 = "//input[@id='side1']";
        public string InputSide2 = "//input[@id='side2']";
        public string InputSide3 = "//input[@id='side3']";
        public string TextResult = "//p[@id='triangle-type']";
        public void OpenCalculatorPage()
        {

            ClickElement(LinkTriangleApp);
            WaitForElementToBeVisible(BtnIdentifyType);
        }

        public void WriteSideOne(int num)
        {
            TypeToElement(InputSide1, num.ToString());
        }

        public void WriteSideTwo(int num)
        {
            TypeToElement(InputSide2, num.ToString());
        }

        public void WriteSideThree(int num)
        {
            TypeToElement(InputSide3, num.ToString());
        }

        public void ClickIdentifyButton()
        {
            ClickElement(BtnIdentifyType);
        }

        public void ResultShouldBe(string expectedResult)
        {
            string actualResult = GetElementText(TextResult);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
