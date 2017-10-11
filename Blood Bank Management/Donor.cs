using System;

namespace Blood_Bank_Management
{
    class Donor
    {
        public Donor(int donorId, string dob, int bloodGroup, int weight, string mobileNumber, string address,
            DateTime lastDonationDateTime, DateTime lastRecipentDateTime)
        {
            DonorId = donorId;
            Dob = dob;
            BloodGroup = bloodGroup;
            Weight = weight;
            MobileNumber = mobileNumber;
            Address = address;
            LastDonationDateTime = lastDonationDateTime;
            LastRecipentDateTime = lastRecipentDateTime;
        }

        public Donor(int donorId, string dob, int bloodGroup, int weight, string mobileNumber, string address)
        {
            DonorId = donorId;
            Dob = dob;
            BloodGroup = bloodGroup;
            Weight = weight;
            MobileNumber = mobileNumber;
            Address = address;
        }


        public int DonorId { get; set; }

        public string Dob { get; set; }

        public int BloodGroup { get; set; }

        public int Weight { get; set; }

        public string MobileNumber { get; set; }

        public string Address { get; set; }

        public DateTime LastDonationDateTime { get; set; }

        public DateTime LastRecipentDateTime { get; set; }
    }
}
