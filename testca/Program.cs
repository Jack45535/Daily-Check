using System;
using System.Collections.Generic;


namespace calender_app
{
    class Program
    {
        private static int NumberID;
        private static int x;
        //MAIN--------------------------------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            int NumberSelected = 0;
            int ReadingNumberSelected = 0;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            NumberSelected = HomePage();
            if (NumberSelected == 1)
            {
                CodingPage();
            }

            if (NumberSelected == 2)
            {
                ReadingNumberSelected = ReadingPage();
                if (ReadingNumberSelected == 1)
                {
                    TechReadingPage();
                }
                if (ReadingNumberSelected == 2)
                {
                    CasualReadingPage();
                }
            }

            if (NumberSelected == 3)
            {
                VocabPage();
            }

            if (NumberSelected == 4)
            {
                ExercisePage();
            }

            if (NumberSelected == 5)
            {
                WorkPage();
            }

            if (NumberSelected == 6)
            {
                StatPage();
            }

            Console.ResetColor();
            Console.Clear();
        }
        //MAIN--------------------------------------------------------------------------------------------------------------------

        public static int HomePage()
        {
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
            List<string> Categories = new List<string>();
            int NumberID = 1;
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
                    characterlength += 1;
                }
                while (characterlength < 34);
                Rainbow();
                Console.WriteLine("|");
            }

        }
        //----------------------------------------------------------------------Tier 1 Coding

        public static int CodingPage()
        {
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
            List<string> Project = new List<string>();
            int NumberID = 1;
            Project.Add("Calender app");
            Project.Add("Underworld RPG");
            Project.Add("Underworld RPG website");
            Project.Add("Back");
            foreach (string Category in Project)
            {
                Rainbow();
                Console.Write("|");
                CenterDate();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(NumberID + ": ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(Category);

                NumberID += 1;
                int characterlength = Category.Length;
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
        //----------------------------------------------------------------------Tier 1 Reading
        public static int ReadingPage()
        {
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
            List<string> ReadingMaterial = new List<string>();
            int NumberID = 1;
            ReadingMaterial.Add("Tech");
            ReadingMaterial.Add("Leisure");
            ReadingMaterial.Add("Back");
            foreach (string Category in ReadingMaterial)
            {
                Rainbow();
                Console.Write("|");
                CenterDate();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(NumberID + ": ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(Category);

                NumberID += 1;
                int characterlength = Category.Length;
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
        //----------------------------------------------------------------------Tier 2 Reading (TECH)
        public static int TechReadingPage()
        {
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
                "Back",
                "Home"
            };
            foreach (string Category in TechBooksAndArticles)
            {
                Rainbow();
                Console.Write("|");
                CenterDate();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(NumberID + ": ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(Category);

                NumberID += 1;
                int characterlength = Category.Length;
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

        //----------------------------------------------------------------------Tier 2 Reading (LEISURE)

        public static int CasualReadingPage()
        {
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
                "Back",
                "Home"
            };
            foreach (string Category in CasualReading)
            {
                Rainbow();
                Console.Write("|");
                CenterDate();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(NumberID + ": ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(Category);

                NumberID += 1;
                int characterlength = Category.Length;
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

        //----------------------------------------------------------------------Tier 1 Vocab
        public static int VocabPage()
        {
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
                "Syntax",
                "English",
                "Other Langueges",
                "Back"
            };
            foreach (string Category in Vocab)
            {
                Rainbow();
                Console.Write("|");
                CenterDate();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(NumberID + ": ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(Category);

                NumberID += 1;
                int characterlength = Category.Length;
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
        //---------------------------------------------------------------------Tier 1 Exercise
        public static int ExercisePage()
        {
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
                "Hiking",
                "Pushups",
                "Pullups",
                "Gym",
                "Back"
            };
            foreach (string Category in Workout)
            {
                Rainbow();
                Console.Write("|");
                CenterDate();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(NumberID + ": ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(Category);

                NumberID += 1;
                int characterlength = Category.Length;
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
        //---------------------------------------------------------------------Tier 1 Work
        public static int WorkPage()
        {
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
                "Bartender",
                "Runner",
                "Intern at KC",
                "Back"
            };
            foreach (string Category in Jobs)
            {
                Rainbow();
                Console.Write("|");
                CenterDate();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(NumberID + ": ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(Category);

                NumberID += 1;
                int characterlength = Category.Length;
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
        //---------------------------------------------------------------------Tier 1 Stats
        public static int StatPage()
        {
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
                "Coding Projects",
                "Reading Selection",
                "Vocabulary Timespent",
                "Type of Workout",
                "Job",
                "Back"
            };
            foreach (string Category in StatCategories)
            {
                Rainbow();
                Console.Write("|");
                CenterDate();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(NumberID + ": ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(Category);

                NumberID += 1;
                int characterlength = Category.Length;
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
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("----------------------------------------------------------------");
            Rainbow();
            Console.WriteLine("|");
            Rainbow();
            Console.Write("|");
            CenterDate();
        }

        public static void BotOfHeader()
        {
            CenterDate();
            Rainbow();
            Console.WriteLine("|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|");
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
            do
            {
                Rainbow();
                Console.Write("_");
                RainbowClock += 1;
            }
            while (RainbowClock < 66);
            Console.WriteLine("");
            Console.Write("|");

        }

        public static void BottomBorder()
        {
            int RainbowClock = 0;
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
    }
}
