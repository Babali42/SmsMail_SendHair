namespace SmsMail_SendHair
{
    public class EMailSender : ISender
    {
        public string Send(string text)
            => $"Bonjour voici un mail de rappel concernant : {text}";
    }
}