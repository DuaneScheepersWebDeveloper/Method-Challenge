namespace MethodChallenge
{
    internal class Program
    {

      

        public static void GreetFriend(string text) 
        {
            Console.WriteLine("Hi there, {0}",text);
        }
        static void Main(string[] args)
        {
            string friend1 = "Duane";
            string friend2 = "Miguel";
            string friend3 = "Harry";
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
        }
    }
}