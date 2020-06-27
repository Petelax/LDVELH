using System;

//This is an example program for the choose your own adventure story. this is not the actual story I'll use

namespace LDVELH
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:;
            
            Console.WriteLine(responses.story(0));
            Console.WriteLine("(Y)es (N)o");

            switch (getAnswer())
            {
                case 1:
                    Console.WriteLine(responses.story(1));
                    Console.WriteLine("(Y)es (N)o");
                    
                    switch (getAnswer())
                    {
                        case 1:
                            Console.WriteLine(responses.story(2));
                            goto End;
                        case 2:
                            Console.WriteLine(responses.story(3));
                            goto End;
                    }
                    break;
                    
                case 2:
                    Console.WriteLine(responses.story(4));
                    Console.WriteLine("(Y)es (N)o");
                    
                    switch (getAnswer())
                    {
                        case 1:
                            Console.WriteLine(responses.story(5));
                            goto End;                            
                        case 2:
                            Console.WriteLine(responses.story(6));
                            goto End;
                        
                    }
                    break;
                    

            }
            End:;
            // If you want to put something every ending, you can put it here.
            Console.WriteLine("Would you like to go through the story again?");
            if(getAnswer()==1)
            {
                goto Start;
            }
            Console.ReadLine();
            
        }
        static int getAnswer()
        {
            int caseSwitch = 0;
            
            while(true)
            {
            int answer = Console.Read();
            if (answer == 10 || answer == 13) {continue;}
            answer = Convert.ToChar(answer);
            if (answer == 'Y' || answer == 'y') {caseSwitch = 1; break;}
            else if (answer == 'N' || answer == 'n') {caseSwitch = 2; break;}
            else {Console.WriteLine("Invalid answer. Try again.");}
            }

            return caseSwitch;
        }
    }
}
