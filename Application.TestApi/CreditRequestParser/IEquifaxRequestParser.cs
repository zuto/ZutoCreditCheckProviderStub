using Application.TestApi.Entities;

namespace Application.TestApi.CreditRequestParser
{
    public interface IEquifaxRequestParser
    {
        Applicant ParseApplicant(string xmlRequest);
    }
}