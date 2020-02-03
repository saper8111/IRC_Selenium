using System.Threading.Tasks;
using NUnit.Framework;

namespace WebIrcTests
{
    public class TestBase
    {
        protected ApplicationManager app;
       

        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }

        

        

        

        

        

        


    }
}
