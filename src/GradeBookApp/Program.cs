namespace GradeBookApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        double[] arr= new double[5]; // array defination
        var arr2 = new float[5];
        for(var a=0;a<5;a++){
            Console.WriteLine("this is arrays"+arr[a]+" "+arr2[a]);
        }
        //avrage work
        var numbers = new[] {10.2, 10.3 , 10, 15};
        List<double> grade= new List<double>();
        grade.Add(10.0);
        Console.WriteLine(grade[0]);
        float sum=0;
        foreach(float num in numbers){
            sum += num;
        }
        float avg = sum/numbers.Length;
        Console.Write($"this is avrage of number - {avg}");
    }
}
