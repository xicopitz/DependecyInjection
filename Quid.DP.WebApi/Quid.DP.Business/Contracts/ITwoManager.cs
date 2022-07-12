using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quid.DP.Business.Contracts
{
    /// <summary>
    /// IOneManager.
    /// </summary>
    public interface ITwoManager
    {
        /// <summary>
        /// Tests the one.
        /// </summary>
        /// <returns>
        /// string.
        /// </returns>
        Task<string> AnotherTest();
    }
}
