using System;

namespace Deliverable2
{

    class Program
    {

        static string userAnswer;
        static string lowUserAnswer;
        static string lowNextUserAnswer;
        static string nextUserAnswer;

        static void Main(string[] args)
        {




            ////////methods




             void Continuation(){
                 Console.WriteLine("What else would you like to say?");
                 nextUserAnswer = Console.ReadLine();
                 lowNextUserAnswer = nextUserAnswer.ToLower();

                 if (lowNextUserAnswer == lowUserAnswer)
                 {
                     Console.WriteLine("I'm sorry but you have already said that");

                 }
                 else if (lowNextUserAnswer == @"hello")
                 {
                     Console.WriteLine("Hi good to see you.");
                 }
                 else if (lowNextUserAnswer == "sup")
                 {
                     Console.WriteLine("I am good");
                 }
                 else if (lowNextUserAnswer == @"hello there")
                 {
                     Console.WriteLine("General Kenobi");

                 }



            }



            ///////program runs
            ///
            Console.WriteLine("What do you wish to say to our bot?");
            userAnswer = Console.ReadLine();
            lowUserAnswer = userAnswer.ToLower();

            if (lowUserAnswer == "hello")
            {
                Console.WriteLine("Hi good to see you.");
            }
            else if (lowUserAnswer == "sup")
            {
                Console.WriteLine("I am good");
            }
            else if (lowUserAnswer == "hello there")
            {
                Console.WriteLine("General Kenobi");

            }



            /////////loop

            while ((lowUserAnswer != "bye") || (lowNextUserAnswer != "bye"))
            {

                Continuation();
                lowUserAnswer = lowNextUserAnswer;
            }

            ////////sign off

            if ((lowUserAnswer == "bye") || (lowNextUserAnswer == "bye"))
            {
                Console.WriteLine("Good bye!");
            }




        }
    }
}
