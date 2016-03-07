using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_calculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void ExpressionClassIsNotNull()
        {
            Expression myExp = new Expression();
            Assert.IsNotNull(myExp);
        }
        [TestMethod]
        public void ExpressionHasFirstTerm()
        {
            string exampleExp = "1+2";
            Expression myExp = new Expression();
            myExp.FirstExpression(exampleExp);
            var actual = myExp.firstTerm;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ExpressionHasSecondTerm() 
        {
            string exampleExp = "1+2";
            Expression myExp = new Expression();
            myExp.FirstExpression(exampleExp);
            var actual = myExp.secondTerm;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ExpressionHasOperator()
        {
            string exampleExp = "1+2";
            Expression myExp = new Expression();
            myExp.FirstExpression(exampleExp);
            var actual = myExp.mathOp;
            char expected = '+';

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ExpressionHasTwoTerms()
        {
            Expression myExp = new Expression();
            myExp.FirstExpression("1 + 3");
            var actual = myExp.parts.Length;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException (typeof(IndexOutOfRangeException))]
        public void ExpressionIndexOutOfRange()
        {
            Expression myExp = new Expression();
            myExp.FirstExpression("1 + 2 + 4");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpressionHasNegativeTerms()
        {
            Expression myExp = new Expression();
            myExp.FirstExpression("-1 + -5");
        }

        [TestMethod]
        public void EvaluateAdditionTest()
        {
            Expression myExp = new Expression();
            Evaluate Eval = new Evaluate();
            var ex = myExp.FirstExpression("5 + 1");
            int actual = Eval.EvaluateFirst(ex);
            int expected = 6;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EvaluateSubtractionTest()
        {
            Expression myExp = new Expression();
            Evaluate Eval = new Evaluate();
            var ex = myExp.FirstExpression("5 - 1");
            int actual = Eval.EvaluateFirst(ex);
            int expected = 4;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EvaluateMultiplicationTest()
        {
            Expression myExp = new Expression();
            Evaluate Eval = new Evaluate();
            var ex = myExp.FirstExpression("5 * 1");
            int actual = Eval.EvaluateFirst(ex);
            int expected = 5;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EvaluateDivisionTest()
        {
            Expression myExp = new Expression();
            Evaluate Eval = new Evaluate();
            var ex = myExp.FirstExpression("6 / 2");
            int actual = Eval.EvaluateFirst(ex);
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EvaluateModulosTest()
        {
            Expression myExp = new Expression();
            Evaluate Eval = new Evaluate();
            var ex = myExp.FirstExpression("5 % 2");
            int actual = Eval.EvaluateFirst(ex);
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }
    }
}
