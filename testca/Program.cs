using System;
using System.Collections.Generic;


namespace calender_app
{
    class Program
    {
        private static int x;
        private static int i = 1;
        //MAIN--------------------------------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {

            int NumberSelected = 0;
            int ProjectNumberSelected = 0;
            int ReadingNumberSelected = 0;
            int TechBooksAndArticlesNumberSelected = 0;
            int CasualBooksAndArticlesNumberSelected = 0;
            int VocabNumberSelected = 0;
            int WorkoutNumberSelected = 0;
            int WorkNumberSelected = 0;
            int StatNumberSelected = 0;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                NumberSelected = HomePage();
                if (NumberSelected == 1)
                {
                    Console.Clear();
                    ProjectNumberSelected = CodingPage();
                    if (ProjectNumberSelected == 4)
                    {
                        Console.Clear();
                    }
                    if (ProjectNumberSelected == 5)
                    {
                        Console.Clear();
                        i = 0;
                    }
                }

                if (NumberSelected == 2)
                {
                    i = 2;
                    do
                    {
                        Console.Clear();
                        ReadingNumberSelected = ReadingPage();
                        if (ReadingNumberSelected == 1)
                        {
                            Console.Clear();
                            TechBooksAndArticlesNumberSelected = TechReadingPage();
                            if (TechBooksAndArticlesNumberSelected == 2)
                            {
                                Console.Clear();
                                i = 2;
                            }
                            if (TechBooksAndArticlesNumberSelected == 3)
                            {
                                Console.Clear();
                                i = 1;
                            }
                            if (TechBooksAndArticlesNumberSelected == 4)
                            {
                                Console.Clear();
                                i = 0;
                            }
                        }
                        if (ReadingNumberSelected == 2)
                        {
                            Console.Clear();
                            CasualBooksAndArticlesNumberSelected =CasualReadingPage();
                            if (CasualBooksAndArticlesNumberSelected == 2)
                            {
                                Console.Clear();
                                i = 2;
                            }
                            if (CasualBooksAndArticlesNumberSelected == 3)
                            {
                                Console.Clear();
                                i = 1;
                            }
                            if (CasualBooksAndArticlesNumberSelected == 4)
                            {
                                Console.Clear();
                                i = 0;
                            }
                        }
                        if (ReadingNumberSelected == 3)
                        {
                            Console.Clear();
                            i = 1;
                        }
                        if (ReadingNumberSelected == 4)
                        {
                            Console.Clear();
                            i = 0;
                        }
                    } while (i == 2);
                }

                if (NumberSelected == 3)
                {
                    Console.Clear();
                    VocabNumberSelected = VocabPage();
                    if (VocabNumberSelected == 5)
                    {
                        Console.Clear();
                    }

                }

                if (NumberSelected == 4)
                {
                    Console.Clear();
                    WorkoutNumberSelected = ExercisePage();
                    if (WorkoutNumberSelected == 6)
                    {
                        Console.Clear();
                    }
                }

                if (NumberSelected == 5)
                {
                    Console.Clear();
                    WorkNumberSelected = WorkPage();
                    if (WorkNumberSelected == 5)
                    {
                        Console.Clear();
                    }

                }

                if (NumberSelected == 6)
                {
                    Console.Clear();
                    StatNumberSelected = StatPage();
                    if (StatNumberSelected == 5)
                    {
                        Console.Clear();
                    }
                }

