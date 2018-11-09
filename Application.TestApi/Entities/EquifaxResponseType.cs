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
        ValidLogonToken,
        SingleMatchV4,
        FaultExceptionV4,
        ValidationFaultExceptionV4,
        NoTraceV4,
        NoMatchV4,
        MultipleMatchV4,
        ValidChangeSecretResponse
    }
}