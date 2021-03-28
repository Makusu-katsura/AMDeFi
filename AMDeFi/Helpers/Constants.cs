using System;

using Xamarin.Forms;

namespace AMDeFi.Helpers
{
    public class Constants 
    {
        #region Const Properties

        public const int HomeViewIndex = 1;
        public const int BorrowViewIndex = 2;
        public const int LendViewIndex = 3;
        public const int WalletViewIndex = 4;
        #endregion

        public static double ClientTimeout = 25d; // seconds     public static double ClientTimeout = 25d; // seconds
        public const int AnimationTime = 250;

        //API
        public const string url = "https://7205ac309b79.ngrok.io";
    }
}

