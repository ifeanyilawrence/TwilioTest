using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Rest.Verify.V2;
using Twilio.Rest.Verify.V2.Service;

namespace Twilio_Test
{
    class Program
    {
        public static string SID;
        public static string AuthToken;
        static void Main(string[] args)
        {
            SID = "AC22b89b28ede0a83a847c5403728aacd3";
            AuthToken = "c6df4c60625d238a4a35b61ded7448b9";

            //CreateService();
            CheckVerification();
            //TwilioClient.Init(SID, AuthToken);

            //var message = MessageResource.Create(
            //    body: "Hey dear!",
            //    from: new Twilio.Types.PhoneNumber("+16623184595"),
            //    to: new Twilio.Types.PhoneNumber("+2347037513959")
            //);

            //Console.WriteLine(message.Sid);
        }
        public static void CreateService()
        {
            TwilioClient.Init(SID, AuthToken);

            var service = ServiceResource.Create(friendlyName: "Suregifts Phone Number Verification");

            Console.WriteLine(service.Sid);
        }
        public static void CreateVerificationResource()
        {
            TwilioClient.Init(SID, AuthToken);

            var verification = VerificationResource.Create(
                to: "+2347037513959",
                channel: "sms",
                pathServiceSid: "VA38170ed98248deabbaf93432c377f433"
            );

            Console.WriteLine(verification.Sid);
        }
        public static void CheckVerification()
        {
            TwilioClient.Init(SID, AuthToken);

            var verificationCheck = VerificationCheckResource.Create(
                to: "+2347037513959",
                code: "336406",
                pathServiceSid: "VA38170ed98248deabbaf93432c377f433"
            );

            Console.WriteLine(verificationCheck.Status);
        }
    }
}
