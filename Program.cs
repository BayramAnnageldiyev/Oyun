namespace tahmin
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int xsay;
            Console.WriteLine("Başlangıç sayıyı giriniz!");
            int sayı1=int.Parse(Console.ReadLine());

            Console.WriteLine("Bitiş sayıyı giriniz!");
            int sayı2=int.Parse(Console.ReadLine());

            Console.WriteLine("Kaç sayı istiyorsunuz?");
            int cvp=int.Parse(Console.ReadLine());
            
            int[] ints=new int[cvp];
            for(int i = 0; i < cvp; i++)
            {
                xsay = rnd.Next(sayı1, sayı2);
                if (i==0)
                {
                    ints[i] = xsay;
                }
                else
                {
                    for(int j = 0; j < i; j++)
                    {
                        if(ints[j]== xsay)
                        {
                            i--;
                            break;
                        }
                        else
                        {
                            ints[i] = xsay;
                        }


                    }
                }




            }

            Array.Sort(ints);
            for(int i = 0;i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }

        }
    }
}