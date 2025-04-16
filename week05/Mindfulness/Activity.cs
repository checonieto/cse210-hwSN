#nullable disable
using System;
using System.Threading;

namespace Mindfulness;

public abstract class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name} Activity");
            Console.WriteLine();
            Console.WriteLine(_description);
            Console.WriteLine();
            Console.Write("How long, in seconds, would you like for your session? ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Get ready to begin...");
            ShowSpinner(3);
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Good job! You have completed another activity.");
            ShowSpinner(3);
            Console.WriteLine();
            Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
            ShowSpinner(3);
        }

        protected void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("/");
                Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("\\");
                Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("|");
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public abstract void Run();
    }