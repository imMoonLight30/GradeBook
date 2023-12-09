using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}