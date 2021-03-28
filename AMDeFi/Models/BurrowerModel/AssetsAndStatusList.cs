using System;
using System.Collections.Generic;

namespace AMDeFi.Models.BurrowerModel
{
    //public class AssetsAndStatusList
    //{
    //    public string Number { get; set; }
    //    public string Status { get; set; }
    //    public string AssetsName { get; set; }
    //    public string Date { get; set; }
    //}


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class AssetInfo
    {
        public string asset_id { get; set; }
        public string address { get; set; }
        public string asset_name { get; set; }
        public int value { get; set; }
        public string loan_type { get; set; }
        public int loan_duration { get; set; }
        public int loan_interest { get; set; }
        public int loan_min { get; set; }
        public int loan_max { get; set; }
        public int valuate_interest { get; set; }
        public int token_amount { get; set; }
        public int token_balance { get; set; }
        public string status { get; set; }
        public DateTime issue_date { get; set; }
        public string loan_id { get; set; }
    }

    public class LoanInfo
    {
        public string loan_id { get; set; }
        public string asset_id { get; set; }
        public string address { get; set; }
        public int loan { get; set; }
        public int remain_debt { get; set; }
        public double min_debt_per_month { get; set; }
        public DateTime end_date { get; set; }
        public int interest { get; set; }
        public string status { get; set; }
        public List<string> token { get; set; }
    }

    public class AssetToken
    {
        public string token_id { get; set; }
        public string asset_id { get; set; }
        public string lender_address { get; set; }
        public int rate { get; set; }
        public bool is_sell { get; set; }
        public DateTime issue_date { get; set; }
    }

    public class AssetList
    {
        public AssetInfo asset_info { get; set; }
        public LoanInfo loan_info { get; set; }
        public List<AssetToken> asset_token { get; set; }
    }

    public class Message
    {
        public List<AssetList> asset_list { get; set; }
    }

    public class AssetsAndStatusList
    {
        public int statusCode { get; set; }
        public Message message { get; set; }
    }



}
