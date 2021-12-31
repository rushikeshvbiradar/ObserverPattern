using ObserverPattern.Interface;

namespace ObserverPattern.Models
{
    public abstract class Stock
    {
        //private members
        private string symbol;
        private double price;
        private List<IInvestor> investors = new List<IInvestor>();

        //constructor
        public Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        // getters setters
        public string Symbol
        {
            get { return symbol; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    Console.WriteLine("\n{0}'s stock price updated to ${1}", Symbol, value);
                    price = value;
                    Notify();
                }
            }
        }

        // Add subscriber
        public void Attach(IInvestor investor)
        {
            investors.Add(investor);
        }

        // Remove subscriber
        public void Detach(IInvestor investor)
        {
            investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (IInvestor investor in investors)
            {
                investor.Update(this);
            }
        }
    }
}
