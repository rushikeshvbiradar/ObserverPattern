using ObserverPattern.Models;

namespace ObserverPattern.Interface
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
