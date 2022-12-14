using AdactinHotelAppAutomationFramework.WebPageFunctions;
using NUnit.Framework;

namespace AdactinHotelAppAutomationFramework.WebTests
{
    [TestFixture]
    class MainTest
    {
        private WebFunctions webFunctions;

        [OneTimeSetUp]
        public void setUp()
        {
            webFunctions = new WebFunctions();
          
        }

        [Test]
        public void test()
        {
            webFunctions.LaunchAdactin();
            webFunctions.LoginToAdactin();
        }

    }
}
