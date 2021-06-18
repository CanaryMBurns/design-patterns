using System;

namespace DesignPatterns.Pattern.Structural.Adapter
{
    /// <summary>
    /// Adaptee class defines an existing interface that needs adapting.
    /// </summary>
    public class Adaptee
    {
        /// <summary>
        /// Specific request
        /// </summary>
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}