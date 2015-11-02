namespace Calculator
{
    #region Class Calc --------------------------------------------------------
    /// <summary>
    /// Class modeling a set of calculation methods.
    /// </summary>
    public static class Calc
    {
        #region Methods -------------------------------------------------------
        /// <summary>
        /// Add : Method that allows the addition of two integers
        /// </summary>
        /// <param name="op1">First operand</param>
        /// <param name="op2">Second operand</param>
        /// <returns>Returns the sum of the two operands parameters</returns>
        public static int Add(int op1, int op2)
        {
            return op1 + op2;
        }
        #endregion
    }
    #endregion
}
