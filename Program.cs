using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            do
            {
                Console.WriteLine("Enter your Choice for Membership In PVR Cinemas");
                Console.WriteLine("1.Silver  2.Gold  3.Platinum");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Silver silver = new Platinum();
                    silver.seat();
                    silver.ticket_discount();
                }
                else if (choice == 2)
                {
                    Gold gold = new Platinum();
                    gold.seat();
                    gold.ticket_discount();
                    gold.Edible();
                }
                else if (choice == 3)
                {
                    Platinum platinum = new Platinum();
                    platinum.seat();
                    platinum.ticket_discount();
                    platinum.Edible();
                }
                else
                {
                    Console.WriteLine("wrong input");
                }

                Console.WriteLine("want to continue press 1");
                i = Convert.ToInt32(Console.ReadLine());

            } while (i == 1);



        }

        public interface Silver
        {
            void ticket_discount();


            void seat();



        }

        public interface Gold
        {
            void ticket_discount();


            void seat();


            void Edible();

        }

        public class Platinum : Silver, Gold
        {

            void Silver.ticket_discount()
            {
                Console.WriteLine("Get Flat 10% Off on Tickets for silver membership");
            }

            void Silver.seat()
            {
                Console.WriteLine("Get standard seat in theater");
            }



            void Gold.ticket_discount()
            {
                Console.WriteLine("Get Flat 16% Off on Tickets for Gold membership");
            }

            void Gold.seat()
            {
                Console.WriteLine("Get Premium Glider seat in theater");
            }
            void Gold.Edible()
            {
                Console.WriteLine("Get a Burger and fries Only");
            }



            public void ticket_discount()
            {
                Console.WriteLine("Get Flat 25% Off on Tickets for Gold membership");
            }

            public void seat()
            {
                Console.WriteLine("Get VIP Premium Recliner seat in theater");
            }

            public void Edible()
            {
                Console.WriteLine("Get a Burger and fries with Bucket of popcorns");
            }

        }



    }
}
