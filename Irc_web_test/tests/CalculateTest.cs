using NUnit.Framework;

namespace WebIrcTests
{
    [TestFixture]
    public class CalculateTests:TestBase
    {
        

        [Test]
        public void CalculateTest()
        {
            app.Calculate.NewCalculate(new AwbData ("7281956765"));
        }


    }
}
