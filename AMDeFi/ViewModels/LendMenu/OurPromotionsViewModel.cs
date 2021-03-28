using System;
namespace AMDeFi.ViewModels.LendMenu
{
    public class OurPromotionsViewModel:BaseViewmodel
    {
        string _Name;
        string _Value;
        string _Status;
        string _Comment;
        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Value
        {
            get => _Value;
            set
            {
                _Value = value;
                OnPropertyChanged(nameof(Value));
            }
        }
        public string Status
        {
            get => _Status;
            set
            {
                _Status = value;
                OnPropertyChanged(nameof(Status));
            }
        }
        public string Comment
        {
            get => _Comment;
            set
            {
                _Comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }
        public OurPromotionsViewModel()
        {
            IsActionBarVisible = true;
            PageTitle = "Promotion A";
            BackArrowVisible = true;
            IconAMDeFiVisible = false;

            Name = "Promotion A";
            Value = "1,000,000";
            Status = "OnGoing";
            Comment = "this is promotion A";
        }
    }
}
