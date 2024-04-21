using RestSharp;
using RestSharp.Authenticators;

namespace Story_Spoil_Testing
{
    public class StorySpoilTesting
    {
        private RestClient client;

        [OneTimeSetUp]
        public void Setup()
        {
            string jwtTokwn = GetJwtToken("iv111","123456");

            var options = new RestClientOptions(" ")
            {
                Authenticator = new JwtAuthenticator("")
            };
                        
            this.client = new RestClient(options);
        }

        private string GetJwtToken(string username, string password)
        {
            RestClient tempClient = new RestClient(" ");

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}