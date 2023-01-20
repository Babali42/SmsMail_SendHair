namespace SmsMail_SendHair
{
    public class SmsSender : ISender
    {
        public string Send(string text)
            => $"Bonjour voici un sms de rappel concernant : {text}";
    }
}