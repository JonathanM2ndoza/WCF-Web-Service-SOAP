using System;
using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace Security_WS_SOAP.Security
{
    public class CustomUserNameValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException("User and Password can not be empty.");
            }

            // Go to the Repository
            if (!(userName.Equals("jmendoza", StringComparison.InvariantCultureIgnoreCase)
                && password.Equals("123456", StringComparison.InvariantCultureIgnoreCase)))
            {
                // This throws an informative fault to the client.
                throw new FaultException("Unknown Username or Incorrect Password");
                // When you do not want to throw an infomative fault to the client,
                // throw the following exception.
                // throw new SecurityTokenException("Unknown Username or Incorrect Password");
            }
        }
    }
}