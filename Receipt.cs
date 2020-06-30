using Newtonsoft.Json;
namespace CloudCoinCsharpSDK
{
    public class Receipt : BaseResponse
    {
        [JsonProperty("receipt_id")]
        public string receipt_id { get; set; }


        [JsonProperty("timezone")]
        public string timezone { get; set; }


        [JsonProperty("total_authentic")]
        public int total_authentic { get; set; }

        [JsonProperty("total_fracked")]
        public int total_fracked { get; set; }

        [JsonProperty("total_counterfeit")]
        public int total_counterfeit { get; set; }

        [JsonProperty("total_lost")]
        public int total_lost { get; set; }

        [JsonProperty("receipt")]
        public ReceiptDetail[] receipt_detail { get; set; }

        [JsonProperty("reciept")]
        private ReceiptDetail[] reciept { set { receipt_detail = value; } }

    }
}
