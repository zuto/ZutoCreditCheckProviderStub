using System;
using System.IO;
using System.Web;

namespace Application.TestApi.Mocks
{
    public class EquifaxMocks
    {
        private static string DirectoryPath => Path.Combine(HttpContext.Current.Server.MapPath("~"), "Mocks/Equifax");

        public static void ThrowStackTraceException()
        {
            throw new Exception("You are FooBared");
        }

        public static string FaultExceptionResponse()
        {
            return File.ReadAllText(Path.Combine(DirectoryPath, "FaultException.xml"));
        }

        public static string NoTraceResponse()
        {
            return File.ReadAllText(Path.Combine(DirectoryPath, "NoTrace.xml"));
        }

        public static string NoMatchResponse()
        {
            return File.ReadAllText(Path.Combine(DirectoryPath, "NoMatch.xml"));
        }

        public static string SingleMatchResponse()
        {
            return File.ReadAllText(Path.Combine(DirectoryPath, "SingleMatch.xml"));
        }

        public static string MultipleMatchResponse()
        {
            return File.ReadAllText(Path.Combine(DirectoryPath, "MultipleMatch.xml"));
        }


    }
}