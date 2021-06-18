using System;

namespace DesignPatterns.Pattern.Structural.Adapter
{
    /// <summary>
    /// Target class defines the domain-specific interface that Client uses.
    /// </summary>
    public class Target
    {
        /// <summary>
        /// Request method
        /// </summary>
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
}