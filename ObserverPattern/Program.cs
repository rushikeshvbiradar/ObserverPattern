using ObserverPattern.Models;

Console.WriteLine("Observer Pattern Example...");

Console.WriteLine("\nCreating Apple Stock.");

AAPL aapl = new AAPL("AAPL", 1200.00);
Console.WriteLine("{0} :: {1}", aapl.Symbol, aapl.Price);

Console.WriteLine("\nAdding Subscribers for AAPL stock");
Investor varghese = new Investor("Varghese");
aapl.Attach(varghese);
Investor nikita = new Investor("Nikita");
aapl.Attach(nikita);

Console.WriteLine("");

// stock price changes
Console.WriteLine("Stock price changes");
aapl.Price = 1200.50;
aapl.Price = 1201.50;

Console.WriteLine("\nDetaching Subscriber {0} \n", varghese.Name);
aapl.Detach(varghese);

// stock price changes
Console.WriteLine("Stock price changes");
aapl.Price = 1200.75;
aapl.Price = 1199.75;

Console.ReadKey();

