using System.Diagnostics.Tracing;

public class Video{

    //keep track of title, author, and length
    public string _title;
    public string _author;
    public double _length;
    public List<Comments> _comments = new List<Comments>();

    public int _comment_counts;

    public Video (string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;

    }

    //need a method for storing comments in a list and a method to count how many comments have been made

    public void store_Comments(string name, string text)
    {
        Comments newComment = new Comments(name, text);
        _comments.Add(newComment);


    }

    public int comment_Count()
    {

        return _comments.Count();
    }

    public void Display_Info()
    {
          Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Length: {_length} seconds");
            Console.WriteLine($"Number of Comments: {comment_Count()}");
            Console.WriteLine("Comments:");
            foreach (var comment in _comments)
            {
                Console.WriteLine($"- {comment._commenterName}: {comment._commentText}");
            }
            Console.WriteLine();

    }

}