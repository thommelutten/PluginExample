using PluginExample._2022.Interfaces;
using PluginExample.Core;
using PluginExample.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginExample._2022
{
    public class CalculatorWithExternalDependency : ICalculator
    {
        private ICoreLogic _coreLogic;

        public CalculatorWithExternalDependency()
        {
            _coreLogic = new CoreLogic();
        }

        // Dependency Injection is key for easier testing
        public CalculatorWithExternalDependency(ICoreLogic coreLogic)
        {
            _coreLogic = coreLogic;
        }

        public int Add(int a, int b)
        {
            return _coreLogic.AddValues(a, b);
        }

        public string WhoAmI()
        {
            return _coreLogic.GetName();
        }
    }
}
