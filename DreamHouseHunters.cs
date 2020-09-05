using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace Lab_8_5_RealityTVStar
{
    class DreamHouseHunters : Application
    {
        public string jobTitle;
        public int income;
        public int whenBuying;
        public int bedrooms;
        public int bathrooms;

        public DreamHouseHunters(string jobTitle, int income, int whenBuying, int bedrooms, int bathrooms,
            string firstName, string lastName, string DOB, string address, string city, string state, int zip,
            string phoneNumber, string email) : base(firstName, lastName, DOB, address, city, state, zip, phoneNumber, email)
            {
            this.jobTitle = jobTitle;
            this.income  = income;
            this.whenBuying = whenBuying;
            this.bedrooms = bedrooms;
            this. bathrooms = bathrooms;
            }
        
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Congrats! You have been accepted to Dream House Hunters!");
        }
   
    }
}
