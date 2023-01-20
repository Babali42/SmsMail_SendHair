namespace SmsMail_SendHair
{
    public class EMailSender : ISender, IChargeable
    {
        public string Send(string text)
            => $"Bonjour voici un email de rappel concernant : {text}";

        public int GetTotalPrice()
        {
            return 0;
        }

        public void Charge()
        {
            
        }
    }
}