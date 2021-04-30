using System;

using R5T.Aalborg;


namespace R5T.T0014
{
    /// <summary>
    /// Representation of information to identifier a sender (based on email).
    /// </summary>
    /// <remarks>
    /// Interface is read-only.
    /// Favor composition over inheritance for authentication.
    /// </remarks>
    public interface ISendAsInformation
    {
        IAuthentication Authentication { get; }
        string EmailAddress { get; }
        string DisplayName { get; }
    }
}
