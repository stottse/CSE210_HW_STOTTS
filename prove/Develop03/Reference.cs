//Purpose of this class:
//Keeps track of the book, chapter, and verse information.


public class Reference{

    private string __book;
    public string Book {
        get {return __book;}
        set {__book = value;}
    }

    private int __chapter;
    public int Chapter {
        get {return __chapter;}
        set {__chapter = value;}
    }
    
    //This class will need one constructor for a single verse
    public Reference(string book, int chapter, int startVerse){
        this.__book = book;
        this.__chapter = chapter;
        // this.startVerse = startVerse;
        // this.endVerse = 0;
    }

    //This class will need another constructor for multiple verses
    public Reference(string book, int chapter, int startVerse, int endVerse){
        this.__book = book;
        this.__chapter = chapter;
        // this.startVerse = startVerse;
        // this.endVerse = endVerse;
    }

}