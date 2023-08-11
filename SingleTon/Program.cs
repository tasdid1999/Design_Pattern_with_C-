namespace DesignPattern.SingleTon
{
    public class Program
    {
        public static void Main(String[] args)
        {

            var obj = SingleTon.GetInstance();
            var obj2 = SingleTon.GetInstance();


        }
    }
    public sealed class SingleTon
    {
        private static SingleTon? singletonObject = null; 
        private SingleTon(){}

        public static SingleTon GetInstance()
        { 
        
            if(singletonObject is null)
            {
                Console.WriteLine("hello");
                singletonObject = new SingleTon();
            }

            return singletonObject;
        }
    }
}