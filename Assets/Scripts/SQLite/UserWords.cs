using SQLite4Unity3d;

public class UserWords
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public string NumberOfUses { get; set; }



    // public override string ToString()
    // {
    //     return string.Format("[DL: Id={0}, Name={1}, AnimationClipParameter={2}]", Id, Name);
    // }
}
