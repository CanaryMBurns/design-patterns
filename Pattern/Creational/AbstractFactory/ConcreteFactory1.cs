namespace DesignPatterns.Pattern.Creational.AbstractFactory
{
    /// <summary>
    /// implements the operations to create concrete product objects.
    /// </summary>
    class ConcreteFactory1 : AbstractFactory
    {
        /// <summary>
        /// Returns product A1
        /// </summary>
        /// <returns></returns>
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        /// <summary>
        /// Returns product B1
        /// </summary>
        /// <returns></returns>
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}