using System;
using System.Collections.Generic;

namespace AMDeFi.Models.WalletModel
{
    //public class HistoryDAICoin
    //{

    //    public string Witdraw { get; set; }
    //    public string Deposit { get; set; }
    //    public string TransactionDate { get; set; }

    //}
    //public class HistoryDAICoinList
    //{
    //    public string TotalDAICoin { get; set; }
    //    public List<HistoryDAICoin> DAICoin { get; set; }
    //}


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Transaction
    {
        public string address { get; set; }
        public DateTime issue_date { get; set; }
        public string transaction_name { get; set; }
        public string transaction_type { get; set; }
        public int total { get; set; }
        public double snapshot_balance { get; set; }

        public string TestColor { get; set; }
        public string icon { get; set; }
    }

    public class Message
    {
        public string address { get; set; }
        public double balance { get; set; }
        public List<string> borrower_asset { get; set; }
        public List<string> borrower_token { get; set; }
        public object lender_loan { get; set; }
        public List<Transaction> transaction { get; set; }
        public List<string> loan_document { get; set; }
    }

    public class HistoryDAICoinList
    {
        public int statusCode { get; set; }
        public Message message { get; set; }
    }








}
