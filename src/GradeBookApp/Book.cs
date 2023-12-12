using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace GradeBookApp
{
    public class Book
    {
        //constructor
        public Book(string name)
        {
            category = "constructor change it";
            grades= new List<double>();
            Name=name;
        }
        //members
        private List<double> grades;
        //private string Name;
        public string Name
        {
            get; private set;
        }
        public readonly string category = "readonly variable";
        //methods
        public void AddGrade(double grade)
        {
            if(grade>=0 && grade<=100)
            {
                //Console.WriteLine("grade in range");
                grades.Add(grade);
            }else{
                throw new ArgumentException("grade is out of range");
            }
        }
        public string AddGrade(double grade, string n){

            return "overloading";
        }
        public List<double> GetGrades(){
            return grades;
        }
        internal Statistics ShowStatics()
        {
            var stats= new Statistics();
            double sum=0;
            stats.low = double.MaxValue;
            stats.high = double.MinValue;

        foreach(double num in grades){
            sum += num;
            stats.low = Math.Max(stats.low, num);
            stats.high = Math.Min(stats.high,num);
        }
        stats.avrage = sum/grades.Count;
        return stats;
        }
    }
}