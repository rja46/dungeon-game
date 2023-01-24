internal class Map
{
    Random rng = new Random();
    Room[] rooms;
    public Map(int numRooms)
    {
        int currentX = 0;
        int currenty = 0;
        int pos;
        int nextDoor;
        rooms = new Room[numRooms];
        rooms[0] = new Room(0,0,0);
        for (int i = 1; i < numRooms; i++)
        {
            do
            {
                pos = rng.Next(4);
            }
            while (rooms[i - 1].walls[pos] != "D");
            nextDoor = pos;
            switch(nextDoor)
            {
                case 0:
                    currenty++;
                    nextDoor = 2;
                break;
                case 1:
                    currentX++;
                    nextDoor = 3;
                break;
                case 2:
                    currenty--;
                    nextDoor = 0;
                break;
                case 3:
                    currentX--;
                    nextDoor = 1;
                break;
            }
            rooms[i] = new Room(nextDoor,currentX,currenty);
        }
    }
    public void showMap()
    {
        Room[,] displayMap = new Room[rooms.Length,rooms.Length];
        for (int i = 0; i < rooms.Length; i++)
        {
            displayMap[rooms[i].x,rooms[i].y] = rooms[i];
        }
        for (int i = 0; i < rooms.Length; i++)
        {
            for (int j = 0; j < rooms.Length; j++)
            {
                try
                {
                    displayMap[i,j].showRoom();
                }
                catch
                {
                    System.Console.WriteLine(         );
                    System.Console.WriteLine(         );
                    System.Console.WriteLine(         );
                }
            }
        }
    }
}