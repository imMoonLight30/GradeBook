using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace GradeBookApp
{
    public interface IBook
    {   
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name { get; }
    }
    public class NameObject :IBook
    {
        public NameObject(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            set;
        }

        public virtual void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public virtual Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
    public class Book : NameObject
    {
        //constructor
        public Book(string name) : base(name)
        {
            category = "constructor change it";
            grades= new List<double>();
            Name=name;
        }
        //members
        private List<double> grades;
        public readonly string category = "readonly variable";
        //methods
        public override void AddGrade(double grade)
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
        public Statistics ShowStatics()
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