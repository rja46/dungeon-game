internal class Player
{
    Random rng = new Random();
     private int health;
    private int strength;
    private int speed;
    private int dexterity;
    private int classID;
    private string[] classNames = {"Warrior", "Assassin", "Mage"};
    public Player()
    {
        System.Console.WriteLine("Choose a class:");
        System.Console.WriteLine("[1] Warrior");
        System.Console.WriteLine("[2] Assassin");
        System.Console.WriteLine("[3] Mage");
        System.Console.Write("Enter your choice: ");
        classID = Convert.ToInt32(Console.ReadLine());
        classID--;
        display_class();
    }
    public void display_class()
    {
        System.Console.WriteLine(classNames[classID]);
    }
}