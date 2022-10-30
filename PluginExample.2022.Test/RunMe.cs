using Moq;
using PluginExample._2022.Interfaces;
using PluginExample.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginExample._2022.Test
{
    public class RunMe
    {
        [Test]
        public void TestRunMe()
        {
            // This will run with the original CoreLogic object
            ICalculator calculator = new CalculatorWithExternalDependency();

            // Returns "Original Core Logic object"
            Console.WriteLine(calculator.WhoAmI());
            Assert.That(calculator.WhoAmI(), Is.EqualTo("Original Core Logic Object"));

            // Here we create a mock object for CoreLogic and inject it using Dependency Injection
            // This gives us complete control over the returning value from CoreLogic
            var mockCoreLogic = new Mock<ICoreLogic>();
            mockCoreLogic.Setup(mcl => mcl.GetName())
                .Returns("Mock Core Logic Object");

            // Now the calculator will use our test object instead of the original client
            ICalculator calculatorWithMockCore = new CalculatorWithExternalDependency(mockCoreLogic.Object);

            // Returns "Mock Core Logic Object"
            Console.WriteLine(calculatorWithMockCore.WhoAmI());
            Assert.That(calculatorWithMockCore.WhoAmI(), Is.EqualTo("Mock Core Logic Object"));

        }
    }
}
