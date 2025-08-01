namespace SimpleCalculator.Test.Unit;

[TestClass]
public class InputConverterTest
{

    private readonly InputConverter _inputConverter = new InputConverter();

    [TestMethod]
    public void ConvertsValidStringInputIntoDouble()
    {
        string inputNumber = "5";
        double convertedNumber = _inputConverter.convertInputToNumeric(inputNumber);
        Assert.AreEqual(5.0, convertedNumber);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void FailsToConvertInvalidStringInputIntoDouble()
    {
        string inputNumber = "*";
        double convertedNumber = _inputConverter.convertInputToNumeric(inputNumber);
        
    }
}
