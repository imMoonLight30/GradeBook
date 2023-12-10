namespace GradeBookApp;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var book = new Book("chandra's");
        book.AddGrade(89.1);
        book.AddGrade(100);
        book.AddGrade(45.3);
        book.ShowStatics();

        //unit test


        //avarage work , and learning array and list.
        double[] arr= new double[5]; // array defination
        var arr2 = new float[5];
        var numbers = new[] {10.2, 10.3 , 10, 15};
        for(var a=0;a<5;a++){
            //Console.WriteLine("this is arrays"+arr[a]+" "+arr2[a]);
        }

        //List work
        List<double> grade= book.GetGrades();
        grade.Add(10.0);
    }
}
