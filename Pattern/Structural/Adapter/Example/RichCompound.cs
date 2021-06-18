using System;

namespace DesignPatterns.Pattern.Structural.Adapter
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    class RichCompound : Compound
    {
        private ChemicalDatabank _bank;
 
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Compound's name</param>
        public RichCompound(CompoundEnum name)
            : base(name)
        {
        }
 
        /// <summary>
        /// Display method shows compound's information
        /// </summary>
        public override void Display()
        {
            // The Adaptee
            _bank = new ChemicalDatabank();
        
            _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
            _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
            _molecularWeight = _bank.GetMolecularWeight(_chemical);
            _molecularFormula = _bank.GetMolecularStructure(_chemical);
        
            base.Display();
            Console.WriteLine(" Formula: {0}", _molecularFormula);
            Console.WriteLine(" Weight : {0}", _molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", _meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", _boilingPoint);
        }
  }
}