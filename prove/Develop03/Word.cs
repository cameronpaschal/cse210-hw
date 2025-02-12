using System.ComponentModel.DataAnnotations;

public class Word {

    private string _word;
    private string _oldWord;
    private bool _hidden = false;

    public Word(string word) {
        _word = word;
        _oldWord = word;
    }

    public void SetWord(string word) {
        _word = word;
        _oldWord = word;
    }

    public string GetWord() {
        return _word;
    }

    public void SetHidden(bool hidden) {
        _hidden = hidden;
    }

    public bool GetHidden() {
        return _hidden;
    }

    public void HideWord(){
        int length = _word.Length;
        string newWord = null;
        
        for (int x = 1; x <= length; x++){
            newWord = newWord + "-";
        }
        _word = newWord;

        SetHidden(true);

    }

    public void ShowWord(){
        _word = _oldWord;
        SetHidden(false);
    }

    public void Display(){
        Console.Out.Write($"{_word} ");
    }

}