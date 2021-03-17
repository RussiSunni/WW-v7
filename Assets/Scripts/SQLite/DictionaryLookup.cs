using SQLite4Unity3d;

public class DictionaryLookup
{

    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public string AnimationClipParameter { get; set; }
    public bool Subject { get; set; }
    public int AudioClipNumber { get; set; }


    public override string ToString()
    {
        return string.Format("[DL: Id={0}, Name={1}, AnimationClipParameter={2}], AudioClipNumber={3}", Id, Name, AnimationClipParameter, AudioClipNumber);
    }
}
