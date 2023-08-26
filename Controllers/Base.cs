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
        [ServerHandle("/socialsv/Login.do", Types = new string[] { "GET" })]
        public static HttpResponse Get(ServerHandleArgs args)
        {
            ProfileResponse response = new ProfileResponse(ProfileUtils.ReadProfile(args.UrlArgs["uuid"]));
            return Content(args, JsonConvert.SerializeObject(response), "application/json");
        }

        [ServerHandle("/api/v1.1/player/profile/{profileID}", Types = new string[] { "POST" })]
        public static HttpResponse Post(ServerHandleArgs args)
        {
            if (args.UrlArgs["profileID"] != "signin")
                return BadRequest();

            SigninRequest request = JsonConvert.DeserializeObject<SigninRequest>(args.Content);

            string playerid = request.sessionTicket.Split("-")[0];

            SigninResponse.ResponseTemplate response = new SigninResponse.ResponseTemplate()
            {
                result = new SigninResponse.Result()
                {
                    AuthenticationToken = playerid,
                    BasePath = "/1",
                    Tokens = TokenUtils.GetSigninTokens(playerid),
                    ClientProperties = new object(),
                    Updates = new Updates()
                },
                updates = new Updates()
            };

            string resp = JsonConvert.SerializeObject(response, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            Log.Information($"[{playerid}]: Logged in.");

            return Content(args, resp, "application/json");
        }
    }
}
