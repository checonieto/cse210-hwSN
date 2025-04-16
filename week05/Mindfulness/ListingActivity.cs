#nullable disable
using System;

namespace Mindfulness;

public class ListingActivity: Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        private int _itemCount;

        public ListingActivity()
        {
            _name = "Listing";
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }

        public override void Run()
        {
            DisplayStartingMessage();
            
            Random random = new Random();
            string prompt = _prompts[random.Next(_prompts.Count)];
            Console.WriteLine("List as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");
            Console.Write("You may begin in: ");
            ShowCountdown(5);
            Console.WriteLine();
            
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            _itemCount = 0;
            
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                Console.ReadLine();
                _itemCount++;
            }
            
            Console.WriteLine();
            Console.WriteLine($"You listed {_itemCount} items!");
            
            DisplayEndingMessage();
        }
    }