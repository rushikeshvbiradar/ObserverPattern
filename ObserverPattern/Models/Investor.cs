using ObserverPattern.Interface;

namespace ObserverPattern.Models
{
    public class Investor: IInvestor
    {
        //private members
        private string name;
        private Stock stock;

        //constructor
        public Investor(string name)
        {
            this.name = name;
            Console.WriteLine("New subscriber added as " + name);
        }

        // getters setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Stock Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        // Investor receives a notification whenever stockprice changes
        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " + "changed to ${2}", name, stock.Symbol, stock.Price);
        }
    }
}
