using Microsoft.Net.Http.Headers;
using Quid.DP.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Quid.DP.ProviderOne.Services
{
    /// <summary>
    /// OneService.
    /// </summary>
    /// <seealso cref="Quid.DP.Data.Contracts.IOneService" />
    public sealed class OneService : IOneService
    {
        private IHttpClientFactory httpClientFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="OneService"/> class.
        /// </summary>
        /// <param name="httpClientFactory">The HTTP client factory.</param>
        public OneService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        /// <summary>
        /// Tests this instance.
        /// </summary>
        /// <returns>string.</returns>
        public async Task<string> Test()
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://api.github.com/repos/dotnet/AspNetCore.Docs/branches")
            {
                Headers =
                {
                    { HeaderNames.Accept, "application/vnd.github.v3+json" },
                    { HeaderNames.UserAgent, "HttpRequestsSample" }
                }
            };

            var httpClient = httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            return "One called";
        }

        /// <summary>
        /// Tests the 2.
        /// </summary>
        /// <returns>string.</returns>
        public Task<KeyValuePair<string,string>> Test_2()
        {
            KeyValuePair<string, string> data = new KeyValuePair<string, string>(Environment.GetEnvironmentVariable("VERSION"), RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? String.Format("Windows | {0}", RuntimeInformation.RuntimeIdentifier) : (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ? String.Format("Linux | {0}", RuntimeInformation.RuntimeIdentifier) : ""));
            return Task.FromResult(data);
        }

        /// <summary>
        /// Tests the 3.
        /// </summary>
        /// <returns>string.</returns>
        public Task<bool> Test_3()
        {
            return Task.FromResult(true);
        }
    }
}
