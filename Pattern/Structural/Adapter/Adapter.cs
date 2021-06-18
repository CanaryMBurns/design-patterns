namespace DesignPatterns.Pattern.Structural.Adapter
{
    /// <summary>
    /// Adapter class adapts the interface Adaptee to the Target interface.
    /// </summary>
    class Adapter : Target
    {
        private Adaptee _adaptee = new Adaptee();
    
        /// <summary>
        /// Target request method overriden.
        /// </summary>
        public override void Request()
        {
            // Possibly do some other work

            //  and then call SpecificRequest
            _adaptee.SpecificRequest();
        }
    }
}