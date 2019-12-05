using Unity;
using System.Collection;

public class ActiveStateToggler : MonoBehaviour {
   public string Name 
   { get; set; }

   public decimal Weapon
   { get; set; }
}

class Program
{
   static void Main(string[] args)
   {
      var item = new Object{ Name = "Sword", Weapon = 2.2m };
      gameObject.SetActive (!gameObject.activeSelf);
   }
}
