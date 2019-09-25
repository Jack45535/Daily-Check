﻿using System;
using System.Collections.Generic;


namespace calender_app
{
    class Program
    {
        int x = 1;

        public void Rainbow()
        {
            if (x ==1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                
            }

            if (x==2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                
            }

            if (x==3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                
            }

            if(x==4)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                

            }
            
            if(x==5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                
            }

            if (x==6)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                

            }

            if (x==7)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                
            }

            if(x==8)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                x-=8;
            }
            x+=1;
        }
        public void GetDate()
        {
            Program p = new Program();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            Console.ForegroundColor = ConsoleColor.White;
            int RainbowClock = 0;
            do
            {
                p.Rainbow();
                Console.Write("_");
                RainbowClock+=1;
            }
            while(RainbowClock<66);
            p.Rainbow();
            Console.WriteLine("O");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(date.ToString("MM/dd/yyyy"));
            Console.ForegroundColor = ConsoleColor.White;
            p.Rainbow();
            Console.WriteLine("                                                        |");
            Console.ForegroundColor = ConsoleColor.White;
            
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int i = 0;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            do
                {
                    i=i+1;
                    int NumberSelected;
                    List<string> Categories = new List<string>();
                    int NumberID = 1;
                    p.GetDate(); 
                    Console.Write("------------------------------------------------------------------");
                    p.Rainbow();
                    Console.WriteLine("|");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("                          HOMEPAGE                                ");
                    p.Rainbow();
                    Console.WriteLine("|");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("------------------------------------------------------------------");
                    p.Rainbow();
                    Console.WriteLine("|");
                    Categories.Add("Coding");
                    Categories.Add("Reading");
                    Categories.Add("Vocabulary");
                    Categories.Add("Exercise");
                    Categories.Add("Work");
                    Categories.Add("Stats");
                    
                    foreach (string Category in Categories)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(NumberID + ": ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Category);
                        NumberID += 1;
                        int characterlength = Category.Length; 
                        do
                        {
                            Console.Write(" ");
                            characterlength +=1;
                        }
                        while(characterlength<63);
                        p.Rainbow();
                        Console.WriteLine("|");
                    
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Pick a field!");
                    NumberSelected = Convert.ToInt32(Console.ReadLine());
                    
                if (NumberSelected == 1)
                    {
                        p.GetDate();
                        Console.Write("------------------------------------------------------------------");
                        p.Rainbow();
                        Console.WriteLine("|");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("                    Welcome to the Coding page!                   ");
                        p.Rainbow();
                        Console.WriteLine("|");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("------------------------------------------------------------------");
                        p.Rainbow();
                        Console.WriteLine("|");
                        List<string> Project = new List<string>();
                        int ProjectIDNumber = 1;
                        Project.Add("Calender app");
                        Project.Add("Underworld RPG");
                        Project.Add("Underworld RPG website");
                        Project.Add("Back");
                        

                        foreach (string Category in Project)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write(ProjectIDNumber + ": ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(Category);
                                ProjectIDNumber += 1;
                                int characterlength = Category.Length; 
                                do
                                {
                                    Console.Write(" ");
                                    characterlength +=1;
                                }
                                while(characterlength<63);
                                p.Rainbow();
                                Console.WriteLine("|");
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Pick a field!");
                                int ProjectNumberSelected;
                                ProjectNumberSelected = Convert.ToInt32(Console.ReadLine());
                            }
        
                if (NumberSelected == 2)
                    {
                        do 
                        {
                            p.GetDate();
                            
                            i = 3;
                            Console.Write("------------------------------------------------------------------");
                            p.Rainbow();
                            Console.WriteLine("|");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("                  Welcome to the Reading page!                    ");
                            p.Rainbow();
                            Console.WriteLine("|");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("------------------------------------------------------------------");
                            p.Rainbow();
                            Console.WriteLine("|");
                            List<string> ReadingMaterial = new List<string>();
                            int ReadingMaterialNumberID = 1;
                            ReadingMaterial.Add("Tech");
                            ReadingMaterial.Add("Leisure");
                            ReadingMaterial.Add("Back");
                            

                                foreach (string Category in ReadingMaterial)
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.Write(ReadingMaterialNumberID + ": ");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine(Category);
                                    ReadingMaterialNumberID += 1;
                                }
                            
                            
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Pick a field!");
                            int ReadingNumberSelected;
                            ReadingNumberSelected = Convert.ToInt32(Console.ReadLine());
                            
                            if (ReadingNumberSelected == 1)
                            {
                                p.GetDate();
                                Console.Write("------------------------------------------------------------------");
                                p.Rainbow();
                                Console.WriteLine("|");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("                       Tech Books/Articles                        ");
                                p.Rainbow();
                                Console.WriteLine("|");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("------------------------------------------------------------------");
                                p.Rainbow();
                                Console.WriteLine("|");
                                List<string> TechBooksAndArticles = new List<string>();
                                int TechBooksAndArticlesIDNumber = 1;
                                TechBooksAndArticles.Add("New Book/Article");
                                TechBooksAndArticles.Add("Back");
                                TechBooksAndArticles.Add("Home");
                                


                                foreach (string Category in TechBooksAndArticles)
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.Write(TechBooksAndArticlesIDNumber + ": ");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine(Category);
                                    TechBooksAndArticlesIDNumber += 1;
                                }

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Pick a field!");
                                int TechBooksAndArticlesNumberSelected;
                                TechBooksAndArticlesNumberSelected = Convert.ToInt32(Console.ReadLine());

                                if (TechBooksAndArticlesNumberSelected == 2)
                                {
                                    i = 3;
                                }

                                if (TechBooksAndArticlesNumberSelected == 3)
                                {
                                    i = 2;
                                }
                            }
                        
                        if (ReadingNumberSelected == 2)
                            {
                                p.GetDate();
                                Console.Write("------------------------------------------------------------------");
                                p.Rainbow();
                                Console.WriteLine("|");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("                           Casual Reading                         ");
                                p.Rainbow();
                                Console.WriteLine("|");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("------------------------------------------------------------------");
                                p.Rainbow();
                                Console.WriteLine("|");
                                List<string> CasualReading = new List<string>();
                                int CasualReadingIDNumber = 1;
                                CasualReading.Add("New Book/Article");
                                CasualReading.Add("Back");
                                CasualReading.Add("Home");
                                

                                foreach (string Category in CasualReading)
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.Write(CasualReadingIDNumber + ": ");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine(Category);
                                    CasualReadingIDNumber =+ 1;
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    while(i==3);
                    }
        
                if (NumberSelected == 3)
                    { 
                        p.GetDate();
                        Console.Write("------------------------------------------------------------------");
                        p.Rainbow();
                        Console.WriteLine("|");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("                Welcome to the Vocabulary page!                   ");
                        p.Rainbow();
                        Console.WriteLine("|");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("------------------------------------------------------------------");
                        p.Rainbow();
                        Console.WriteLine("|");
                        List<string> Vocab = new List<string>();
                        int VocabIDNumber = 1;
                        Vocab.Add("Tech Jargon");
                        Vocab.Add("Syntax");
                        Vocab.Add("English");
                        Vocab.Add("Other Langueges"); 
                        Vocab.Add("Back");
                        

                        foreach (string Category in Vocab)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(VocabIDNumber + ": ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(Category);
                            VocabIDNumber += 1;
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Pick a field!");
                        int VocabNumberSelected;
                        VocabNumberSelected = Convert.ToInt32(Console.ReadLine());    

                        if (VocabNumberSelected == 1)
                        {
                            Console.WriteLine("this worked");
                        }
                    }
        
                if (NumberSelected == 4)
                    {
                        p.GetDate();
                        Console.Write("------------------------------------------------------------------");
                        p.Rainbow();
                        Console.WriteLine("|");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("                 Welcome to the Exercise page!                    ");
                        p.Rainbow();
                        Console.WriteLine("|");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("------------------------------------------------------------------");
                        p.Rainbow();
                        Console.WriteLine("|");
                        List<string> Workout = new List<string>();
                        int WorkoutNumberID = 1;
                        Workout.Add("Running");
                        Workout.Add("Hiking");
                        Workout.Add("Pushups");
                        Workout.Add("Pullups");
                        Workout.Add("Gym");
                        Workout.Add("Walking home from the bar while hammered");
                        Workout.Add("Back");
                        

                        foreach (string Category in Workout)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(WorkoutNumberID+ ": ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(Category);
                            WorkoutNumberID +=1 ;
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Pick a field!");
                        int WorkoutNumberSelected;
                        WorkoutNumberSelected = Convert.ToInt32(Console.ReadLine());
                    }
        
                if (NumberSelected == 5)
                    {
                        p.GetDate();
                        Console.Write("------------------------------------------------------------------");
                        p.Rainbow();
                        Console.WriteLine("|");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("                     Welcome to the Work page!                    ");
                        p.Rainbow();
                        Console.WriteLine("|");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("------------------------------------------------------------------");
                        p.Rainbow();
                        Console.WriteLine("|");
                        List<string> Jobs = new List<string>();
                        int JobNumberID = 1;
                        Jobs.Add("Waiter");
                        Jobs.Add("Bartender");
                        Jobs.Add("Runner");
                        Jobs.Add("Intern at KC");
                        Jobs.Add("Back");
                        

                        foreach (string Category in Jobs)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(JobNumberID + ": ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(Category);
                            JobNumberID += 1;
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Pick a field!");
                        int JobNumberSelected;
                        JobNumberSelected = Convert.ToInt32(Console.ReadLine());
                        
                    }
        
                if (NumberSelected == 6)
                    {
                        p.GetDate();
                        Console.Write("------------------------------------------------------------------");
                        p.Rainbow();
                        Console.WriteLine("|");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("                 Welcome to the Stat page!                        ");
                        p.Rainbow();
                        Console.WriteLine("|");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("------------------------------------------------------------------");
                        p.Rainbow();
                        Console.WriteLine("|");
                        List<string> StatCategories = new List<string>();
                        int StatNumberID = 1;
                        StatCategories.Add("Breakdowns");
                        StatCategories.Add("Coding Projects");
                        StatCategories.Add("Reading Selection");
                        StatCategories.Add("Vocabulary Timespent");
                        StatCategories.Add("Type of Workout");
                        StatCategories.Add("Job");
                        StatCategories.Add("Back");
                        

                        foreach (string Category in StatCategories)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(StatNumberID + ": ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(Category);
                            StatNumberID += 1;
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Pick a field!");
                        int StatNumberSelected;
                        StatNumberSelected = Convert.ToInt32(Console.ReadLine());

                        if (StatNumberSelected ==7)
                        {
                            Console.WriteLine("Going Back!");
                            i=0;
                        }
                    }
                    
                }   
            while(i<3);
            Console.ResetColor();
            Console.Clear();

            
        
        }

    }
}
