namespace AddMulQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddMulQuiz addMulQuiz = new(AddMulQuiz.R.Next(2) == 1);
            while (true)
            {
                Console.Write($"{addMulQuiz.N1} {addMulQuiz.Op} {addMulQuiz.N2} = ");
                if (!int.TryParse(Console.ReadLine(), out int i))
                {
                    Console.WriteLine("Thanks for playing!");
                    return;
                }
                if (addMulQuiz.Check(i))
                {
                    Console.WriteLine("Right!");
                    addMulQuiz = new AddMulQuiz(AddMulQuiz.R.Next(2) == 1);
                }
                else Console.WriteLine("Wrong! Try again.");
            }
        }
    }
}
