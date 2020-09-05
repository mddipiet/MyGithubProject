using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8_5_RealityTVStar
{
    class ParadiseIsland : Application
    {
        public string gender;
        public string nameOfFriend;
        public int yearsDating;


        public ParadiseIsland(string gender, string nameOfFriend, int yearsDating, string firstName, string lastName, string DOB,
            string address, string city, string state, int zip, string phoneNumber, string email) : base(firstName, lastName, DOB, address, city,
                state, zip, phoneNumber, email)
        {
            this.gender = gender;
            this.nameOfFriend = nameOfFriend;
            this.yearsDating = yearsDating;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Congrats! You have been accepted to Paradise Island!");
        }
    }
}
