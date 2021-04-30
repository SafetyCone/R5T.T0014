using System;

using R5T.Aalborg;


namespace R5T.T0014
{
    public class SendAsInformation : ISendAsInformation
    {
        public IAuthentication Authentication { get; set; }
        public string EmailAddress { get; set; }
        public string DisplayName { get; set; }
    }
}
