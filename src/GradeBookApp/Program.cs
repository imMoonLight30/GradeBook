namespace GradeBookApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var numbers = new[] {10.2, 10.3 , 10, 15};
        float sum=0;
        foreach(float num in numbers){
            sum += num;
        }
        float avg = sum/numbers.Length;
        Console.Write(avg);
    }
}
