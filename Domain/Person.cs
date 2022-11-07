using System;
using System.Collections.Generic;

namespace Curriculum.Domain
{
    public class Person
    {
        public string Name { get; set; }
        public Description MaritalStatus { get; set; }
        public Description Description { get; set; }
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
        private List<ExternalLink> _links = new List<ExternalLink>();

        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public void AddLink(ExternalLink link) => _links.Add(link);
        public IReadOnlyCollection<ExternalLink> ExternalLinks => _links;

        public record ExternalLink(string Name, string Uri);
    }
}