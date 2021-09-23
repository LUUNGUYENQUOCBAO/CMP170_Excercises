using System;
using System.Collections.Generic;
namespace Exercise_2
{
    class Program

    {
        public interface lAnimal
        {
            void Speak();
            void Move();

        }
        public class BaseAnimal
        {
            public void speak()
            {
                Console.WriteLine();
            }
            public void move()
            {
                Console.WriteLine();
            }

            public class Monkey : BaseAnimal
            {
                public void speak()
                {
                    Console.WriteLine("Monkey speak : khec khec");
                }
                public void move()
                {
                    Console.WriteLine("Monkey move : 4 chan ");
                }
                public void climb()
                {
                    Console.WriteLine("Monkey climb : cay ");
                }

            }
            public class Pet : BaseAnimal
            {
                public void speak()
                {
                    Console.WriteLine("Pet speak: bat ki");
                }
                public void move()
                {
                    Console.WriteLine("Pet move : bat ki");
                }
                String Name;
                public void EnterName()
                {
                    Console.WriteLine("\nEnter Name pet:");
                    Name = Console.ReadLine();
                }
            }

            public class Dog : Pet
            {
                String color;
                public void EnterColor()
                {
                    Console.WriteLine("color Dog is brwon");
                    color = Console.ReadLine();
                }
                public void speak()
                {
                    Console.WriteLine(" Dog speak :gau gau");
                }
                public void move()
                {
                    Console.WriteLine("Dog move : 4 chan");
                }

            }
            public class Cat : Pet
            {
                public void speak()
                {
                    Console.WriteLine("Cat speak : meo meo");

                }
                public void move()
                {
                    Console.WriteLine("Cat move : 4 chan");
                }
                public void Jump()
                {
                    Console.WriteLine("Cat Jump : tree");
                }
            }
            public class Duck :BaseAnimal
            {
                public void speak()
                {
                    Console.WriteLine("Duck speak is cap cap");
                }
                public void move()
                {
                    Console.WriteLine("Duck move is 2 chan");
                }
            }
            public class Tiger : BaseAnimal
            {
                public void speak()
                {
                    Console.WriteLine("Tiger speak is Qwua Qwua");
                }
                public void move()
                {
                    Console.WriteLine("Tiger move is 4 chan");
                }

            }
            public class Lion : BaseAnimal
            {
                public void speak()
                {
                    Console.WriteLine("Lion speak is Qwua Qwua ");
                }
                public void move()
                {
                     Console.WriteLine("Lion move is 4 chan");
                   
                }
            }

            static void Main(string[] args)
            {

                Monkey Monkey = new Monkey();
                Monkey.climb();
                Monkey.speak();
                Monkey.move();

                Dog Dog = new Dog();
                Dog.EnterName();
                Dog.EnterColor();
                Dog.speak();
                Dog.move();

                Cat Cat = new Cat();
                Cat.EnterName();
                Cat.Jump();
                Cat.speak();
                Cat.move();

                Console.WriteLine("\nList Animal:");
                List<String> lAnimal = new List<string>();
                lAnimal.Add("Duck");
                lAnimal.Add("Tiger");
                lAnimal.Add("Lion");

                foreach (String item in lAnimal)
                {
                    Console.WriteLine(item);
                }

                Duck Duck = new Duck();
                Duck.speak();
                Duck.move();
                Tiger Tiger = new Tiger();
                Tiger.speak();
                Tiger.move();
                Lion Lion = new Lion();
                Lion.speak();
                Lion.move();

                Console.ReadKey();
            }
        }
    }
}
