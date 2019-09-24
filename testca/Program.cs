using System;
using System.Collections.Generic;

namespace calender_app
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("                          HOMEPAGE");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("------------------------------------------------------------------");
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
                        Console.WriteLine(Category);
                        NumberID += 1;
                    
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Choose a Category:");
                    NumberSelected = Convert.ToInt32(Console.ReadLine());
                    
                if (NumberSelected == 1)
                    {
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Welcome to the Coding page!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("------------------------------------------------------------------");
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
                            Console.WriteLine(Category);
                            ProjectIDNumber += 1;
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Choose a Category:");
                        int ProjectNumberSelected;
                        ProjectNumberSelected = Convert.ToInt32(Console.ReadLine());
                    }
        
                if (NumberSelected == 2)
                    {
                        do 
                        {
                            
                            i = 3;
                            Console.WriteLine("------------------------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Welcome to the Reading page!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("------------------------------------------------------------------");
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
                            Console.WriteLine("Choose a Category:");
                            int ReadingNumberSelected;
                            ReadingNumberSelected = Convert.ToInt32(Console.ReadLine());
                            
                            if (ReadingNumberSelected == 1)
                            {
                                Console.WriteLine("------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Tech Books/Articles");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("------------------------------------------------------------------");
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
                                Console.WriteLine("Choose a Category:");
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
                                Console.WriteLine("------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Casual Reading");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("------------------------------------------------------------------");
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
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Welcome to the Vocabulary page!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("------------------------------------------------------------------");
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
                        Console.WriteLine("Choose a Category:");
                        int VocabNumberSelected;
                        VocabNumberSelected = Convert.ToInt32(Console.ReadLine());    

                        if (VocabNumberSelected == 1)
                        {
                            Console.WriteLine("this worked");
                        }
                    }
        
                if (NumberSelected == 4)
                    {
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Welcome to the Exercise page!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("------------------------------------------------------------------");
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
                        Console.WriteLine("Choose a Category:");
                        int WorkoutNumberSelected;
                        WorkoutNumberSelected = Convert.ToInt32(Console.ReadLine());
                    }
        
                if (NumberSelected == 5)
                    {
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Welcome to the Work page!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("------------------------------------------------------------------");
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
                        Console.WriteLine("Choose a Category:");
                        int JobNumberSelected;
                        JobNumberSelected = Convert.ToInt32(Console.ReadLine());
                        
                    }
        
                if (NumberSelected == 6)
                    {
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Welcome to the Stat page!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("------------------------------------------------------------------");
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
                        Console.WriteLine("Choose a Category:");
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
