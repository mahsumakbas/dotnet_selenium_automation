
using Automation.Pages;
using Xunit;

namespace Automation.Tests
{
    public class TestCalculator : PageCalculater
    {
        [Fact]
        public void AdditionPositiveIntegers()
        {
            OpenCalculatorPage();
            SelectCalculateOperation("plus");
            WriteNumbers(13, 47);
            ClickCalculateButton();
            ResultShouldBe("60");
        }

        [Fact]
        public void AdditionNegativeIntegers()
        {
            OpenCalculatorPage();
            SelectCalculateOperation("plus");
            WriteNumbers(-13, -47);
            ClickCalculateButton();
            ResultShouldBe("-60");
        }

        [Fact]
        public void MultiplicationPositiveIntegers()
        {
            OpenCalculatorPage();
            SelectCalculateOperation("times");
            WriteNumbers(13, 47);
            ClickCalculateButton();
            ResultShouldBe("611");
        }

        [Fact]
        public void MultiplicationNegativeIntegers()
        {
            OpenCalculatorPage();
            SelectCalculateOperation("times");
            WriteNumbers(-13, -47);
            ClickCalculateButton();
            ResultShouldBe("611");
        }

        [Fact]
        public void SubtractionPositiveIntegers()
        {
            OpenCalculatorPage();
            SelectCalculateOperation("minus");
            WriteNumbers(47, 13);
            ClickCalculateButton();
            ResultShouldBe("34");
        }

        [Fact]
        public void SubtractionNegativeIntegers()
        {
            OpenCalculatorPage();
            SelectCalculateOperation("minus");
            WriteNumbers(-47, -13);
            ClickCalculateButton();
            ResultShouldBe("-34");
        }

        [Fact]
        public void DivisionPositiveIntegers()
        {
            OpenCalculatorPage();
            SelectCalculateOperation("divide");
            WriteNumbers(42, 6);
            ClickCalculateButton();
            ResultShouldBe("7");
        }

        [Fact]
        public void DivisionNegativeIntegers()
        {
            OpenCalculatorPage();
            SelectCalculateOperation("divide");
            WriteNumbers(-42, -6);
            ClickCalculateButton();
            ResultShouldBe("7");
        }

    }
}
