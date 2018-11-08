namespace Application.TestApi.Entities
{
    public enum EquifaxResponseType
    {
        ValidationFaultException,
        FaultException,
        NoTrace,
        NoMatch,
        SingleMatch,
        MultipleMatch,
        PasswordReset,
        SingleMatchV4,
        ValidLogonToken
    }
}