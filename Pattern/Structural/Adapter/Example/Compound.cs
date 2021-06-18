using System;

namespace DesignPatterns.Pattern.Structural.Adapter
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    class Compound
    {
        protected CompoundEnum _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;
    
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="chemical">Compound's name</param>
        public Compound(CompoundEnum chemical)
        {
            this._chemical = chemical;
        }

        /// <summary>
        /// Display method shows compound's information
        /// </summary>    
        public virtual void Display()
        {
            Console.WriteLine("\nCompound: {0} ------ ", _chemical);
        }
    }
}