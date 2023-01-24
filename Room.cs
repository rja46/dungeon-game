internal class Room
{
    Random rng = new Random();
    public string[] walls = new string[4];
    public int x;
    public int y;
    //n = 0 e = 1 s = 2 w = 3
    public Room(int entryIndex, int x, int y)
    {
        this.x = x;
        this.y = y;
        for (int i = 0; i < 4; i++)
        {
            walls[i] = " ";
        }
        int doors = rng.Next(1,3);
        walls[entryIndex] = "D";
        for (int i = 0; i < doors; i++)
        {
            walls[i] = "D";
        }
    }
    public void showRoom()
    {
        System.Console.WriteLine("[ ][{0}][ ]",walls[0]);
        System.Console.WriteLine("[{0}][ ][{1}]",walls[3],walls[1]);
        System.Console.WriteLine("[ ][{0}][ ]",walls[2]);
    }
}