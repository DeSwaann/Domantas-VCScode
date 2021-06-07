using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleApp3.Project
{
    class MainDungeon
    {
        public static Hero myHero = new Hero();
        public static void Start()
        {
            string sentence = @"Welcome, challenger! Today I shall guide you through the adventure of your life.* 
Your goal, a rather obvious one, *
is to survive. *
Lets get going. *";
            sentence = sentence.Replace("*", System.Environment.NewLine);
            Clear();
            WriteLine(sentence);
            ConsoleUtils.WaitForKeyPress();

            Clear();
            WriteLine("A hero needs a name. What shall be yours?");
            WriteLine("");
            myHero.name = ReadLine();
            Clear();
            if(myHero.name == "")
            {
                WriteLine("No name? I'll call you Batman Bin Suparman then");
                myHero.name = "Batman Bin Suparman";
            }
            else
            {
                WriteLine("Welcome to the dungeon " + myHero.name + ". It's your time to shine. (Hopefully)");
            }
            ConsoleUtils.WaitForKeyPress();
            Clear();
            WriteLine("The rules of the dungeon are rather simple: beat 5 champions and you'll become a free soul.");
            Clear();
            WriteLine("Lets begin. Shall we?");
            ConsoleUtils.WaitForKeyPress();
            

        }
    }
}
