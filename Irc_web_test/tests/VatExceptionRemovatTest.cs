using System.Collections.Generic;
using NUnit.Framework;

namespace WebIrcTests
{
    [TestFixture]
    public class VatExceptionRemovatTest:TestBase
    {
        [Test]

        public void VatExceptionRemovalTest()
        {
            app.Navigation.GoToVATExceptionListPage();
            

            if (app.VatException.VatExceptionIsNotCreated())
            {
                VatAccountData newaccount = new VatAccountData("123456780");
                newaccount.Account20 = "123456710";
                app.VatException.Create(newaccount);
            }

            Assert.IsFalse(app.VatException.VatExceptionIsNotCreated());

            List<VatAccountData> oldAccount = app.VatException.GetAccountList();

            app.VatException.Remove();

            List<VatAccountData> newAccount = app.VatException.GetAccountList();

            oldAccount.RemoveAt(0);

            Assert.AreEqual(oldAccount, newAccount);




        }
        

    }
}
