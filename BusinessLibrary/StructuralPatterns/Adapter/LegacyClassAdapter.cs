namespace BusinessLibrary.StructuralPatterns.Adapter
{
    internal class LegacyClassAdapter : IClientInterface
    {
        private LegacyClassWeCannotChange _legacyClassWeCannotChange;

        public LegacyClassAdapter()
        {
            string someDependency = "ABC";
            int someOtherDependency = 123;
            //Creation of this object may be complex.
            _legacyClassWeCannotChange = new LegacyClassWeCannotChange(someDependency, someOtherDependency);
        }

        /// <summary>
        /// This methods should contain as little of their own logic as possible. They should only contain calls to the legacy class, and possibly some 
        /// type conversions etc. Their purpose is to hide the complexity of the legacy class from the client.
        /// </summary>        
        public int Add(int x, int y)
        {
            return _legacyClassWeCannotChange.DoSomething(x, y);
        }

        /// <summary>
        /// This methods should contain as little of their own logic as possible. They should only contain calls to the legacy class, and possibly some 
        /// type conversions etc. Their purpose is to hide the complexity of the legacy class from the client.
        /// </summary>
        public int Substract(int x, int y)
        {
            return _legacyClassWeCannotChange.DoSomethingElse(x, y);
        }
    }
}
