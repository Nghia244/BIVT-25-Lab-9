using System;

namespace Lab9.Green
{
    public class Subject
    {
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int Credit { get; set; }

        public Subject() { }

        public Subject(string id, string name, int credit)
        {
            SubjectId = id;
            SubjectName = name;
            Credit = credit;
        }

        public void DisplaySubject()
        {
            Console.WriteLine($"ID: {SubjectId} | Name: {SubjectName} | Credits: {Credit}");
        }
    }
}
