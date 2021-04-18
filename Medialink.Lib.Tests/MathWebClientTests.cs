using MediaLink.Lib;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medialink.Lib.Tests
{

    [TestFixture]
    public class MathWebClientTests
    {
        private ILogger _logger;
        private OperationModel _operations;
        private MathWebClient _mclient;

        List<OperationModel> li;

        [SetUp]
        public void SetUp()
        {
            _operations = Substitute.For<OperationModel>();
            _logger = Substitute.For<ILogger>();
            _mclient = Substitute.For<MathWebClient>();
            //var loggerFactory = Substitute.For<ILogger>();
            //loggerFactory.CreateLogger(Arg.Any<string>()).Returns(_logger);

            //_productsController = new ProductsController(_productService, loggerFactory);
        }

        [Test]
        public void Checkdetails()
        {
            _mclient.Add(1, 2).Returns(3);
            _mclient.Multiply(1, 2).Returns(3);
            _mclient.Divide(1, 2).Returns(3);

            Assert.AreEqual(_mclient.Add(1, 2), 3);
            Assert.AreEqual(_mclient.Multiply(1, 2), 2);
            Assert.AreEqual(_mclient.Divide(2, 2), 1);

        }

        [Test]
        public void CheckLog()
        {
            OperationTest pobj = new OperationTest();
            li = pobj.AllOperations();
            foreach (var x in li)
            {
                Assert.IsNotNull(x.OperationName);
                Assert.IsNotNull(x.A);
                Assert.IsNotNull(x.B);
                Assert.IsNotNull(x.Result);
            }
        }
    }
}
