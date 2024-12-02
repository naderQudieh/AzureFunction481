using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionApp1_48
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("log Info -  This is version 1 NET 4.8");
            log.Error("log Error -  This is version 1 NET 4.8");
            return await Task.FromResult (req.CreateResponse(HttpStatusCode.OK, "This is version 1 NET 4.8 ") );
        }
    }
}
