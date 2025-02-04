using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Random = new Random();
            int[] randArray = new int[52];
            int randResultNum = 0;
            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = i+1;
            }

            // 배열섞기
            Random.Shuffle(randArray);

            foreach (var item in randArray)
            {
                if(randResultNum == 8)
                {
                    break;
                }
                Console.WriteLine(item);
                randResultNum++;
            }
       




        }
    }
}
