using s30422_assignment3_calculator;

namespace UnitTests_Calculator;

public class Tests
{
    [Test]
    public void TestAdding1()
    {
        var adder = new Calculator(1, 2, "+");
        Assert.That(adder.Execute(), Is.EqualTo(3).Within(0.0001));
    }

    [Test]
    public void TestAdding2()
    {
        var adder = new Calculator(-274.064614, -627.030780, "+");
        Assert.That(adder.Execute(), Is.EqualTo(-901.095394).Within(0.0001));
    }
    
    [Test]
    public void TestInterchangableAdding()
    {
        var adder1 = new Calculator(1, 2, "+");
        var adder2 = new Calculator(2, 1, "+");
        Assert.That(adder2.Execute(), Is.EqualTo(adder1.Execute()));
    }

    [Test]
    public void TestSubtracting1()
    {
        var subtractor = new Calculator(3.5, 2, "-");
        Assert.That(subtractor.Execute(), Is.EqualTo(1.5).Within(0.0001));
    }

    [Test]
    public void TestSubtracting2()
    {
        var subtractor = new Calculator(65.514841, 483.249810, "-");
        Assert.That(subtractor.Execute(), Is.EqualTo(-417.734969).Within(0.0001));
    }

    [Test]
    public void TestMultiplying1()
    {
        var multiplyer = new Calculator(6.9, 6.7, "*");
        Assert.That(multiplyer.Execute(), Is.EqualTo(46.23).Within(0.0001));
    }

    [Test]
    public void TestMultiplying2()
    {
        var multiplyer = new Calculator(326.054982, 119.694638, "*");
        Assert.That(multiplyer.Execute(), Is.EqualTo(39_027.033038586516).Within(0.0001));
    }
    
    [Test]
    public void TestInterchangableMultiplying()
    {
        var multiplyer1 = new Calculator(6, 9, "*");
        var multiplyer2 = new Calculator(9, 6, "*");
        Assert.That(multiplyer2.Execute(), Is.EqualTo(multiplyer1.Execute()));
    }

    [Test]
    public void TestDividing1()
    {
        var divider = new Calculator(22, 7, "/");
        Assert.That(divider.Execute(), Is.EqualTo(3.1428).Within(0.0001));
    }

    [Test]
    public void TestDividing2()
    {
        var divider = new Calculator(-430.212082, -281.542395, "/");
        Assert.That(divider.Execute(), Is.EqualTo(1.528054).Within(0.0001));
    }
    
    [Test]
    public void TestDividingByZero()
    {
        var dividerByZero = new Calculator(90, 0, "/");
        Assert.Throws<DivideByZeroException>(() => dividerByZero.Execute());
    }
    
    [Test]
    public void TestUnknownOperator()
    {
        var unkownOperator = new Calculator(4, 5, "something");
        Assert.Throws<ArgumentException>(() => unkownOperator.Execute());
    }
}