public class Book
{
    String title;
    String author;
    String published;
    public Book(String title, String author, String published)
    {
        this.title = title;
        this.author = author;
        this.published = published;
    }

   public String DisplayInfo()
    {
        return $"Title: {title}\nAuthor: {author}\nYear Published: {published}";
    }
}