                if (NumberSelected == 7)
                {
                    i =0;
                }
            } while (i==1);
            Console.ResetColor();
            Console.Clear();
        }
        //MAIN--------------------------------------------------------------------------------------------------------------------

        public static int HomePage()
        {
            TopSpacer();
            int NumberSelected = 0;
            TopOfHeader();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("HOMEPAGE  ");
            BotOfHeader();
            HomeListandBorders();
            Rainbow();
            BottomBorder();
            NumberSelected = Convert.ToInt32(Console.ReadLine());
            return NumberSelected;

        }

        public static void HomeListandBorders()
        {
            int NumberID = 1;
            List<string> Categories = new List<string>
            {
                "Coding",
                " ",
                "Reading",
                " ",
                "Vocabulary",
                " ",
                "Exercise",
                " ",
                "Work",
                " ",
                "Stats",
                " ",
                "Exit"
            };
            foreach (string Category in Categories)
            {
                int characterlength = Category.Length;
                if (Category.Length == 1)
                {
                    SideSpacer();
                    Rainbow();
                    Console.Write("|");

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 65);
                    Rainbow();
                    Console.WriteLine("|");
                }
                else
                {
                    SideSpacer();
                    Rainbow();
                    Console.Write("|");
                    CenterDate();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(NumberID + ": ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Category);

                    NumberID += 1;

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 34);
                    Rainbow();
                    Console.WriteLine("|");
                }
            }

        }
        //----------------------------------------------------------------------Tier 1 Coding

        public static int CodingPage()
        {
            TopSpacer();
            int ProjectNumberSelected;
            TopOfHeader();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("  CODING  ");
            BotOfHeader();
            CodingListandBorders();
            Rainbow();
            BottomBorder();
            ProjectNumberSelected = Convert.ToInt32(Console.ReadLine());
            return ProjectNumberSelected;
        }

        public static void CodingListandBorders()
        {
            List<string> Project = new List<string>
            {
                "Calender app",
                " ",
                "Underworld RPG",
                " ",
                "Underworld RPG website",
                " ",
                "Home",
                " ",
                "Exit"
            };
            int NumberID = 1;
            foreach (string Category in Project)
            {
                int characterlength = Category.Length;
                if (Category.Length == 1)
                {
                    SideSpacer();
                    Rainbow();
                    Console.Write("|");

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 65);
                    Rainbow();
                    Console.WriteLine("|");
                }
                else
                {
                    SideSpacer();
                    Rainbow();
                    Console.Write("|");
                    CenterDate();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(NumberID + ": ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(Category);

                    NumberID += 1;

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 34);
                    Rainbow();
                    Console.WriteLine("|");
                }
            }

        }
        //----------------------------------------------------------------------Tier 1 Reading
        public static int ReadingPage()
        {
            TopSpacer();
            int ReadingNumberSelected;
            TopOfHeader();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("  READING ");
            BotOfHeader();
            ReadingListandBorders();
            Rainbow();
            BottomBorder();
            ReadingNumberSelected = Convert.ToInt32(Console.ReadLine());
            return ReadingNumberSelected;
        }

        public static void ReadingListandBorders()
        {
            int NumberID = 1;
            List<string> ReadingMaterial = new List<string>
            {
                "Tech",
                " ",
                "Leisure",
                " ",
                "Home",
                " ",
                "Exit"
            };
            foreach (string Category in ReadingMaterial)
            {
                int characterlength = Category.Length;
                if (Category.Length == 1)
                {
                    SideSpacer();
                    Rainbow();
                    Console.Write("|");

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 65);
                    Rainbow();
                    Console.WriteLine("|");
                }
                else
                {
                    SideSpacer();
                    Rainbow();
                    Console.Write("|");
                    CenterDate();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(NumberID + ": ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(Category);

                    NumberID += 1;

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 34);
                    Rainbow();
                    Console.WriteLine("|");
                }
            }
        }
        //----------------------------------------------------------------------Tier 2 Reading (TECH)
        public static int TechReadingPage()
        {
            TopSpacer();
            int TechBooksAndArticlesNumberSelected;
            TopOfHeader();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("   BOOKS   ");
            BotOfHeader();
            TechReadingListandBorders();
            Rainbow();
            BottomBorder();
            TechBooksAndArticlesNumberSelected = Convert.ToInt32(Console.ReadLine());
            return TechBooksAndArticlesNumberSelected;
        }

        public static void TechReadingListandBorders()
        {
            int NumberID = 1;
            List<string> TechBooksAndArticles = new List<string>
            {
                "New Book/Article",
                " ",
                "Back",
                " ",
                "Home",
                " ",
                "Exit"
            };
            foreach (string Category in TechBooksAndArticles)
            {
                int characterlength = Category.Length;
                if (Category.Length == 1)
                {
                    SideSpacer();
                    Rainbow();
                    Console.Write("|");

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 65);
                    Rainbow();
                    Console.WriteLine("|");
                }
                else
                {
                    SideSpacer();
                    Rainbow();
                    Console.Write("|");
                    CenterDate();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(NumberID + ": ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(Category);

                    NumberID += 1;

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 34);
                    Rainbow();
                    Console.WriteLine("|");
                }
            }
        }

        //----------------------------------------------------------------------Tier 2 Reading (LEISURE)

        public static int CasualReadingPage()
        {
            TopSpacer();
            int CasualBooksAndArticlesNumberSelected;
            TopOfHeader();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("   BOOKS   ");
            BotOfHeader();
            TechReadingListandBorders();
            Rainbow();
            BottomBorder();
            CasualBooksAndArticlesNumberSelected = Convert.ToInt32(Console.ReadLine());
            return CasualBooksAndArticlesNumberSelected;
        }

        public static void CasualReadingListandBorders()
        {
            int NumberID = 1;
            List<string> CasualReading = new List<string>
            {
                "New Book/Article",
                " ",
                "Back",
                " ",
                "Home",
                " ",
                "Exit"
            };
            foreach (string Category in CasualReading)
            {
                int characterlength = Category.Length;
                if (Category.Length == 1)
                {
                    SideSpacer();
                    Rainbow();
                    Console.Write("|");

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 65);
                    Rainbow();
                    Console.WriteLine("|");
                }
                else
                {
                    SideSpacer();
                    Rainbow();
                    Console.Write("|");
                    CenterDate();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(NumberID + ": ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(Category);

                    NumberID += 1;

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 34);
                    Rainbow();
                    Console.WriteLine("|");
                }
            }
        }

        //----------------------------------------------------------------------Tier 1 Vocab
        public static int VocabPage()
        {
            TopSpacer();
            int VocabNumberSelected;
            TopOfHeader();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("  VOCAB   ");
            BotOfHeader();
            VocabListandBorders();
            Rainbow();
            BottomBorder();
            VocabNumberSelected = Convert.ToInt32(Console.ReadLine());
            return VocabNumberSelected;
        }

        public static void VocabListandBorders()
        {
            int NumberID = 1;
            List<string> Vocab = new List<string>
            {
                "Tech Jargon",
                " ",
                "Syntax",
                " ",
                "English",
                " ",
                "Other Langueges",
                " ",
                "Home",
                " ",
                "Exit"
            };
            foreach (string Category in Vocab)
            {
                
                int characterlength = Category.Length;
                if (Category.Length == 1)
                {
                    SideSpacer();
                    Rainbow();
                    Console.Write("|");

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 65);
                    Rainbow();
                    Console.WriteLine("|");
                }
                else
                {
                    SideSpacer();
                    Rainbow();
                    Console.Write("|");
                    CenterDate();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(NumberID + ": ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(Category);

                    NumberID += 1;

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 34);
                    Rainbow();
                    Console.WriteLine("|");
                }
            }
        }
        //---------------------------------------------------------------------Tier 1 Exercise
        public static int ExercisePage()
        {
            TopSpacer();
            int WorkoutNumberSelected;
            TopOfHeader();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" EXERCISE ");
            BotOfHeader();
            ExerciseListandBorders();
            Rainbow();
            BottomBorder();
            WorkoutNumberSelected = Convert.ToInt32(Console.ReadLine());
            return WorkoutNumberSelected;
        }

        public static void ExerciseListandBorders()
        {
            int NumberID = 1;
            List<string> Workout = new List<string>
            {
                "Running",
                " ",
                "Hiking",
                " ",
                "Pushups",
                " ",
                "Pullups",
                " ",
                "Gym",
                " ",
                "Home",
                " ",
                "Exit"
            };
            foreach (string Category in Workout)
            {
                int characterlength = Category.Length;
                if (Category.Length == 1)
                {
                    SideSpacer();
                    Rainbow();
                    Console.Write("|");

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 65);
                    Rainbow();
                    Console.WriteLine("|");
                }
                else
                {
                    SideSpacer();
                    Rainbow();
                    Console.Write("|");
                    CenterDate();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(NumberID + ": ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(Category);

                    NumberID += 1;

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 34);
                    Rainbow();
                    Console.WriteLine("|");
                }
            }
        }
        //---------------------------------------------------------------------Tier 1 Work
        public static int WorkPage()
        {
            TopSpacer();
            int WorkNumberSelected;
            TopOfHeader();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("  WORK    ");
            BotOfHeader();
            VocabListandBorders();
            Rainbow();
            BottomBorder();
            WorkNumberSelected = Convert.ToInt32(Console.ReadLine());
            return WorkNumberSelected;
        }

        public static void WorkListandBorders()
        {
            int NumberID = 1;
            List<string> Jobs = new List<string>
            {
                "Waiter",
                " ",
                "Bartender",
                " ",
                "Runner",
                " ",
                "Intern at KC",
                " ",
                "Home",
                " ",
                "Exit"
            };
            foreach (string Category in Jobs)
            {
                int characterlength = Category.Length;
                if (Category.Length == 1)
                {
                    SideSpacer();
                    Rainbow();
                    Console.Write("|");

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 65);
                    Rainbow();
                    Console.WriteLine("|");
                }
                else
                {
                    SideSpacer();
                    Rainbow();
                    Console.Write("|");
                    CenterDate();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(NumberID + ": ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(Category);

                    NumberID += 1;

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 34);
                    Rainbow();
                    Console.WriteLine("|");
                }
            }
        }
        //---------------------------------------------------------------------Tier 1 Stats
        public static int StatPage()
        {
            TopSpacer();
            int StatNumberSelected;
            TopOfHeader();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("  STATS   ");
            BotOfHeader();
            VocabListandBorders();
            Rainbow();
            BottomBorder();
            StatNumberSelected = Convert.ToInt32(Console.ReadLine());
            return StatNumberSelected;
        }

        public static void StatListandBorders()
        {
            int NumberID = 1;
            List<string> StatCategories = new List<string>
            {
                "Breakdowns",
                " ",
                "Coding Projects",
                " ",
                "Reading Selection",
                " ",
                "Vocabulary Timespent",
                " ",
                "Type of Workout",
                " ",
                "Job",
                " ",
                "Home",
                " ",
                "Exit"
            };
            foreach (string Category in StatCategories)
            {
                int characterlength = Category.Length;
                if (Category.Length == 1)
                {

                    Rainbow();
                    Console.Write("|");

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 65);
                    Rainbow();
                    Console.WriteLine("|");
                }
                else
                {

                    Rainbow();
                    Console.Write("|");
                    CenterDate();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(NumberID + ": ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(Category);

                    NumberID += 1;

                    do
                    {
                        Console.Write(" ");
                        characterlength += 1;
                    }
                    while (characterlength < 34);
                    Rainbow();
                    Console.WriteLine("|");
                }
            }
        }
        // ---------------------------------------------------------------------Functions

        public static void CenterDate()
        {
            int CenterDateClock = 0;
            do
            {
                Console.Write(" ");
                CenterDateClock += 1;
            }
            while (CenterDateClock < 27);
        }





        public static void TopOfHeader()
        {
            GetDate();
            Rainbow();
            SideSpacer();
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("----------------------------------------------------------------");
            Rainbow();
            Console.WriteLine("|");
            Rainbow();
            SideSpacer();
            Console.Write("|");
            CenterDate();
        }

        public static void BotOfHeader()
        {
            CenterDate();
            Rainbow();
            Console.WriteLine("|");
            SideSpacer();
            Rainbow();
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("----------------------------------------------------------------");
            Rainbow();
            Console.WriteLine("|");
        }

        public static void Rainbow()
        {

            if (x == 1)
            {
                Console.ForegroundColor = ConsoleColor.White;

            }

            if (x == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

            }

            if (x == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;

            }

            if (x == 4)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;


            }

            if (x == 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;

            }

            if (x == 6)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;


            }

            if (x == 7)
            {
                Console.ForegroundColor = ConsoleColor.Gray;

            }

            if (x == 8)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                x -= 8;
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

        public static void TopndBottomBorder()
        {
            int RainbowClock = 0;
            SideSpacer();
            do
            {
                Rainbow();
                Console.Write("_");
                RainbowClock += 1;
            }
            while (RainbowClock < 66);
            Console.WriteLine("");
            SideSpacer();
            Console.Write("|");

        }

        public static void BottomBorder()
        {
            int RainbowClock = 0;
            SideSpacer();
            Console.Write("|");
            do
            {
                Rainbow();
                Console.Write("_");
                RainbowClock += 1;
            }
            while (RainbowClock < 64);
            Rainbow();
            Console.WriteLine("|");
        }

        public static void TopSpacer()
        {
            int push = 0;
            do
            {
                Console.WriteLine("");
                push -= 1;
            }
            while (push > -5);

        }

        public static void SideSpacer()
        {
            int push = 0;
            do
            {
                Console.Write(" ");
                push -= 1;
            }
            while (push > -25);
        }
    }
}
