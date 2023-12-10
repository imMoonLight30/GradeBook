using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace GradeBookApp
{
    public class Book
    {
        //constructor
        public Book(string name)
        {
            grades= new List<double>();
            this.name=name;
        }
        //members
        private List<double> grades;
        private string name;
        //methods
        public void AddGrade(double grade)
        {
            if(grade>=0 && grade<=100)
            {
                //Console.WriteLine("grade in range");
                grades.Add(grade);
            }
        }
        public List<double> GetGrades(){
            return grades;
        }
        internal void ShowStatics()
        {
            double sum=0;
            double low_num = double.MaxValue;
            double high_num = double.MinValue;

        foreach(double num in grades){
            sum += num;
            high_num = Math.Max(high_num, num);
            low_num = Math.Min(low_num,num);
        }
        double avg = sum/grades.Count;
        Console.WriteLine($"this is avrage of numbers - {avg}");
        Console.WriteLine($"this is lowest of numbers - {low_num}");
        Console.WriteLine($"this is highest of numbers - {high_num}");
        }
    }
}