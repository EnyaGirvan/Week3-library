using System;
using System.Collections.Generic;
using System.Text;

namespace library
{
    class Member
    {
        private int memberId;
        private string name;
        private string address;
        private int phone; //Changed to string to keep the leading zeros

        //Public properties
        public int MemberId
        {
            get { return memberId; }
            set { memberId = value; } //Private setter makes it read-only
        }
        public string Name
        {
            get { return name; } // get method
            set { name = value; } // set method
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        // Constructor for new member
        public Member(int memberId, string name, string address, int phone)
        {
            this.MemberId = memberId; // Assigns the camelCase parameter to PascalCase property
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }
        
        // Method to display information about a member
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine();
        }

    }
}
