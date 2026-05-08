namespace project14_solution14
{
    internal class Program
    {
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal is eating");
            }
            public virtual void sound()
            {
                Console.WriteLine("Animal make sound");
            }
            public virtual void sleep()
            {
                Console.WriteLine("Aminal is sleep");

            }
            class Dog : Animal
            {
                public override void sound()
                {
                    Console.WriteLine("Dog barks");
                }
                public override void sleep()
                {
                    Console.WriteLine("Dog is sleep");
                }

                static void Main(string[] args)
        {
            Dog dog = new Dog();
                 dog.sleep();
                dog.sound();
        }
    }
}


