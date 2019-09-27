 using System;
using System.Collections.Generic;


namespace calender_app
{
    class Program
    {
        private static int x;

        static void Main(string[] args)
        {

            int NumberSelected = 0;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();   
            NumberSelected = HomePage();     
            if (NumberSelected == 1)
                {
                    GetDate();
                    Console.Write("----------------------------------------------------------------");
                    Rainbow();
                    Console.WriteLine("|");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("                    Welcome to the Coding page!                   ");
                    Rainbow();
                    Console.WriteLine("|");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("----------------------------------------------------------------");
                    Rainbow();
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
                            Rainbow();
                            Console.WriteLine("|");
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            int ProjectNumberSelected;
                            int RainbowClock = 0;
                            do
                            {
                                Rainbow();
                                Console.Write("_");
                                RainbowClock+=1;
                            }
                            while(RainbowClock<66);
                            Rainbow();
                            Console.WriteLine("|");
                            ProjectNumberSelected = Convert.ToInt32(Console.ReadLine());
                        }
        
            if (NumberSelected == 2)
                {
                        GetDate();
                        Console.Write("----------------------------------------------------------------");
                        Rainbow();
                        Console.WriteLine("|");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("                  Welcome to the Reading page!                    ");
                        Rainbow();
                        Console.WriteLine("|");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("----------------------------------------------------------------");
                        Rainbow();
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
                            GetDate();
                            Console.Write("----------------------------------------------------------------");
                            Rainbow();
                            Console.WriteLine("|");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("                       Tech Books/Articles                        ");
                            Rainbow();
                            Console.WriteLine("|");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("----------------------------------------------------------------");
                            Rainbow();
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
                                // i = 3;
                            }

                            if (TechBooksAndArticlesNumberSelected == 3)
                            {
                                // i = 2;
                            }
                        }
                        
                    if (ReadingNumberSelected == 2)
                        {
                            GetDate();
                            Console.Write("----------------------------------------------------------------");
                            Rainbow();
                            Console.WriteLine("|");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("                           Casual Reading                         ");
                            Rainbow();
                            Console.WriteLine("|");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("----------------------------------------------------------------");
                            Rainbow();
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
            if (NumberSelected == 3)
                { 
                    GetDate();
                    Console.Write("----------------------------------------------------------------");
                    Rainbow();
                    Console.WriteLine("|");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("                Welcome to the Vocabulary page!                   ");
                    Rainbow();
                    Console.WriteLine("|");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("----------------------------------------------------------------");
                    Rainbow();
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
                    GetDate();
                    Console.Write("----------------------------------------------------------------");
                    Rainbow();
                    Console.WriteLine("|");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("                 Welcome to the Exercise page!                    ");
                    Rainbow();
                    Console.WriteLine("|");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("----------------------------------------------------------------");
                    Rainbow();
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
                    GetDate();
                    Console.Write("----------------------------------------------------------------");
                    Rainbow();
                    Console.WriteLine("|");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("                     Welcome to the Work page!                    ");
                    Rainbow();
                    Console.WriteLine("|");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("----------------------------------------------------------------");
                    Rainbow();
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
                    GetDate();
                    Console.Write("----------------------------------------------------------------");
                    Rainbow();
                    Console.WriteLine("|");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("                 Welcome to the Stat page!                        ");
                    Rainbow();
                    Console.WriteLine("|");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("----------------------------------------------------------------");
                    Rainbow();
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
                    }
                }
            Console.ResetColor();
            Console.Clear();
        }

        public static void CenterDate()
        {
            int CenterDateClock = 0;
            do
            {
                Console.Write(" ");
                CenterDateClock+=1;
            }
            while (CenterDateClock <27);
        }

    
        public static void Rainbow()
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
            x += 1;
        }

        public static void GetDate()
        {   
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            Console.ForegroundColor = ConsoleColor.White;
            TopndBottomBorder();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            CenterDate();
            Console.Write(date.ToString("MM/dd/yyyy"));
            CenterDate();
            Console.ForegroundColor = ConsoleColor.White;
            Rainbow();
            Console.WriteLine("|");
            Console.ForegroundColor = ConsoleColor.White;
            
        }

        public static void TopndBottomBorder ()
        {
            int RainbowClock = 0;
            do
            {
                Rainbow();
                Console.Write("_");
                RainbowClock+=1;
            }
            while(RainbowClock<66);
            Console.WriteLine("");
            Console.Write("|");
            
        }

        public static int HomePage()
        {
            // i=i+1;
            // int x=1;
            int NumberSelected = 0;
            List<string> Categories = new List<string>();
            int NumberID = 1;
            GetDate(); 
            Rainbow();
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("----------------------------------------------------------------");
            Rainbow();
            Console.WriteLine("|");
            Rainbow();
            Console.Write("|");
            CenterDate();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("HOMEPAGE  ");
            CenterDate();
            Rainbow();
            Console.WriteLine("|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|");
            Console.Write("----------------------------------------------------------------");
            Rainbow();
            Console.WriteLine("|");
            Categories.Add("Coding");
            Categories.Add("Reading");
            Categories.Add("Vocabulary");
            Categories.Add("Exercise");
            Categories.Add("Work");
            Categories.Add("Stats");
            
            foreach (string Category in Categories)
            {
                
                Rainbow();
                Console.Write("|");
                CenterDate();
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
                while(characterlength<34);
                Rainbow();
                Console.WriteLine("|");
            
            }
            Rainbow();
            int HomeRainbowClock = 0;
            Console.Write("|");
            do
                {
                    Rainbow();       
                    Console.Write("_");
                    HomeRainbowClock+=1;
                }
            while(HomeRainbowClock<64);
            Rainbow();
            Console.WriteLine("|");
            NumberSelected = Convert.ToInt32(Console.ReadLine());
            return NumberSelected;

        }
    }

}
