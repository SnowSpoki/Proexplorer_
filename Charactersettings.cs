using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Character_setting
{
    private static int currentID;
    protected int ID { get; set; }
    protected string Character { get; set; }
    protected string Speed { get; set; }
    protected TimeSpan jobLength { get; set; }

    public Character_setting()
    {
        ID = 1;
        Character = "Default Character";
        Speed = "Default Speed.";
        jobLength = new TimeSpan();
    }

   
    public Character_setting(string Character, string desc, TimeSpan joblen)
    {
        this.ID = GetNextID();
        this.Character = Character;
        this.Speed = desc;
        this.jobLength = joblen;
    }

    static Character_setting()
    {
        currentID = 0;
    }
    protected int GetNextID()
    {
        return ++currentID;
    }
    public void Update(string Character, TimeSpan joblen)
    {
        this.Character = Character;
        this.jobLength = joblen;
    }

    public override string ToString()
    {
        return $"{this.ID} - {this.Character}";
    }
}

public class ChangeRequest : Character_setting
{
    protected int originalItemID { get; set; }

    public ChangeRequest() { }

.
    public ChangeRequest(string Character, string desc, TimeSpan jobLen,
                         int originalID)
    {
        this.ID = GetNextID();
        this.Character = Character;
        this.Speed = desc;
        this.jobLength = jobLen;

        this.originalItemID = originalID;
    }
}

class Program
{
    static void Main()
    {
        
        Character_setting item = new Character_setting("All good",
                                     new TimeSpan(3, 4, 0, 0));
.
        ChangeRequest change = new ChangeRequest(" Bad. Change",
                                                 new TimeSpan(4, 0, 0),
                                                 1);

        Console.WriteLine(item.ToString());
        change.Update("Update",
            new TimeSpan(4, 0, 0));

  
    }
}
