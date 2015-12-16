using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlConnector.Classes
{
    public class Contact
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Age { get; set; }
        public string Designation { get; set; }

        public void Add()
        {
            //inserts record in DB
        }

        public void Update()
        {
            //Update's record in DB
        }

        public static List<Contact> List()
        {
            return new List<Contact>();
        }

        public static Contact Get(string id)
        {
            return new Contact();
        }

        public static void Delete(string id)
        {
            //delete record in DB
        }
    }
}
