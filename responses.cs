using System;

namespace LDVELH
{
    public class responses
    {
        public static string story(int storyPart)
        {
            /*
            Change the variables below to make the story. 
            Each branch must end with a yes or no question.
            */

            string introduction = "You are walking along the sidewalk when you find an 100 dollar bill on the ground. Do you pick it up?";
            string branch1 = "You pick it up and now there's some mafia man walking towards you angrily. Do you run or stay?";
            string ending1 = "You ran away and no one chased you. You got 100$! The end.";
            string ending2 = "You stood still and the mafia man talks to you. He says \"Woah, is that my 100 dollar bill? I've been looking for it for ages. Can I buy it of you for a thousand dollars?\" You quickly agree a make 1000$! The end.";
            string branch2 = "You don't pick it up and keep walking. You turn your head to look into a dark alley and see a small group of people with guns and masks talking about robbing a bank. Do you call the police?";
            string ending3 = "You call the police and the gang sees you. They shoot you but they end up getting caught. The end.";
            string ending4 = "You don't call the police and go home. On the news you see that a group of 4 people shot up a bank and killed 14 people and got away with 1,000,000$. The end.";

            string[] text = {
                introduction,
                branch1,
                ending1,
                ending2,
                branch2,
                ending3,
                ending4
            };

            return text[storyPart];
            
        }
    }
}