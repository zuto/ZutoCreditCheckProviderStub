using System;
using System.IO;
using System.Web;
using Application.TestApi.CreditRequestParser;
using Application.TestApi.Entities;

namespace Application.TestApi.Mocks
{
    public class EquifaxMockResponseFactory : IEquifaxMockResponseFactory
    {
        private readonly IEquifaxRequestParser _equifaxRequestParser;
        private string _request;

        public EquifaxMockResponseFactory(IEquifaxRequestParser equifaxRequestParser)
        {
            _equifaxRequestParser = equifaxRequestParser;
        }

        private static string EquifaxMocksPath =>
            Path.Combine(HttpContext.Current.Server.MapPath("~"), "Mocks/Equifax");

        private string Template { get; set; }

        public IEquifaxMockResponseFactory ResponseOfType(EquifaxResponseType responseType)
        {
            switch (responseType)
            {
                case EquifaxResponseType.FaultException:
                    Template = ReadResponse("FaultException.xml");
                    break;

                case EquifaxResponseType.NoTrace:
                    Template = ReadResponse("NoTrace.xml");
                    break;

                case EquifaxResponseType.NoMatch:
                    Template = ReadResponse("NoMatch.xml");
                    break;

                case EquifaxResponseType.SingleMatch:
                    Template = ReadResponse("SingleMatch.xml");
                    break;

                case EquifaxResponseType.MultipleMatch:
                    Template = ReadResponse("MultipleMatch.xml");
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(responseType), responseType, null);
            }

            return this;
        }

        public string Build()
        {
            return Template;
        }

        public IEquifaxMockResponseFactory OverrideDefaultApplicant()
        {
            var applicant = _equifaxRequestParser.ParseApplicant(_request);

            Template = Template
                .Replace("{title}", applicant.Title)
                .Replace("{foreName}", applicant.ForeName)
                .Replace("{middleName}", applicant.MiddleName)
                .Replace("{surName}", applicant.Surname)
                .Replace("{dateOfBirth}", applicant.DateOfBirth)
                .Replace("{addressNumber}", applicant.CurrentAddress.Number)
                .Replace("{addressStreet1}", applicant.CurrentAddress.Street1)
                .Replace("{postTown}", applicant.CurrentAddress.PostTown)
                .Replace("{postCode}", applicant.CurrentAddress.PostCode);

            return this;
        }

        public IEquifaxMockResponseFactory SetRequest(string request)
        {
            _request = request;
            return this;
        }

        private static string ReadResponse(string filePath)
        {
            return File.ReadAllText(Path.Combine(EquifaxMocksPath, filePath));
        }
    }
}