using Moq;
using PluginExample._2022.Interfaces;
using PluginExample.Core.Interfaces;

namespace PluginExample._2022.Test
{
    public class CalculatorTest
    {
        [Test]
        public void TestAdd()
        {
            // Here we create a dummy object of ICoreLogic
            var mockCoreLogic = new Mock<ICoreLogic>();
            // Here we set it up so when the method AddValues() method of our dummy object is called
            // with values 2 and 4, it returns 6
            // This way we never touch the original CoreLogic object
            mockCoreLogic.Setup(cl => cl.AddValues(
                It.Is<int>(v => v == 2),
                It.Is<int>(v => v == 4)))
                .Returns(6);
            
            // Pass in the dummy object into Calculator
            ICalculator c = new CalculatorWithExternalDependency(mockCoreLogic.Object);

            var result = c.Add(2, 4);

            Assert.That(result, Is.EqualTo(6));
        }
    }
}