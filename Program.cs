namespace NewC_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string masege;
            int numberRepetitions;

            Console.Write($"Введите сообщение: ");
            masege = Console.ReadLine();

            Console.WriteLine( $"Введите ко-во повторений для вывода сообщения: " );
            numberRepetitions = Convert.ToInt32( Console.ReadLine() );

            while( numberRepetitions > 0 )
            {
                Console.WriteLine(masege);
                numberRepetitions--;
            }
        }
    }
}