using System;

namespace CrapsGameApp
{
    class Program
    {
        private static Random random = new Random();

        enum Status {Continue, Win, Lose}

        enum DiceNames
        {
            SnakeEyes = 2,
            Troy = 3,
            Seven = 7,
            Yoleven = 11,
            BoxCars = 12
        }
        static void Main(string[] args)
        {
            Console.WriteLine("========= Craps Game App ========");
            int SumDice = RollDice();

            int point = 0;

            Status gameStatus = Status.Continue;

            switch ((DiceNames)SumDice)
            {
                case DiceNames.Seven:
                case DiceNames.Yoleven:
                    gameStatus = Status.Win;
                    break;
                case DiceNames.SnakeEyes:
                case DiceNames.Troy:
                case DiceNames.BoxCars:
                    gameStatus = Status.Lose;
                    break;
                default:
                    point = SumDice;
                    break;
            }

            while (gameStatus == Status.Continue)
            {
                SumDice = RollDice();

                if (point == SumDice)
                {
                    gameStatus = Status.Win;
                } else {
                    if (SumDice == 7)
                    {
                        gameStatus = Status.Lose;
                    }
                }
            }

            if (gameStatus == Status.Win)
            {
                Console.WriteLine("You won!!!");
            } else if(gameStatus == Status.Lose){
                Console.WriteLine("You lost!");
            }
        }

        static int RollDice(){
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);

            int sum = dice1 + dice2;
            
            Console.WriteLine($"You rolled {dice1} and {dice2}. Sum is {sum}");
            return sum;
        }
    }
}
