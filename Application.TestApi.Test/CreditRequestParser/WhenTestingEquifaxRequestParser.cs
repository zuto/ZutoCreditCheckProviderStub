using System.IO;
using Application.TestApi.CreditRequestParser;
using NUnit.Framework;

namespace Application.TestApi.Test.CreditRequestParser
{
    public class WhenTestingEquifaxRequestParser
    {
        protected EquifaxRequestParser EquifaxRequestParser => new EquifaxRequestParser();

        private static string EquifaxMocksPath
        {
            get
            {
                var testsDirectory =
                    Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory));
                var equifaxMockRequestsPath = Path.Combine(testsDirectory, "Mocks/Requests/Equifax");
                return equifaxMockRequestsPath;
            }
        }

        protected string XmlRequest => File.ReadAllText(Path.Combine(EquifaxMocksPath, "Request.xml"));
    }
}