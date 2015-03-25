using CAlgo.Specification;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CAlgoHub.Specification.Tests
{
    [TestClass]
    public class OperatorsTests
    {
        [TestMethod]
        public void VerifyLogicalAndOperatorReturnsAndSpecification()
        {
            var expr1 = new ExpressionSpecification<object>(o => true);
            var expr2 = new ExpressionSpecification<object>(o => true);

            Assert.IsInstanceOfType(expr1 & expr2, typeof (AndSpecification<object>));
        }

        [TestMethod]
        public void VerifyLogicalOrOperatorReturnsOrSpecification()
        {
            var expr1 = new ExpressionSpecification<object>(o => true);
            var expr2 = new ExpressionSpecification<object>(o => true);

            Assert.IsInstanceOfType(expr1 | expr2, typeof (OrSpecification<object>));
        }
    }
}