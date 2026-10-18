using System;
using System.ComponentModel;

namespace Bài_1
{
    public class MemberModel : INotifyPropertyChanged
    {
        private string memberId;
        private string fullName;
        private string phone;
        private string package;
        private DateTime startDate;
        private decimal fee;

        public string MemberId
        {
            get { return memberId; }
            set { memberId = value; OnPropertyChanged("MemberId"); }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; OnPropertyChanged("FullName"); }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; OnPropertyChanged("Phone"); }
        }

        public string Package
        {
            get { return package; }
            set { package = value; OnPropertyChanged("Package"); }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; OnPropertyChanged("StartDate"); }
        }

        public decimal Fee
        {
            get { return fee; }
            set { fee = value; OnPropertyChanged("Fee"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}