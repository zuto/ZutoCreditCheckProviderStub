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
                case EquifaxResponseType.ValidationFaultException:
                    Template = ReadResponse("/V2/ValidationFaultException.xml");
                    break;
                case EquifaxResponseType.FaultException:
                    Template = ReadResponse("/V2/FaultException.xml");
                    break;

                case EquifaxResponseType.NoTrace:
                    Template = ReadResponse("/V2/NoTrace.xml");
                    break;

                case EquifaxResponseType.NoMatch:
                    Template = ReadResponse("/V2/NoMatch.xml");
                    break;

                case EquifaxResponseType.SingleMatch:
                    Template = ReadResponse("/V2/SingleMatch.xml");
                    break;

                case EquifaxResponseType.MultipleMatch:
                    Template = ReadResponse("/V2/MultipleMatch.xml");
                    break;

                case EquifaxResponseType.PasswordReset:
                    Template = ReadResponse("/V2/PasswordReset.xml");
                    break;

                case EquifaxResponseType.ValidLogonToken:
                    Template = ReadResponse("/V4/ValidV4TokenResponse.xml");
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

        public IEquifaxMockResponseFactory OverrideScores(ConfigureModel config)
        {
            Template = Template
                .Replace("{RNILF04Positive}", config.RNILF04Score < 0 ? "false" : "true")
                .Replace("{RNILF04Value}", Math.Abs(config.RNILF04Score).ToString())
                .Replace("{FTILF04Positive}", config.FTILF04Score < 0 ? "false" : "true")
                .Replace("{FTILF04Value}", Math.Abs(config.FTILF04Score).ToString())
                .Replace("{RNILF01Positive}", config.RNILF01Score < 0 ? "false" : "true")
                .Replace("{RNILF01Value}", Math.Abs(config.RNILF01Score).ToString())
                .Replace("{INOSF04Positive}", config.INOSF04Score < 0 ? "false" : "true")
                .Replace("{INOSF04Value}", Math.Abs(config.INOSF04Score).ToString())
                .Replace("{RNOLF04Positive}", config.RNOLF04Score < 0 ? "false" : "true")
                .Replace("{RNOLF04Value}", Math.Abs(config.RNOLF04Score).ToString());

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