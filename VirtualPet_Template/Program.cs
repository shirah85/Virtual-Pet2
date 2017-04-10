using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is how we instantiate a new instance of our pet
            VirtualPet myPet = new VirtualPet();


            //Greeting-Intro-Instructions-Gaming hints
            Console.WriteLine("**********Welcome to Shirah's SHILOH!********** \nI'm Shirah, what is your name?.");
            string gamerName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(gamerName + ", " + "thank you for watching my dog Shiloh today.");
            Console.WriteLine("Please follow the instructions below and I'll let you and Shiloh have fun!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Shiloh is high maintenance. So, if you need to quit, just type 10 then enter. I will come right back home.");
            Console.WriteLine("Be sure to pet Shiloh first. He will be so much happier if you greet him with love.");
            Console.WriteLine("If Shiloh's scale is at 0 he is completely satisfied with that need.");
            Console.WriteLine("Shiloh is my heart! I am trusting you to take care of all his needs like I would.");
            Console.WriteLine("Hint: hungry - feed him, lonely - pet him, bored-play fetch, restless- walk him, tired - nap time");



            int selectedOption;

            do
            {
                //Options to interact with the pet
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("What would you like to do with Shirah's Shiloh?");
                Console.WriteLine("Please select an option.");
                Console.WriteLine("1. Feed Shiloh");
                Console.WriteLine("2. Pet Shiloh");
                Console.WriteLine("3. Play Fetch");
                Console.WriteLine("4. Walk Shiloh");
                Console.WriteLine("5. Put Shiloh to bed");
                Console.WriteLine("10. Quit");
                


                selectedOption = int.Parse(Console.ReadLine());

                myPet.MyPetStatus();

                switch (selectedOption)
                {
                    //when the user selects option one we feed the pet etc...
                    case 1:

                        myPet.HungerDecrease();
                        Console.WriteLine("Bark! Bark! Shiloh wags tail.");
                        break;

                    case 2:

                        myPet.LonelinessDecrease(); 
                        Console.WriteLine("Panting...Shiloh sits down.");
                        break;

                    case 3:

                        myPet.BoredomDecrease();
                        Console.WriteLine("Bark! BarK! Shiloh licks your face");
                        break;

                    case 4:

                        myPet.RestlessDecrease();
                        Console.WriteLine("Shiloh skips with joy down the road.");
                        break;

                    case 5:

                        myPet.TiredDecrease();
                        Console.WriteLine("Shiloh is getting some ZZZZZZZZZ's");
                        break;

                    case 10:

                        Console.WriteLine("Hi, I'm back " + gamerName + ". Thanks for watching Shiloh. Bye!");
                        break;

                    default:

                        Console.WriteLine("Invalid option selected.");
                        break;
                }                
                //myPet.HungerIncrease();          
          //Each option below will increase another option while decreasing the reference options above.
           
            if (selectedOption == 1)    
                            
            {
                myPet.RestlessIncrease();
            }

            else if (selectedOption == 2)
            {
                myPet.BoredomIncrease();
            }

            else if (selectedOption == 3)
            {
                myPet.TiredIncrease();
            }

            else if (selectedOption == 4)
            {
                myPet.HungerIncrease();
            }
                        
            else
                {
                    myPet.LonelinessIncrease();
                }

            } while (selectedOption != 10);


        }
    }
}
