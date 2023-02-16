using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;
            
            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    // Oyun başlangıç ekranı : " TAŞ, KAĞIT veya MAKAS'a girin:  " 
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                /* Computer(Bilgisayar) rastgele bir sayı ürettiriyor ve karşılık gelen Case(Durum) de 
                 bulunan string değeri consol'a yazdırıyoruz. */
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                /* Seçtiğimiz String değeri ve Computer(Bilgisayar) da seçilen değeri yazdırarak durumu
                 belirtiyoruz.(Win,Lose,Draw) */
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }
                // İşlemleri Tekrarlamak için soruyor ve seçilen değere göre tekrardan başlatıyoruz.
                Console.Write("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }
            // Seçilen değer "false" ise işlemi sonlandırıyoruz.
            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }
    }
}
