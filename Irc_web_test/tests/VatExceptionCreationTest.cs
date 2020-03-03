using System;
using System.Collections.Generic;
using NUnit.Framework;
using Gurock.TestRail;
using Newtonsoft.Json.Linq;

namespace WebIrcTests
{
    [TestFixture]
    public class VatExceptionCreationTests:TestBase
    {
       
        [Test]
        public void VatExceptionCreationWidhValidDataTest()
        {
            AddNewProjectInTestRail();
           // AddTestCaseInProject();



            VatAccountData account = new VatAccountData("123456780");
            account.Account20 = "123456710";

            List<VatAccountData> oldAccounts = app.VatException.GetAccountList();

            app.VatException.Create(account);
            List<VatAccountData> newAccounts = app.VatException.GetAccountList();
            //if (oldAccounts.Count + 1 != newAccounts.Count)
            //{
            //    AddFailResultInTestRail();
            //}
            //else
            //{
            //    AddPassResultInTestRail();
            //}


            Assert.AreEqual(oldAccounts.Count + 1, newAccounts.Count);
            oldAccounts.Add(account);
            oldAccounts.Sort();
            newAccounts.Sort();
            Assert.AreEqual(oldAccounts, newAccounts);



        }



        //[Test]

        //public void VatExceptionCreationWidhInvalidDataTest()
        //{
        //    VatAccountData account = new VatAccountData("111111111");
        //    account.Account20 = "111111111";

        //    List<VatAccountData> oldAccounts = app.VatException.GetAccountList();

        //    app.VatException.Create(account);
        //    List<VatAccountData> newAccounts = app.VatException.GetAccountList();
        //    //if (oldAccounts.Count + 1 != newAccounts.Count)
        //    //{
        //    //    app.VatException.AddFailResultInTestRail();
        //    //}
        //    //else
        //    //{
        //    //    app.VatException.AddPassResultInTestRail();
        //    //}


        //    Assert.AreEqual(oldAccounts.Count + 1, newAccounts.Count);
        //    oldAccounts.Add(account);
        //    oldAccounts.Sort();
        //    newAccounts.Sort();
        //    Assert.AreEqual(oldAccounts, newAccounts);

        //}


        //private void AddFailResultInTestRail()
        //{
        //    APIClient client = new APIClient("https://dhlru.testrail.io/");
        //    client.User = "Vyacheslav.Kozhurov@dhl.ru";
        //    client.Password = "1xVixA7Ug7q4Ys1di36M";
        //    //JObject c = (JObject)client.SendGet("get_case/2618");
        //    //Console.WriteLine(c["title"]);
        //    var data = new Dictionary<string, object>
        //    {
        //        {"status_id", "5" },
        //        {"comment", "Не УРА" }
        //    };
        //    client.SendPost("add_result_for_case/294/2618", data);

        //}

        //public void AddPassResultInTestRail()
        //{
        //    APIClient client = new APIClient("https://dhlru.testrail.io/");
        //    client.User = "Vyacheslav.Kozhurov@dhl.ru";
        //    client.Password = "1xVixA7Ug7q4Ys1di36M";
        //    JObject c = (JObject)client.SendGet("get_case/2618");
        //    //Console.WriteLine(c["title"]);
        //    var data = new Dictionary<string, object>
        //    {
        //        {"status_id", "1" },
        //        {"comment", "УРА" }
        //    };
        //    client.SendPost("add_result_for_case/294/2618", data);
        //}

        public void AddNewProjectInTestRail()
        {
            APIClient client = new APIClient("https://dhlru.testrail.io/");
            client.User = "Vyacheslav.Kozhurov@dhl.ru";
            client.Password = "1xVixA7Ug7q4Ys1di36M";
            //JObject c = (JObject)client.SendGet("get_case/2618");
            //Console.WriteLine(c["title"]);
            var data = new Dictionary<string, object>
            {
                {"name", "This is a new project1" },
                {"announcement", "This is the description for the project" },
                { "show_announcement",true},
                { "suite_mode", "1"}
            };
            JObject r = (JObject)client.SendPost("add_project", data);
            var project_id = r.GetValue("id");
            //Console.WriteLine(r);
            // Console.WriteLine(project_id);

            var add_section = new Dictionary<string, object>
            {
                {"name", "This is a new section" },
            };

            JObject section = (JObject)client.SendPost("add_section/" + project_id, add_section);
            var section_id = section.GetValue("id");
            Console.WriteLine(section_id);

            var add_test_case = new Dictionary<string, object>
            {
                {"title","First test case" },
                {"template_id", 2 },
                {"type_id","6" },
                {"priority_id", 3 },
                {"estimate", "30s" },
                { "refs", "KK-1065"}
            };

            JObject test_case = (JObject)client.SendPost("add_case/" + section_id, add_test_case);
            Console.WriteLine(test_case);


        }

        //private void AddTestCaseInProject()
        //{
        //    APIClient client = new APIClient("https://dhlru.testrail.io/");
        //    client.User = "Vyacheslav.Kozhurov@dhl.ru";
        //    client.Password = "1xVixA7Ug7q4Ys1di36M";
        //    var add_section = new Dictionary<string, object>
        //    {
        //        {"name", "This is a new section" },
        //    };

        //    JObject section = (JObject)client.SendPost("add_section/57", add_section);
        //    Console.WriteLine(add_section);

        //    var add_test_case = new Dictionary<string, object>
        //    {
        //        {"title","First test case" },
        //        {"template_id", 2 },
        //        {"type_id","6" },
        //        {"priority_id", 3 },
        //        {"estimate", "30s" },
        //        { "refs", "KK-1065"}
        //    };

        //    JObject test_case = (JObject)client.SendPost("add_case/510", add_test_case);
        //    Console.WriteLine(test_case);



        //}


    }


}
