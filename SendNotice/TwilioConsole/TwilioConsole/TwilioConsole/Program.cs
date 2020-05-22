using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace TwilioConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Token at twilio.com/console
            // DANGER! This is insecure. See http://twil.io/secure
            const string accountSid = "AC58f4635b412fea7d8febc46c3f04bb19";
            const string authToken = "632a1a46b5d89410efa03a16395e6db1";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Hey, Welcome to our new SMS platform. From KIBET",
                from: new Twilio.Types.PhoneNumber("+18506008350"),
                to: new Twilio.Types.PhoneNumber("+254719453783")
            );

            Console.WriteLine(message.Sid);
        }
    }
}
