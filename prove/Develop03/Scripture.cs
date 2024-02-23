//Purpose for this part of the program:
//Keeps track of the reference and the text of the scripture. 
//Can hide words and get the rendered display of the text.

public class Scripture
{

//This will need a constructor to accept reference and text of the scripture
//Will need to pass List<Word> into this class or instead pass
//in the whole string and then separate out the words into a list
    private string __text;
    public string Text {
        get {return __text;}
        set {__text = value;}
    }

    private Reference reference;
    public Reference Reference {
        get {return reference;}
        set {reference = value;}
    }

    private List<Word> words; // declaring

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
        this.__text = text;
        // Console.WriteLine(this.text);
        words = new List<Word>(); // initialization
        string[] split = this.__text.Split(" ");
        
        // int count = 0;
        foreach(string word in split)
        {
            // count ++;
            // Console.WriteLine($"count: {count}");
            Word newWord = new Word(word);
            words.Add(newWord);
        }
    }

    //Creating a member function to display the scripture
    public void ScriptureDisplay(){
        // Display each word in the "words" list if it is hidden, or display
        // underscores if it is hidden.
    
        // Console.WriteLine($"words.Count: {words.Count}");

        foreach(Word word in words){
            if(word.Hidden == false){
                Console.Write(word.Text);
            }
            else if (word.Hidden == true){
                foreach (char letter in word.Text){
                    Console.Write("_");
                }
            }
            Console.Write(" "); // Put a space between words
        }
    }
    public void HideRandomWord(){
        Random random = new Random();
        int i;

        do {
            i = random.Next(0, words.Count);
        } while(words[i].Hidden == true);

        // hide the word
        words[i].Hidden = true;
    }

}