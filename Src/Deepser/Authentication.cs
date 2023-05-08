using Deepser.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Deepser
{
    public class Authentication : Data
    {
        // The Host, Username, Password, and Token properties are used to store authentication information.
        internal string Host { get; set; }
        internal string Username { get; set; }
        internal string Password { get; set; }
        internal string Token { get; set; }

        // The AutomaticAuth property is used to store a default Authentication instance.
        internal static Authentication AutomaticAuth { get; set; }

        // Constructor for creating an Authentication instance with a username and password.
        public Authentication(string _host, string _username, string _password)
        {
            Host = _host;
            Username = _username;
            Password = _password;
            AutomaticAuth = this;
        }

        // Constructor for creating an Authentication instance with a token.
        public Authentication(string _host, string _token)
        {
            Host = _host;
            Token = _token;
            AutomaticAuth = this;
        }

        // Returns the host, prefixed with https:// if it isn't already.
        public string GetHost()
        {
            if (Host.Contains(".deepser.net") || Host.Contains("https://"))
            {
                return Host;
            }
            return $"https://{Host}.deepser.net";
        }

        // Returns true if authentication information is set (either username/password or token).
        public bool IsAuthenticated => (!string.IsNullOrEmpty(Host) && !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password)) || !string.IsNullOrEmpty(Host) && !string.IsNullOrEmpty(Token);

        // Returns an AuthenticationHeaderValue instance containing the authentication information.
        public AuthenticationHeaderValue AuthorizationHeader => IsAuthenticated ? GetAuthenticationHeader() : throw new InvalidOperationException("Authentication is not set.");

        // Returns an AuthenticationHeaderValue instance containing the token or username/password information.
        public AuthenticationHeaderValue GetAuthenticationHeader()
        {
            if (!string.IsNullOrEmpty(Token))
            {
                return new AuthenticationHeaderValue("Bearer", Token);
            }
            else if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {
                string auth = $"{Username}:{Password}";
                auth = Convert.ToBase64String(Encoding.UTF8.GetBytes(auth));
                return new AuthenticationHeaderValue("Basic", auth);
            }
            else
            {
                throw new InvalidOperationException("Authentication is not set.");
            }
        }
    }
}
