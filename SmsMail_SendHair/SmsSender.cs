namespace SmsMail_SendHair
{
    public class SmsSender : ISender, IChargeable
    {
        private int charge = 0;
        
        public string Send(string text)
        {
            Charge();
            return  $"Bonjour voici un sms de rappel concernant : {text}";
        }

        public int GetTotalPrice()
        {
            return charge;
        }

        public void Charge()
        {
            charge++;
        }
    }
}