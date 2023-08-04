namespace DesignPattrenPractice
{
    public class Program
    {
        public static void Main(String[] args)
        {
            IPriceStrategy str = new NormalCustomerStrategy();
            CustomerBill bill = new CustomerBill(str);

            bill.Add(12.0, 1);
            bill.Add(18.0, 1);
            Console.WriteLine(bill.TotalPrice());

        }
    }


    public class CustomerBill
    {
        private IList<Double> drinks = null;
        public IPriceStrategy strategy;

        public CustomerBill(IPriceStrategy strategy)
        {
            this.strategy = strategy;
            drinks = new List<Double>();
        }

        public void Add(double price , int quantity)
        {
            drinks.Add(strategy.GetActPrice(price) * quantity);
        }
        public double TotalPrice()
        {
            return drinks.Sum();
        }
    }

    public interface IPriceStrategy
    {
        double GetActPrice(double price);
    }
    public class NormalCustomerStrategy : IPriceStrategy
    {
        public double GetActPrice(double price) => price;
    }
    public class HappyCustomerStrategy : IPriceStrategy
    {
        public double GetActPrice(double price) => price * 0.5;
    }


}