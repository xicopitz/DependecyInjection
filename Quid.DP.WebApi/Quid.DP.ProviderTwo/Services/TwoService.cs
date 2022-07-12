using Quid.DP.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Quid.DP.ProviderTwo.Services
{
    /// <summary>
    /// TwoService.
    /// </summary>
    /// <seealso cref="Quid.DP.Data.Contracts.ITwoService" />
    public sealed class TwoService : ITwoService
    {
        private IHttpClientFactory httpClientFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoService"/> class.
        /// </summary>
        /// <param name="httpClientFactory">The HTTP client factory.</param>
        public TwoService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        /// <summary>
        /// Anothers the test.
        /// </summary>
        /// <returns>
        /// string.
        /// </returns>
        public Task<string> AnotherTest()
        {
           return Task.FromResult("Two called");
        }
    }
}
