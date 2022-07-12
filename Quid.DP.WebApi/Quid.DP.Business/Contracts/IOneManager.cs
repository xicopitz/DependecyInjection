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
    public interface IOneManager
    {
        /// <summary>
        /// Tests the one.
        /// </summary>
        /// <returns>string.</returns>
        Task<string> TestOne();

        /// <summary>
        /// Tests the two.
        /// </summary>
        /// <returns>string.</returns>
        Task<string> TestTwo();

        /// <summary>
        /// Tests the both.
        /// </summary>
        /// <returns>string.</returns>
        Task<string> TestBoth();

        /// <summary>
        /// Tests the 2.
        /// </summary>
        /// <returns>KeyValuePair<string, string></returns>
        Task<KeyValuePair<string, string>> Test_2();
    }
}
