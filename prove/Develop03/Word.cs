//Purpose of this class:
//Keeps track of a single word and whether it is shown or hidden.


public class Word {

    //This class will need a constructor
    //Accept the text of a word and save it as an attribute
    //Will also set if the word is visible or hidden

    private bool __hidden;
    public bool Hidden {
        get {return __hidden;}
        set {__hidden = value;}
    }
    private string __text;
    public string Text {
        get {return __text;}
        set {__text = value;}
    }

    public Word(string text){
        this.__text = text;
        this.__hidden = false; // by default, every word is not hidden. Only hide
        // words when the user presses "Enter" on the keyboard.
    }

}