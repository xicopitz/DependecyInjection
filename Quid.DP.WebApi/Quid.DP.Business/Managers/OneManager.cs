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
    /// <seealso cref="Quid.DP.Business.Contracts.IOneManager" />
    public class OneManager : IOneManager
    {
        private readonly IOneService oneService;
        private readonly ITwoService twoService;

        /// <summary>
        /// Initializes a new instance of the <see cref="OneManager"/> class.
        /// </summary>
        /// <param name="oneService">The one service.</param>
        /// <param name="twoService">The two service.</param>
        public OneManager(IOneService oneService, ITwoService twoService)
        {
            this.oneService = oneService;
            this.twoService = twoService;
        }

        /// <summary>
        /// Tests the both.
        /// </summary>
        /// <returns>string.</returns>
        public async Task<string> TestBoth()
        {
            string data = await oneService.Test();
            string data1 = await twoService.AnotherTest();

            return string.Format("{0} and {1}", data, data1);
        }

        /// <summary>
        /// Tests the one.
        /// </summary>
        /// <returns>string.</returns>
        public async Task<string> TestOne()
        {
            return await oneService.Test();
        }

        /// <summary>
        /// Tests the two.
        /// </summary>
        /// <returns>string.</returns>
        public async Task<string> TestTwo()
        {
            return await twoService.AnotherTest();
        }

        public async Task<KeyValuePair<string, string>> Test_2()
        {
            return await oneService.Test_2();
        }
    }
}
