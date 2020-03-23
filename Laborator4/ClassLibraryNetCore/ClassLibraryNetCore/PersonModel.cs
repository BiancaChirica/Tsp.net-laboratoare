using System;
using System.ComponentModel.DataAnnotations;

namespace ClassLibraryNetCore
{
    public class PersonModel
    {
        [Key]
        public int PersonId { get; set; }
        public String FirstName { get; set; }
        public String MidleName { get; set; }
        public String LastName { get; set; }
        public String TelephoneNumber { get; set; }


        public PersonModel( String firstName,String  midleName, String lastName,String  telephoneNumber)
        {
            this.FirstName = firstName;
            this.MidleName = midleName;
            this.LastName = lastName;
            this.TelephoneNumber = telephoneNumber;

        }

        public PersonModel()
        {

        }
    }
}
