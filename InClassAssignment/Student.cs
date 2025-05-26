namespace InClassAssignment;

public class Student
{
    private string name;
    private int grade;
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Grade
    {
        get { return grade; }
        set
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine("Grade must be between 0 and 100.");
            }
            else
            {
               grade = value;
            }
            
        }
    }

    public bool IsPassing()
    {
        if (grade >= 50)
        {
            return true;
        }else{ return false;}
        
        
    }
    
    
}