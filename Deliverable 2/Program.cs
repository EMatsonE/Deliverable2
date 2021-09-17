using System;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            Console.WriteLine("Greetings multiple celled creature, please say one of " +
                    "the following");
            Console.WriteLine("hello");
            Console.WriteLine("hello there");
            Console.WriteLine("sup");
            Console.WriteLine("bye");
            do
            {

                //prompt person for what to say; hello, hello there, sup, bye
            
                string response = Console.ReadLine().ToLower();
                //recive prompt and respond with: Hi good to see you, General Kenobi,
                //I am good, Good bye! respectivly.
                int k = 0;
                if (response == "sup")
                {
                    if (k != 0) 
                    {
                        Console.WriteLine("I'm sorry you've already said that.");
                    }
                    else 
                    {
                        Console.WriteLine("I am good!");
                        k = 1;
                    }
                }

                int j = 0;
                if (response == "hello there")
                {
                    if (j != 0)
                    { 
                    Console.WriteLine("I'm sorry you've already said that.");
                    }
                    else 
                    {
                        Console.WriteLine("General Kenobi");
                        j = 1;
                    }
                }

                int i = 0;
                if (response == "hello")
                { 
                    if (i != 0) 
                    {
                        Console.WriteLine("I'm sorry you've already said that.");
                    }
                    else
                    {
                        Console.WriteLine("Hi good to see you!");
                        i = 1;
                    }
                }

                    //make user input lowercase

                    //if prompt has already been selected state "I'm sorry you've
                    //already said that."

                    //make sure it loops back to the selection unless the person says bye
                    

                if (response == "bye")
                {
                    repeat = false;
                    Console.WriteLine("Good Bye!");
                }
                else
                {
                    repeat = true;
                }
            }
            while (repeat == true);
        }
    }
}
