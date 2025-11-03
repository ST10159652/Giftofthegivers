using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourApi.Tests
{
    internal class DonationServiceTests
    {
        private DonationServiceTests _service;

        [TestInitialize]
        public void Setup() => _service = new DonationServiceTests();

        [TestMethod]
        public void CalculateTotal_ShouldReturnCorrectSum()
        {
            var result = _service.CalculateTotal(10, 5);
            object Assert = null;

            
        }

        

       
        

        private object CalculateTotal(int v1, int v2) => throw new NotImplementedException();

        [TestMethod]

        public void CalculateTotal_NegativeValues_ShouldThrowException() => _service.CalculateTotal(-1, 5);

        internal object? CalculateTotal(int a, int b)
        {
            throw new NotImplementedException();
        }
    }

    internal class ExpectedExceptionAttribute : Attribute
    {
    }

    internal class TestMethodAttribute : Attribute
    {
    }

    internal class TestInitializeAttribute : Attribute
    {
    }
}
