using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quid.DP.Data.Contracts
{
    /// <summary>
    /// ITwoService.
    /// </summary>
    public interface ITwoService
    {
        /// <summary>
        /// Anothers the test.
        /// </summary>
        /// <returns>
        /// string.
        /// </returns>
        Task<string> AnotherTest();
    }
}
