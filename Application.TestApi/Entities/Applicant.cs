using Application.TestApi.CreditRequestParser;

namespace Application.TestApi.Entities
{
    public class Applicant
    {
        public string Title { get; set; }
        public string ForeName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
        public Address CurrentAddress { get; set; }
    }
}