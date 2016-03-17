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
            myExp.Parse(exampleExp);
            var actual = myExp.firstTerm;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ExpressionHasSecondTerm() 
        {
            string exampleExp = "1+2";
            Expression myExp = new Expression();
            myExp.Parse(exampleExp);
            var actual = myExp.secondTerm;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ExpressionHasOperator()
        {
            string exampleExp = "1+2";
            Expression myExp = new Expression();
            myExp.Parse(exampleExp);
            var actual = myExp.mathOp;
            char expected = '+';

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ExpressionHasTwoTerms()
        {
            Expression myExp = new Expression();
            myExp.Parse("1 + 3");
            var actual = myExp.parts.Length;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException (typeof(IndexOutOfRangeException))]
        public void ExpressionIndexOutOfRange()
        {
            Expression myExp = new Expression();
            myExp.Parse("1 + 2 + 4");
        }
        #region NegativeTermTest
        /*[TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpressionHasNegativeTerms()
        {
            Expression myExp = new Expression();
            myExp.Parse("-1 + -5");
        }*/ 
        #endregion

        [TestMethod]
        public void EvaluateAdditionTest()
        {
            Expression myExp = new Expression();
            Evaluate Eval = new Evaluate();
            var ex = myExp.Parse("5 + 1");
            string actual = Eval.EvaluateFirst(ex);
            string expected = "6";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EvaluateSubtractionTest()
        {
            Expression myExp = new Expression();
            Evaluate Eval = new Evaluate();
            var ex = myExp.Parse("5 - 1");
            string actual = Eval.EvaluateFirst(ex);
            string expected = "4";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EvaluateMultiplicationTest()
        {
            Expression myExp = new Expression();
            Evaluate Eval = new Evaluate();
            var ex = myExp.Parse("5 * 1");
            string actual = Eval.EvaluateFirst(ex);
            string expected = "5";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EvaluateDivisionTest()
        {
            Expression myExp = new Expression();
            Evaluate Eval = new Evaluate();
            var ex = myExp.Parse("6 / 2");
            string actual = Eval.EvaluateFirst(ex);
            string expected = "3";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EvaluateModulosTest()
        {
            Expression myExp = new Expression();
            Evaluate Eval = new Evaluate();
            var ex = myExp.Parse("5 % 2");
            string actual = Eval.EvaluateFirst(ex);
            string expected = "1";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EvalStackLastAnswer()
        {
            Expression myExp = new Expression();
            Evaluate Eval = new Evaluate();
            var ex = myExp.Parse("6 * 2");
            var eqnresult = Eval.EvaluateFirst(ex);
            int actual = Eval.lastA();
            int expected = 12;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EvalStackLastQuestion()
        {
            Expression myExp = new Expression();
            Evaluate Eval = new Evaluate();
            var ex = myExp.Parse("6 * 2");
            var eqnresult = Eval.EvaluateFirst(ex);
            string actual = Eval.last();
            string expected = "6*2";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingOutputOfVariableAssignment()
        {
            Expression myExp = new Expression();
            Evaluate Eval = new Evaluate();
            var ex = myExp.Parse("x = 3");
            var actual = Eval.EvaluateFirst(ex);
            string expected = "saved 'x' as '3'";

            Assert.AreEqual(expected, actual);
        }
    }
}
