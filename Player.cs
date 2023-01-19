internal class Player
{
    Random rng = new Random();
    private int baseHealth;
    private int classHealth;
    private int baseStrength;
    private int classStrength;
    private int baseSpeed;
    private int classSpeed;
    private int baseDex;
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
        display_character();
    }
    public void display_character()
    {
        System.Console.WriteLine("Class: " + classNames[classID]);
        System.Console.WriteLine("Health: " + baseHealth);
        System.Console.WriteLine("Strength: " + baseStrength);
        System.Console.WriteLine("Speed: " + baseSpeed);
        System.Console.WriteLine("Dex: " + baseDex);
    }
}