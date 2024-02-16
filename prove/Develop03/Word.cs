//Purpose of this class:
//Keeps track of a single word and whether it is shown or hidden.


public class Word {

    //This class will need a constructor
    //Accept the text of a word and save it as an attribute
    //Will also set if the word is visible or hidden

    private bool hidden;
    public bool Hidden {
        get {return hidden;}
        set {hidden = value;}
    }
    private string word;

}