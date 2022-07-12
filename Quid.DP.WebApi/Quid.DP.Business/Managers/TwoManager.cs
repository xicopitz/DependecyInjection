using Quid.DP.Business.Contracts;
using Quid.DP.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quid.DP.Business.Managers
{
    /// <summary>
    /// OneManager.
    /// </summary>
    /// <seealso cref="Quid.DP.Business.Contracts.ITwoManager" />
    public class TwoManager : ITwoManager
    {
        private readonly ITwoService twoService;

        /// <summary>
        /// Initializes a new instance of the <see cref="OneManager"/> class.
        /// </summary>
        /// <param name="oneService">The one service.</param>
        /// <param name="twoService">The two service.</param>
        public TwoManager(ITwoService twoService)
        {
            this.twoService = twoService;
        }

        public Task<string> AnotherTest()
        {
            throw new NotImplementedException();
        }
    }
}
