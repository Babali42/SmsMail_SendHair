using NUnit.Framework;

namespace SmsMail_SendHair
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ShouldSendEmail()
        {
            var sender = new EMailSender();
            var app = new SendHair_App(sender);
            Assert.AreEqual(app.Send("le rdv du 14 décembre"),
                "Bonjour voici un email de rappel concernant : le rdv du 14 décembre");
            Assert.AreEqual(0, app.GetTotalPrice());
        }

        [Test]
        public void ShouldSendSms()
        {
            var sender = new SmsSender();
            var app = new SendHair_App(sender);
            Assert.AreEqual(app.Send("le rdv du 14 décembre"),
              "Bonjour voici un sms de rappel concernant : le rdv du 14 décembre");
            Assert.AreEqual(1, app.GetTotalPrice());
        }
    }
}