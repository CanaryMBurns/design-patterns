namespace DesignPatterns.Pattern.Creational.AbstractFactory
{
    /// <summary>
    //  Declares an interface for operations that create abstract products.
    /// </summary>
    abstract class AbstractFactory
    {
        /// <summary>
        /// Creates product A.
        /// </summary>
        /// <returns>AbstractProductA</returns>
        public abstract AbstractProductA CreateProductA();

        /// <summary>
        /// Creates product B.
        /// </summary>
        /// <returns>AbstractProductB</returns>
        public abstract AbstractProductB CreateProductB();
    }
}