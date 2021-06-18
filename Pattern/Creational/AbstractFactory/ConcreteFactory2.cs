namespace DesignPatterns.Pattern.Creational.AbstractFactory
{
    /// <summary>
    /// implements the operations to create concrete product objects.
    /// </summary>
    class ConcreteFactory2 : AbstractFactory
    {
        /// <summary>
        /// Returns product A2
        /// </summary>
        /// <returns></returns>
        public override AbstractProductA CreateProductA()
        {
        return new ProductA2();
        }

        /// <summary>
        /// Returns product B2
        /// </summary>
        /// <returns></returns>
        public override AbstractProductB CreateProductB()
        {
        return new ProductB2();
        }
    }
}