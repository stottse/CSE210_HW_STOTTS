//Purpose of this class:
//Keeps track of the book, chapter, and verse information.


public class Reference{

    private string book;
    public string Book {
        get {return book;}
        set {book = value;}
    }

    private int chapter;
    public int Chapter {
        get {return chapter;}
        set {chapter = value;}
    }
    
    //This class will need one constructor for a single verse
    public Reference(string book, int chapter, int startVerse){
        this.book = book;
        this.chapter = chapter;
        // this.startVerse = startVerse;
        // this.endVerse = 0;
    }

    //This class will need another constructor for multiple verses
    public Reference(string book, int chapter, int startVerse, int endVerse){
        this.book = book;
        this.chapter = chapter;
        // this.startVerse = startVerse;
        // this.endVerse = endVerse;
    }

}