namespace Week2AssessmentQuestion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();
            List<string> list = new List<string>() { "Paarkavi", "Priya", "Vartha"}; 
            License(name, rnd.Next(3), list);
            
        }

        public static void License(string name, int available_number, List<string> list)
        {
            list.Add(name);
            list.Sort();
            int index = list.FindIndex(a => a.Contains(name));
            if(index == 0)
            {
                Console.WriteLine(20);
            }
            if (index == 1)
            {
                Console.WriteLine(40);
            }
            if (index == 2)
            {
                Console.WriteLine(60);
            }
            if (index == 3)
            {
                Console.WriteLine(80);
            }
            if (index == 4)
            {
                Console.WriteLine(100);
            }
            


        }

    }
}