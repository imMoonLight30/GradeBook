namespace GradeBookApp;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var book = new Book("chandra's");
        try{
        book.AddGrade(89.1);
        book.AddGrade(100);
        book.AddGrade(45.3);
        book.AddGrade(105);
        }catch(Exception ex){
            Console.WriteLine(ex);
        }
        var value =book.ShowStatics();
        Console.WriteLine("avg - "+value.avrage);
        Console.WriteLine("low - "+value.low);
        Console.WriteLine("high - "+value.high);
        Console.WriteLine("getter, setter - "+book.Name);
        Console.WriteLine("readonly variable "+book.category);
        //building type


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
