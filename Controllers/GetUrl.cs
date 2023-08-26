using Dx2_API_SERVER.Attributes;
using Dx2_API_SERVER.Models;
using Dx2_API_SERVER.Models.Login;
using Dx2_API_SERVER.Models.Player;
using Dx2_API_SERVER.Utils;
using Newtonsoft.Json;

using static Dx2_API_SERVER.Util;

namespace Dx2_API_SERVER.Controllers
{
    [ServerHandleContainer]
    public static class SigninController
    {
        [ServerHandle("/socialsv/GetUrl.do", Types = new string[] { "GET" })]
        public static HttpResponse Get(ServerHandleArgs args)
        {
            response = {};
            return Content(args, JsonConvert.SerializeObject(response), "application/json");
        }
}
