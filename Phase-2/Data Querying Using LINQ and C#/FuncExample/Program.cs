using System;
using System.Collections.Generic;

namespace FuncExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Student() { ID = 0, Name = "Test" };
            var students = new List<Student>(){
                new Student{ID=1, Name="Tim"},
                new Student{ID=2, Name="Ella"},
                new Student{ID=3, Name="Tom"}
            };

            Func<Student, string> func1 = GetStudentInfo;
            var info0 = func1(test);
            System.Console.WriteLine(info0);

            Func<Student, string> func2 = student => $"ID: {student.ID}  Name: {student.Name}";
            var info1 = func2(test);
            System.Console.WriteLine();

            var infos = Select(students, student => $"ID: {student.ID}  Name: {student.Name}");
            foreach (var info in infos)
            {
                System.Console.WriteLine(info);
            }

            var infos2 = students.Select(student => $"ID: {student.ID}  Name: {student.Name}");

            foreach (var info in infos2)
            {
                System.Console.WriteLine(info);
            }
        }

        static string GetStudentInfo(Student student)
        {
            var info = $"ID: {student.ID}  Name: {student.Name}";
            return info;
        }

        static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> func)
        {
            var result = new List<TResult>();
            foreach (var item in source)
            {
                result.Add(func(item));
            }

            return result;
        }



    }

    public static class MyExtension
    {
        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> func)
        {
            var result = new List<TResult>();
            foreach (var item in source)
            {
                result.Add(func(item));
            }

            return result;
        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
