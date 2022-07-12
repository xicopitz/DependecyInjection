using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quid.DP.Data.Contracts
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOneService
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        /// <returns>string.</returns>
        Task<string> Test();

        /// <summary>
        /// Tests the 2.
        /// </summary>
        /// <returns>string.</returns>
        Task<KeyValuePair<string, string>> Test_2();

        /// <summary>
        /// Tests the 3.
        /// </summary>
        /// <returns>string.</returns>
        Task<bool> Test_3();
    }
}