using System;
using DesignPatterns.Pattern.Structural.Adapter;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            // Adapter
            Target target = new Adapter();
            target.Request();

            // Adapter example
            // Non-adapted chemical compound
            Compound unknown = new Compound(CompoundEnum.Unknown);
            unknown.Display();
        
            // Adapted chemical compounds
            Compound water = new RichCompound(CompoundEnum.Water);
            water.Display();
        
            Compound benzene = new RichCompound(CompoundEnum.Benzene);
            benzene.Display();
        
            Compound ethanol = new RichCompound(CompoundEnum.Ethanol);
            ethanol.Display();

            // Abstract factory #1
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();
        
            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();
        
            
            // Wait for user
            Console.ReadKey();
        }
    }
}
