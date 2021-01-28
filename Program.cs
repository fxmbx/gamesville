using System;

namespace quest01
{
    class Program
    {
        static int BrosOverStack(int n, int m)
        {
            Console.WriteLine("There are {0} stacks, each of height {1}", n,m);
            int winner =0;
            int timeToPlay = 0;
            int usr2input;
            int y;
            int usr1input;
            m *= n;
            string usr = "Ali", usr2 = "Bet";
            while(timeToPlay < n)
            {
                if (m < 1)
                {
                    break;
                }
                else
                {

                    if (timeToPlay % 2 == 0)
                    {
                        winner = 1;
                    }
                    else
                    {
                        winner = 2;
                    }
                }

                Console.WriteLine("{0} Your Turn", usr);
                usr1input = Convert.ToInt32(Console.ReadLine());
                if(usr1input < 2)
                {
                    winner = 2;
                    break;
                }
                y = m - usr1input;
                m -= usr1input;
                    if (1<y && usr1input > m)
                    {
                        if(usr1input%m == 0)
                        {
                            winner =1;
                            break;
                        }
                    }
               

                Console.WriteLine("{0} Your Turn", usr2);
                usr2input = Convert.ToInt32(Console.ReadLine());
                if(usr2input < 2) { winner = 1; break; }
                y = m - usr2input;
               
                m-=usr2input;
           
                    if (usr2input < 2)
                    {
                        Console.WriteLine("{0} broke the game, {1} won",usr2, usr );
                        break;
                    }
                    else
                    {
                        if (1<y && usr2input > m)
                        {
                            if (usr2input % m == 0)
                            {
                                 
                                winner = 2;
                                break;
                            }
                        }
                    }

                timeToPlay++;
            }
            Console.WriteLine();
            return winner; 
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(BrosOverStack(3, 4));
              
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
          
            Console.ReadKey();
        }
    }
}
