using PluginExample.Core.Interfaces;

namespace PluginExample.Core
{
    public class CoreLogic : ICoreLogic
    {
        public int AddValues(int a, int b)
        {
            return a + b;
        }

        public string GetName()
        {
            return "Original Core Logic Object";
        }
    }
}