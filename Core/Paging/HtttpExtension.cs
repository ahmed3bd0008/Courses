using System.Text.Json;
using Microsoft.AspNetCore.Http;
namespace Core.Paging
{
    public static  class HtttpExtension
    {
        public static void AddPagNationHeader(this HttpResponse response,MetaData metaData)
        {
            response.Headers.Add("Pagnation",JsonSerializer.Serialize(metaData));
            response.Headers.Add("Access-Control-Expose-Header","Pagnation");
        }
    }
}