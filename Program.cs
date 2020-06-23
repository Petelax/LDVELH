using System;

//This is an example program for the choose your own adventure story. this is not the actual story I'll use

namespace LDVELH
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Change the variables below to make the story. 
            Each branch must end with a yes or no question.
            You can add branches and endings by adding switch statments in cases.
            */
            string introduction = "You are walking along the sidewalk when you find an 100 dollar bill on the ground. Do you pick it up?";

            string branch1 = "You pick it up and now there's some mafia man walking towards you angrily. Do you run or stay?";
            string ending1 = "You ran away and no one chased you. You got 100$! The end.";
            string ending2 = "You stood still and the mafia man talks to you. He says \"Woah, is that my 100 dollar bill? I've been looking for it for ages. Can I buy it of you for a thousand dollars?\" You quickly agree a make 1000$! The end.";

            string branch2 = "You don't pick it up and keep walking. You turn your head to look into a dark alley and see a small group of people with guns and masks talking about robbing a bank. Do you call the police?";
            string ending3 = "You call the police and the gang sees you. They shoot you but they end up getting caught. The end.";
            string ending4 = "You don't call the police and go home. On the news you see that a group of 4 people shot up a bank and killed 14 people and got away with 1,000,000$. The end.";
            
            Console.WriteLine(introduction);
            Console.WriteLine("(Y)es (N)o");

            switch (getAnswer())
            {
                case 1:
                    Console.WriteLine(branch1);
                    Console.WriteLine("(Y)es (N)o");
                    
                    switch (getAnswer())
                    {
                        case 1:
                            Console.WriteLine(ending1);
                            Console.ReadLine();
                            goto End;
                        case 2:
                            Console.WriteLine(ending2);
                            Console.ReadLine();
                            goto End;
                    }
                    break;
                    
                case 2:
                    Console.WriteLine(branch2);
                    Console.WriteLine("(Y)es (N)o");
                    
                    switch (getAnswer())
                    {
                        case 1:
                            Console.WriteLine(ending3);
                            Console.ReadLine();
                            goto End;                            
                        case 2:
                            Console.WriteLine(ending4);
                            Console.ReadLine();
                            goto End;
                        
                    }
                    break;
                    

            }
            End:;
            // If you want to put something every ending, you can put it here.
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
