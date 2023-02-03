using Automation.Pages;
using Xunit;

namespace Automation.Tests
{
    public class TestTriangle : PageTriangle
    {
        [Fact]
        public void ScaleneTriangle()
        {
            OpenCalculatorPage();
            WriteSideOne(5);
            WriteSideTwo(6);
            WriteSideThree(7);
            ClickIdentifyButton();
            ResultShouldBe("Scalene");
        }

        [Fact]
        public void IsoscelesTriangle()
        {
            OpenCalculatorPage();
            WriteSideOne(6);
            WriteSideTwo(6);
            WriteSideThree(7);
            ClickIdentifyButton();
            ResultShouldBe("Isosceles");
        }

        [Fact]
        public void EquilateralTriangle()
        {
            OpenCalculatorPage();
            WriteSideOne(6);
            WriteSideTwo(6);
            WriteSideThree(6);
            ClickIdentifyButton();
            ResultShouldBe("Equilateral");
        }

        [Fact]
        public void InvalidTriangle()
        {
            OpenCalculatorPage();
            WriteSideOne(5);
            WriteSideTwo(6);
            WriteSideThree(11);
            ClickIdentifyButton();
            ResultShouldBe("Error: Not a Triangle");
        }
    }
}
