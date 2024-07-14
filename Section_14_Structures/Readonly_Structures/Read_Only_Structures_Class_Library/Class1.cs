public readonly struct Marvel
{
    //field 
    private readonly string _characterName;

    //public
    public string CharacterName
    {
        get { return _characterName; }
    }

    //public method
    public void PrintCharacterName()
    {
        System.Console.WriteLine(this.CharacterName);
        //this._characterName = "abc"; compile-time error
    }

    //constructor
    public Marvel(string characterName)
    {
        this._characterName = characterName;
    }
}