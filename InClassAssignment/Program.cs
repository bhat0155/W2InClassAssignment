// See https://aka.ms/new-console-template for more information

using InClassAssignment;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Ekam!");
        var book = new Book("deep work", "Carl Newport", "2014");
       Console.WriteLine(book.DisplayInfo());

       var student = new Student();
       student.Name = "Ekam";
       student.Grade = 2;
       
       Console.WriteLine((student.Name));
       Console.WriteLine((student.Grade));
       Console.WriteLine((student.IsPassing()));
       
       Engine engine = new Engine();
       engine.HorsePower = 440;
       
       Car car = new Car();
       car.Model = "Mustang";
       car.Engine = engine;
        Console.WriteLine(car.Describe());
        
    Console.WriteLine(Vowels.countVowels("Ekam"));
    Console.WriteLine(Vowels.countVowels("ttt"));

    }
    
}
