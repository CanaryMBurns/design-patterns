namespace DesignPatterns.Pattern.Structural.Adapter
{
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    public class ChemicalDatabank
    {
        /// <summary>
        /// Gets thermodynamics critical point concept
        /// </summary>
        /// <param name="compound">Compound's name</param>
        /// <param name="point"> M for melting point and other case for boiling point</param>
        /// <returns></returns>
        public float GetCriticalPoint(CompoundEnum compound, string point)
        {
            // Melting Point
            if (point == "M")
            {
                switch (compound)
                {
                    case CompoundEnum.Water: return 0.0f;
                    case CompoundEnum.Benzene: return 5.5f;
                    case CompoundEnum.Ethanol: return -114.1f;
                    default: return 0f;
                }
            }
            // Boiling Point
            else
            {
                switch (compound)
                {
                    case CompoundEnum.Water: return 100.0f;
                    case CompoundEnum.Benzene: return 80.1f;
                    case CompoundEnum.Ethanol: return 78.3f;
                    default: return 0f;
                }
            }
        }
 
        /// <summary>
        /// Gets molecular structure
        /// </summary>
        /// <param name="compound">Compound's name</param>
        /// <returns></returns>
        public string GetMolecularStructure(CompoundEnum compound)
        {
            switch (compound)
            {
                case CompoundEnum.Water: return "H20";
                case CompoundEnum.Benzene: return "C6H6";
                case CompoundEnum.Ethanol: return "C2H5OH";
                default: return "";
            }
        }
 
        /// <summary>
        /// Gets molecular weight
        /// </summary>
        /// <param name="compound">Compound's name</param>
        /// <returns></returns>
        public double GetMolecularWeight(CompoundEnum compound)
        {
            switch (compound)
            {
                case CompoundEnum.Water: return 18.015;
                case CompoundEnum.Benzene: return 78.1134;
                case CompoundEnum.Ethanol: return 46.0688;
                default: return 0d;
            }
        }
    }
}