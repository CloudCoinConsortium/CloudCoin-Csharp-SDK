using Newtonsoft.Json;

namespace CloudCoinCsharpSDK
{
    /*
     example json file: 
   
        {
           "publickey":"preston.CloudCoin.Global",
           "privatekey":"6e2b96d6204a4212ae57ab84260e747f",
           "email":""
         }
         */

    public class BankKeys : IKeys
    {
        //Fields
        [JsonProperty("publickey")]
        public string publickey { get; set; }

        [JsonProperty("privatekey")]
        public string privatekey { get; set; }

        [JsonProperty("account")]
        public string account { get; set; }


        //Constructors
        public BankKeys()
        {

        }//end of constructor

        public BankKeys(string publickey, string privatekey, string account)
        {
            this.publickey = publickey;
            this.privatekey = privatekey;
            this.account = account;
        }//end of constructor


    }
}
