using s30422_assignment3;

namespace UnitTests
{
    public class Tests
    {
        private readonly IShape sphere = new Sphere(5);
        private readonly IShape cube = new Cube(4);
        private readonly IShape rectangle = new Rectangle(3, 4);
        private readonly IShape cylinder = new Cylinder(4, 8);

        [Test]
        public void TestSphereCalculateArea()
        {
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }
        
        [Test]
        public void TestCubeCalculateArea()
        {
            Assert.That(cube.CalculateArea(), Is.EqualTo(96).Within(0.001));
        }
        
        [Test]
        public void TestCubeCalculateVolume()
        {
            Assert.That(cube.CalculateVolume(), Is.EqualTo(64).Within(0.001));   
        }
        
        [Test]
        public void TestRectangleCalculateArea()
        {
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(12).Within(0.001));
        }
        
        [Test]
        public void TestRectangleCalculateVolume()
        {
            // 2d shape => no volume
            Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestCylinderCalculateArea()
        {
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(301.592).Within(0.001));
        }
        
        [Test]
        public void TestCylinderCalculateVolume()
        {
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(402.123).Within(0.001));
        }
    }
}