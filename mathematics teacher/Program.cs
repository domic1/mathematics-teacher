namespace Done_is_better_than_good
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            Console.WriteLine("Podaj pierwszą cyfrę");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą cyfrę");
            number2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Suma tych liczb jest równa:" + (number1 + number2));
            //Console.WriteLine("Wynik z dzielenia jest równy :" + (number1 / number2));
            if(number1 == number2)
            {
                Console.WriteLine("Podałeś takie same liczby");
            }
            else
            {
                Console.Write("Podałeś inne liczby");
            }
        }
    }
}
