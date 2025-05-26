namespace InClassAssignment;

public class Vowels
{
    public static int countVowels(string input)
    {
        var count = 0;
        string vowels = "aeiou";

        foreach (var c in input.ToLower())
        {
            if (vowels.Contains(c))
            {
                count++;
            }
            
        }
        return count;
        
        
    }
    
}