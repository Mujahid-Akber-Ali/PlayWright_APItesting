using Microsoft.CodeAnalysis;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using PlayWright_APItesting;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Xml.Linq;

namespace PlayWright_APItesting
{
    [TestClass]
    public class APITest : PlaywrightTest
    {
        private IAPIRequestContext Request = null;
        API api = new API();

        [TestInitialize]
        public void TestInit()
        {
            api.Playwright = Playwright;
        }

        [TestMethod]
        public async Task GET_TC()
        {
            var getResponse = await api.GETRequest(@"http://localhost:3000/employees");
        }

        [TestMethod]
        public async Task GET_TC_01()
        {
            var getResponse = await api.GETRequest(@"http://localhost:3000/employees","name", "Pankaj");
        }

        [TestMethod]
        public async Task POST_TC_01()
        {
            var data = new Dictionary<string, string>();
            data.Add("id", "7");
            data.Add("name", "Samjah shayad agia hai...");
            data.Add("salary", "3");

            var getResponse = await api.POSTResponse(@"http://localhost:3000/employees", data);
        }

        [TestMethod]
        public async Task PUT_TC_01()
        {
            var data = new Dictionary<string, string>();
            data.Add("id", "10");
            data.Add("name", "Smajah agia");
            data.Add("salary", "2");

            var getResponse = await api.PUTResponse(@"http://localhost:3000/employees/10", data);
        }

        [TestMethod]
        public async Task PATCH_TC_01()
        {
            var data = new Dictionary<string, string>();
            data.Add("id", "1");
            data.Add("name", "My post updated");
            data.Add("salary", "2000");

            var getResponse = await api.PUTResponse(@"http://localhost:3000/employees/1", data);
        }

        [TestMethod]
        public async Task DELETE_TC_01()
        {
            var getResponse = await api.DELETEResponse(@"http://localhost:3000/employees/7");
        }


    }
}