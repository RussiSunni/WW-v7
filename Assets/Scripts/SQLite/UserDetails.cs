using System;
using SQLite4Unity3d;

public class UserDetails
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public DateTime DateStarted { get; set; }
    public string NativeLanguage { get; set; }
    public int Level { get; set; }


    // public override string ToString()
    // {
    //     return string.Format("[DL: Id={0}, Name={1}, AnimationClipParameter={2}]", Id, Name);
    // }
}
