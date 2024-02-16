//Purpose for this part of the program:
//Keeps track of the reference and the text of the scripture. 
//Can hide words and get the rendered display of the text.

public class Scripture
{

//This will need a constructor to accept reference and text of the scripture
//Will need to pass List<Word> into this class or instead pass
//in the whole string and then separate out the words into a list
    private string text;
    public string Text {
        get {return text;}
        set {text = value;}
    }

    private Reference reference;
    public Reference Reference {
        get {return reference;}
        set {reference = value;}
    }

    private List<Word> words;

    // Generic Getters and Setters
    // public string GetText()
    // {
    //     return text;
    // }

    // public void SetText(string newText)
    // {
    //     text = newText;
    // }

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.text = text;
        string[] split = text.Split(" ");
        foreach(string word in split)
        {
            Word newWord = new Word();
            words.Append(newWord);
        }
    }

    //Creating a member function to display the scripture
    public void ScriptureDisplay(){

    }

}