namespace DesignPatterns.Pattern.Creational.AbstractFactory
{
    /// <summary>
    /// declares an interface for a type of product object.
    /// </summary>
    abstract class AbstractProductB
    {
        /// <summary>
        /// Interacts.
        /// </summary>
        /// <param name="a">Abstract product A</param>
        public abstract void Interact(AbstractProductA a);
    }
}