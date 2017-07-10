﻿using Application.TestApi.Entities;

namespace Application.TestApi.Mocks
{
    public interface IEquifaxMockResponseFactory
    {
        IEquifaxMockResponseFactory SetRequest(string request);
        IEquifaxMockResponseFactory ResponseOfType(EquifaxResponseType responseType);
        IEquifaxMockResponseFactory OverrideDefaultApplicant();
        string Build();
    }
}