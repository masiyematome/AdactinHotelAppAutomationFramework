using AdactinHotelAppAutomationFramework.WebPageFunctions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

    }
}
