using System;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Application.TestApi.Entities;
using Application.TestApi.Helpers;

namespace Application.TestApi.CreditRequestParser
{
    public class EquifaxRequestParser : IEquifaxRequestParser
    {
        public Applicant ParseApplicant(string xmlRequest)
        {
            Applicant applicant;
            try
            {
                var xDoc = XDocument.Load(new StringReader(xmlRequest));

                dynamic root = new ExpandoObject();

                XmlToDynamic.Parse(root, xDoc.Elements().First());

                var mainApplicant = root.creditQuotationSearchRequest1.creditQuotationSearchRequest.soleSearch.primary;

                // Applicant personal information
                var title = mainApplicant.name.title;
                var foreName = mainApplicant.name.forename;
                var middleName = XmlToDynamic.HasProperty(mainApplicant.name, "middlename")
                    ? mainApplicant.name.middlename
                    : null;
                var surName = mainApplicant.name.surname;
                var dateOfBirth = mainApplicant.dob;
                // Current address
                var number = mainApplicant.currentAddress.address.number;
                var postCode = mainApplicant.currentAddress.address.postcode;
                var postTown = mainApplicant.currentAddress.address.postTown;
                var street1 = mainApplicant.currentAddress.address.street1;

                applicant = new Applicant
                {
                    Title = title,
                    ForeName = foreName,
                    MiddleName = middleName,
                    Surname = surName,
                    DateOfBirth = dateOfBirth,
                    CurrentAddress = new Address
                    {
                        Number = number,
                        PostCode = postCode,
                        PostTown = postTown,
                        Street1 = street1
                    }
                };
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to parse applicant information from Equifax request: {e.Message}");
            }

            return applicant;
        }
    }
}