using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Dx2_API_SERVER.Models.Login
{
    public class GetUrlResponse
    {
        [JsonObject(ItemNullValueHandling = NullValueHandling.Include)]
        public class ResponseTemplate
        {
            public Result result { get; set; }
        }

        [JsonObject(ItemNullValueHandling = NullValueHandling.Include)]
        public class Result
        {
            [JsonProperty("appsflyer_enable_button")]
            public bool appsflyer_enable_button { get; set; }

            [JsonProperty("asset_bundle_version")]
            public string asset_bundle_version { get; set; }

            [JsonProperty("sv_branch")]
            public string sv_branch { get; set; }

            [JsonProperty("gdpr_ver")]
            public string gdpr_ver { get; set; }

            [JsonProperty("ds")]
            public string ds { get; set; }

            [JsonProperty("store_url")]
            public string store_url { get; set; }

            [JsonProperty("playbit_url")]
            public string playbit_url { get; set; }

            [JsonProperty("is_need_version_up")]
            public sbyte is_need_version_up { get; set; }

            [JsonProperty("chat_url")]
            public string chat_url { get; set; }

            [JsonProperty("web_url")]
            public string web_url { get; set; }

            [JsonProperty("appsflyer_enable_view")]
            public bool appsflyer_enable_view { get; set; }

            [JsonProperty("server_id")]
            public string server_id { get; set; }

            [JsonProperty("asset_bundle_url")]
            public string asset_bundle_url { get; set; }

            [JsonProperty("gdpr_url")]
            public string gdpr_url { get; set; }

            [JsonProperty("base_data_url")]
            public string base_data_url { get; set; }

            [JsonProperty("svtool_revision")]
            public string svtool_revision { get; set; }

            [JsonProperty("sv_revision")]
            public string sv_revision { get; set; }

            [JsonProperty("svtool_branch")]
            public string svtool_branch { get; set; }
        }
    }
}
