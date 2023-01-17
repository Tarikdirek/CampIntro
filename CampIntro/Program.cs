namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {            

            Course course1 = new Course() 
            { 
                CourseName = "C#",
                Trainer = "Engin Demiroğ",
                WatchingRate= 68,
            };

            Course course2 = new Course()
            {
                CourseName = "Java",
                Trainer = "Kerem Varış",
                WatchingRate = 64,
            };

            Course course3 = new Course()
            {
                CourseName = "Phyton",
                Trainer = "Berkay Bilgin",
                WatchingRate = 80,
            };

            //Console.WriteLine(course1.CourseName+ " : " + course1.Trainer);

            Course[] courses = new Course[] 
            { 
                course1, course2,course3 
            };

            Console.WriteLine();
            foreach (var c in courses)
            {
                Console.WriteLine(c.CourseName+": "+ c.Trainer);
            }
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string Trainer { get; set; }
        public int WatchingRate { get; set; } 
    }

    
}