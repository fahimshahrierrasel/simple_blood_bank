using System;

namespace Blood_Bank_Management
{
    class Donor
    {
        private int donorId;
        private string dob;
        private int bloodGroup;
        private int weight;
        private string mobileNumber;
        private string address;
        
        
        private DateTime lastDonationDateTime;
        private DateTime lastRecipentDateTime;

        public Donor(int donorId, string dob, int bloodGroup, int weight, string mobileNumber, string address,
            DateTime lastDonationDateTime, DateTime lastRecipentDateTime)
        {
            this.donorId = donorId;
            this.dob = dob;
            this.bloodGroup = bloodGroup;
            this.weight = weight;
            this.mobileNumber = mobileNumber;
            this.address = address;
            this.lastDonationDateTime = lastDonationDateTime;
            this.lastRecipentDateTime = lastRecipentDateTime;
        }


        public int DonorId
        {
            get => donorId;
            set => donorId = value;
        }

        public string Dob
        {
            get => dob;
            set => dob = value;
        }

        public int BloodGroup
        {
            get => bloodGroup;
            set => bloodGroup = value;
        }

        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        public string MobileNumber
        {
            get => mobileNumber;
            set => mobileNumber = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public DateTime LastDonationDateTime
        {
            get => lastDonationDateTime;
            set => lastDonationDateTime = value;
        }

        public DateTime LastRecipentDateTime
        {
            get => lastRecipentDateTime;
            set => lastRecipentDateTime = value;
        }
    }
}
