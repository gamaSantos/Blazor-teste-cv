using System;

namespace dinamico
{
    public class Person
    {
        public string Name { get; set; }
        public string MaritalStatus { get; set; }
        public string Description { get; set; }
        public DateTime Birthdate { get; set; }
        public Address Address { get; set; }
        public ContactInformation Contact { get; set; }

        public int Age => (DateTime.Today.DayOfYear <= Birthdate.DayOfYear) ? (DateTime.Today.Year - Birthdate.Year) - 1 : (DateTime.Today.Year - Birthdate.Year);
    }

    public class Address
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }

    public class ContactInformation
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}