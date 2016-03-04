using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_calculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void ExpressionInitialTest()
        {
            Expression myExp = new Expression();
            Assert.IsNotNull(myExp.FirstExpression());
        }
    }
}
