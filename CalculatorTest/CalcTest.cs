using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    #region Class CalculatorTest ----------------------------------------------
    /// <summary>
    /// Class modeling a series of tests on the <see cref="Calc"/> class.
    /// </summary>
    [TestClass]
    public class CalcTest
    {
        #region Methods -------------------------------------------------------
        /// <summary>
        /// <see cref="Calc.Add"/> test method.
        /// </summary>
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(Calc.Add(40, 2), 42);
        }
        #endregion
    }
    #endregion
}
