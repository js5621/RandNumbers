using System;
namespace ConsoleApp2
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
           
            int[] randArray = new int[52];
            String[] CardDeck = new String[52];
            int randResultNum = 0;
            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = i+1;
            }
            Random random = new Random();

            for (int i = 0; i < randArray.Length; i++)
            {
                int firstCardIndex = random.Next(0, randArray.Length);
                int secondCardIndex = random.Next(0, randArray.Length);

                int temp = randArray[firstCardIndex];
                randArray[firstCardIndex] = randArray[secondCardIndex];
                randArray[secondCardIndex] = temp;
            }
            // 배열섞기
            //random.Shuffle(randArray);
            //1-13 // Dia
            //14~26 // Heart
            //27-39 // clover
            //40-52 spade

            for (int i = 0; i < randArray.Length; i++)
            {
                // 카드판단

                CardDeck[i] = CardDetect(randArray[i]);

                Console.WriteLine(CardDeck[i]);

            }



        }

        static String CardDetect(int card)
        {
            int cardDetctNum = card % 13;
            String cardInfo = "";

            if (card >= 1 && card <= 13)
            {
                cardInfo += "DIAMOND";

                if (cardDetctNum == 0)
                {
                    cardInfo += " " + "K";
                }

                else if (cardDetctNum == 11)
                {
                    cardInfo += " " + "J";
                }

                else if (cardDetctNum == 12)
                {
                    cardInfo += " " + "Q";
                }

                else
                {
                    cardInfo += " " + cardDetctNum.ToString();
                }
            }

            else if (card >= 14 && card <= 26)
            {

                cardInfo += "HEART";

                if (cardDetctNum == 0)
                {
                    cardInfo += " " + "K";
                }

                else if (cardDetctNum == 11)
                {
                    cardInfo += " " + "J";
                }

                else if (cardDetctNum == 12)
                {
                    cardInfo += " " + "Q";
                }

                else
                {
                    cardInfo += " " + cardDetctNum.ToString();
                }

            }

            else if (card >= 27 && card <= 39)
            {

                cardInfo += "CLOVER";

                if (cardDetctNum == 0)
                {
                    cardInfo += " " + "K";
                }

                else if (cardDetctNum == 11)
                {
                    cardInfo += " " + "J";
                }

                else if (cardDetctNum == 12)
                {
                    cardInfo += " " + "Q";
                }

                else
                {
                    cardInfo += " " + cardDetctNum.ToString();
                }



            }
            else if (card >= 40 && card <=52)
            {

                cardInfo += "SPADE";
                if (cardDetctNum == 0)
                {
                    cardInfo += " " + "K";
                }

                else if (cardDetctNum == 11)
                {
                    cardInfo += " " + "J";
                }

                else if (cardDetctNum == 12)
                {
                    cardInfo += " " + "Q";
                }

                else
                {
                    cardInfo += " " + cardDetctNum.ToString();
                }

            }

            return cardInfo;
        }

    }
}
