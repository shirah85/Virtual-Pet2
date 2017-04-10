using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{

    class VirtualPet
    {
        //We're setting our fields to private here so only the VirtualPet class can modify them directly
        private string name;
        private int hunger;
        private int loneliness;
        private int boredom;
        private int restless;
        private int tired;

                //this defaut constructor is sets options without giving us any options
        public VirtualPet()
        {
            this.name = "Shiloh";
            this.hunger = 0;
            this.loneliness = 15;
            this.boredom = 0;
            this.restless = 0;
            this.tired = 0; 
        }

        
        public VirtualPet(string name, int hunger, int loneliness, int boredom, int restless, int tired)
        {
            this.name = name;
            this.hunger = hunger;
            this.loneliness = loneliness;
            this.boredom = boredom;
            this.restless = restless;
            this.tired = tired;
        }


        //this method can be called to increase the hunger
        public void HungerIncrease()
        {            
            this.hunger = hunger + 5;
        }

        //this method can be called to decrease the hunger
        public void HungerDecrease()
        {            
            this.hunger = hunger - 10;
        }

        public void LonelinessIncrease()
        {
            this.loneliness = loneliness + 5;
        }

        public void LonelinessDecrease()
        {
            this.loneliness = loneliness - 10;
        }

        public void BoredomIncrease()
        {
            this.boredom = boredom + 5;
        }

        public void BoredomDecrease()
        {
            this.boredom = boredom - 10;
        }

        public void RestlessIncrease()
        {
            this.restless = restless + 5;
        }

        public void RestlessDecrease()
        {
            this.restless = restless - 10;
        }

        public void TiredIncrease()
        {
            this.tired = restless + 5;
        }

        public void TiredDecrease()
        {
            this.tired = restless - 10;
        }

        //method for stats of virtual pet
        public void MyPetStatus()
        {
            Console.WriteLine("Shiloh's scale of emotions and needs are below.");
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Loneliness: " + loneliness);
            Console.WriteLine("Boredom: " + boredom);
            Console.WriteLine("Restless: " + restless);
            Console.WriteLine("Tired: " + tired);
        }         
    }
}