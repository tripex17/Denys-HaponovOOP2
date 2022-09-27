
    public class Converter {

        private double usd;
        private double eur;
        private double rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public int convertUAHToUSD(double amount)
        {
            return (int)Math.Round((amount / usd)); 
        }

        public int convertUSDToUAH(double amount)
        {
            return (int)Math.Round(amount * usd);
        }

        public int convertEURToUAH(double amount) {
            return (int)Math.Round(amount * eur);  
        }
        public int convertRUBToUAH(double amount)
        {
            return (int)Math.Round(amount * rub); 
        }
    }

