using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoanCalculator.Business.ViewModels.General;

namespace LoanCalculator.API.Controllers.Tests
{
    [TestClass()]
    public class LoanControllerTest
    {
        private LoanController _controller;

        public LoanControllerTest()
        {
            _controller = new LoanController();
        }


        [TestMethod()]
        public void CalculateLvrSuccessTest()
        {
            double propertyValue = 1000000;
            double amount = 900000;
            double result = 90;
            var response = _controller.CalculateLvr(propertyValue, amount).Result as ResponseDetail<double>;

            Assert.AreEqual(response.Data, result);
        }

        [TestMethod()]
        public void CalculateLvrFailTest()
        {
            double propertyValue = 1000000;
            double amount = 90000;
            double result = 90;
            var response = _controller.CalculateLvr(propertyValue, amount).Result as ResponseDetail<double>;

            Assert.AreNotEqual(response.Data, result);
        }
    }
}