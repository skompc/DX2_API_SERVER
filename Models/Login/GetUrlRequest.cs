using System;

namespace Dx2_API_SERVER.Models.Login
{
    public class GetUrlRequest
    {
        public string check_code { get; set; }
        public string platform { get; set; }
        public string buildNumber { get; set; }
        public string lang { get; set; }
        public string bundle_id { get; set; }
        public string _tm_ { get; set; }
    }
}
