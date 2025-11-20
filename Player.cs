namespace CSharpTasks
{
    // Task 4: Constructors
    public class Player
    {
        public string PlayerName = "";
        public int Level;
        public int Health;

        // Default constructor
        public Player()
        {
            Console.WriteLine("Default constructor has been called");
        }

        // Parameterized constructor
        public Player(string name, int level, int health)
        {
            PlayerName = name;
            Level = level;
            Health = health;
        }
    }
}