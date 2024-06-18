using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.StructuralPatterns.Adapter
{
    internal class ClientClassOne
    {
        private IClientInterface _clientInterface;
        internal ClientClassOne(IClientInterface clientInterface)
        {
            _clientInterface = clientInterface;
        }

        /// <summary>
        /// Here some client specific logic can happen. The client doesn't know have to know anything about the legacy class, 
        /// nor is it forced to set it up. 
        /// </summary>
        internal void DoSomeClientOperation()
        {
            _clientInterface.Add(1, 2);
        }
    }
}
