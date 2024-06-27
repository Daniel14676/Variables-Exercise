namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Merek";
            int age = 123;
            char rune = 'A';
            bool open = true;
            double width = 10.5;
            decimal height = 20.5m;
            Console.WriteLine($"Hello, {name}! He who is {age} old, and approached the door saying {rune} " +
                $"as his password, which happens to be {open}ly the password. The door then opened, forming a hole " +
                $"{width} by {height}");
        }
    }
}
