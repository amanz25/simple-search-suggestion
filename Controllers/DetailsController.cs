using Lucene.Net.Facet;
using Microsoft.AspNetCore.Mvc;
using NPoco.fastJSON;
using UmbracoProject1.Models;
using static OpenIddict.Client.WebIntegration.OpenIddictClientWebIntegrationConstants;

namespace UmbracoProject1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DetailsController : Controller
    {
        [HttpGet]
        [Route("GetUserDetail")]
        public JsonResult GetDetail(string search)
        {
            List<Detail> detailLists = new List<Detail>();
            detailLists.Add(new() { UserId = 1, Id = 1, Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", Body= "quia et suscipit\\nsuscipit recusandae consequuntur expedita et\r\ncum\\nreprehenderit molestiae ut ut quas totam\\nnostrum rerum est autem sunt rem\r\neveniet architecto" });
            detailLists.Add(new() { UserId = 1, Id = 2, Title = "qui est esse", Body= "est rerum tempore vitae\\nsequi sint nihil reprehenderit dolor beatae ea\r\ndolores neque\\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\\nqui\r\naperiam non debitis possimus qui neque nisi nulla" });
            List<string> aa = detailLists.Where(_ => _.Title.StartsWith(search)).Select(_=>_.Title).ToList();
            return Json(aa);
        }
    }
}
