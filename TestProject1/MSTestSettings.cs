using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorApp;

[TestClass]
public class CalculatorTests
{
    private Calculator _calculator;

    [TestInitialize]
    public void Setup() => _calculator = new Calculator();

    #region Add Method Tests
    [TestMethod]
    public void Add_PositiveNumbers_ReturnsSum() => Assert.AreEqual(12, _calculator.Add(5, 7));

    [TestMethod]
    public void Add_NegativeAndPositiveNumber_ReturnsSum() => Assert.AreEqual(4, _calculator.Add(-3, 7));
    #endregion

    #region Subtract Method Tests
    [TestMethod]
    public void Subtract_PositiveNumbers_ReturnsDifference() => Assert.AreEqual(7, _calculator.Subtract(10, 3));

    [TestMethod]
    public void Subtract_NegativeAndPositiveNumber_ReturnsDifference() => Assert.AreEqual(-15, _calculator.Subtract(-10, 5));
    #endregion

    #region Multiply Method Tests
    [TestMethod]
    public void Multiply_PositiveNumbers_ReturnsProduct() => Assert.AreEqual(12, _calculator.Multiply(4, 3));

    [TestMethod]
    public void Multiply_NegativeAndPositiveNumber_ReturnsProduct() => Assert.AreEqual(-12, _calculator.Multiply(-4, 3));
    #endregion

    #region Divide Method Tests
    [TestMethod]
    public void Divide_PositiveNumbers_ReturnsQuotient() => Assert.AreEqual(5.0, _calculator.Divide(10, 2), 0.0001);

    [TestMethod]
    public void Divide_NegativeAndPositiveNumber_ReturnsQuotient() => Assert.AreEqual(-5.0, _calculator.Divide(-10, 2), 0.0001);

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void Divide_ByZero_ThrowsException() => _calculator.Divide(10, 0);
    #endregion
}
