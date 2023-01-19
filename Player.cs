internal class Player
{
    Random rng = new Random();
    private int baseHealth = rng.next(1,21);
    private int classHealth;
    private int baseStrength = rng.next(1,21);
    private int classStrength;
    private int baseSpeed = rng.next(1,21);
    private int classSpeed;
    private int baseDex = rng.next(1,21);
    private int classDex;
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
    public void display_character()
    {
        System.Console.WriteLine("Class: " + classNames[classID]);
        System.Console.WriteLine("\n Health: {0}\n Strength: {1}");
    }
}