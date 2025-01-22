namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string strInputNum = Console.ReadLine();

            if (int.TryParse(strInputNum, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                    Console.WriteLine(card);
            }
            else
                Console.WriteLine("Please enter a valid number.");
        }
    }
}
