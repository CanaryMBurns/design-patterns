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
        
            
            // Wait for user
            Console.ReadKey();
        }
    }
}
