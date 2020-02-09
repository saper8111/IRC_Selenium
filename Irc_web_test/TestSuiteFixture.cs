using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebIrcTests
{
    [SetUpFixture]

    public class TestSuiteFixture
    {
        public static ApplicationManager app;  // static - глобальное поле

        [SetUp]

        public void InitApplicationManager()
        {
            app = new ApplicationManager();

        }

        [TearDown]

        public void StopApplicationManager()
        {
            app.Stop();
        }
    }
}
