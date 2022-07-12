using Microsoft.AspNetCore.Mvc;
using Quid.DP.Business.Contracts;

namespace Quid.DP.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OneController : ControllerBase
    {
        private readonly ILogger<OneController> logger;
        public readonly IOneManager oneManager;
        public readonly ITwoManager twoManager;
        public OneController(ILogger<OneController> logger, IOneManager oneManager, ITwoManager twoManager)
        {
            this.oneManager = oneManager;
            this.twoManager = twoManager;
            this.logger = logger;
        }

        [HttpGet("callOne")]
        public async Task<string> Get1Async()
        {
            try
            {
                logger.LogInformation("one called");
                return await oneManager.TestOne();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }
        }

        [HttpGet("callTwo")]
        public async Task<string> Get2Async()
        {
            try
            {
                logger.LogInformation("two called");
                return await oneManager.TestTwo();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }
        }

        [HttpGet("callBoth")]
        public async Task<string> GetBothAsync()
        {
            try
            {
                logger.LogInformation("both called");
                return await oneManager.TestBoth();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }
        }

        [HttpGet("test")]
        public async Task<KeyValuePair<string, string>> TestAsync()
        {
            try
            {
                logger.LogInformation("both called");
                return await oneManager.Test_2();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
}