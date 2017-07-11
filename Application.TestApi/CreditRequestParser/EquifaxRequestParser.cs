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

                var primaryNode = xDoc.Descendants().FirstOrDefault(x => x.Name.LocalName == "primary");
                XmlToDynamic.Parse(root, primaryNode);

                // Applicant personal information
                var title = root.primary.name.title;
                var foreName = root.primary.name.forename;
                var middleName = XmlToDynamic.HasProperty(root.primary.name, "middlename")
                    ? root.primary.name.middlename
                    : null;
                var surName = root.primary.name.surname;
                var dateOfBirth = root.primary.dob;
                // Current address
                var number = XmlToDynamic.HasProperty(root.primary.currentAddress.address, "number")
                    ? root.primary.currentAddress.address.number
                    : null;
                var postCode = root.primary.currentAddress.address.postcode;
                var postTown = root.primary.currentAddress.address.postTown;
                var street1 = root.primary.currentAddress.address.street1;

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