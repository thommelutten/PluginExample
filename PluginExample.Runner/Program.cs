// See https://aka.ms/new-console-template for more information

using PluginExample._2022;
using PluginExample._2022.Interfaces;
using PluginExample.Core;
using PluginExample.Core.Interfaces;

var calculator = new CalculatorWithExternalDependency();

Console.WriteLine($"Hello, World! Sum is {calculator.Add(2,4)}");
