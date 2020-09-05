using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8_5_RealityTVStar
{
    class AboveDeck : Application
    {
        public int yearsOfExperience;
        public string nationality;

        public AboveDeck(int yearsOfExperience, string nationality, string firstName, string lastName, string DOB, string address,
            string city, string state, int zip, string phoneNumber, string email) : base(firstName, lastName, DOB, address, city, state,
                zip, phoneNumber, email)
        {
            this.yearsOfExperience = yearsOfExperience;
            this.nationality = nationality;
        }

        public override void Accept()
        {
            Console.WriteLine("Congrats! You have been accepted to Above Deck!");
        }
    }
}
