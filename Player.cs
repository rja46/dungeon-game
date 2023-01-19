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
        baseHealth = rng.Next(1, 21);
        baseStrength = rng.Next(1, 21);
        baseSpeed = rng.Next(1, 21);
        baseDex = rng.Next(1, 21);
        System.Console.WriteLine("Choose a class:");
        System.Console.WriteLine("[1] Warrior");
        System.Console.WriteLine("[2] Assassin");
        System.Console.WriteLine("[3] Mage");
        System.Console.Write("\nEnter your choice: ");
        classID = Convert.ToInt32(Console.ReadLine());
        classID--;
        if (classID == 0)
        {
            classHealth = rng.Next(1, 6);
            classStrength = rng.Next(1, 6);
        }
        else if (classID == 1)
        {
            classSpeed = rng.Next(1, 6);
            classDex = rng.Next(1, 6);
        }
        else if (classID == 2)
        {
            classHealth = rng.Next(1, 6);
            classDex = rng.Next(1, 6);
        }
        Console.Clear();
        display_character();
    }
    public void display_character()
    {
        System.Console.WriteLine("Class:    " + classNames[classID]);
        System.Console.WriteLine("Health:   " + baseHealth.ToString().PadLeft(2, '0') + " + " + classHealth.ToString().PadLeft(2, '0'));
        System.Console.WriteLine("Strength: " + baseStrength.ToString().PadLeft(2, '0') + " + " + classStrength.ToString().PadLeft(2, '0'));
        System.Console.WriteLine("Speed:    " + baseSpeed.ToString().PadLeft(2, '0') + " + " + classSpeed.ToString().PadLeft(2, '0'));
        System.Console.WriteLine("Dex:      " + baseDex.ToString().PadLeft(2, '0') + " + " + classDex.ToString().PadLeft(2, '0'));
    }
}