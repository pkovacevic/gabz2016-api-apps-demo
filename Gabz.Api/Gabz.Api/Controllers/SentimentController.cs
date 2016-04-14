using System.Web.Http;
using System.Threading.Tasks;
using Gabz.Api.Models;
using Gabz.Core.Models;
using System.Collections.Generic;

namespace Gabz.Api.Controllers
{
    public class SentimentController : ApiController
    {

        public async Task<SentimentResult> Calculate(string document)
        {
            return await SentimentService.Analyse(document);
        }



    }
}
