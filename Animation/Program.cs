namespace Animation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] qatorlar = { "Telegram", "Instagram", "WhatsUp", "Twitter", "TikTok" };
            int cursor = 0;
            ConsoleKeyInfo key;

            while (true)
            {
                for (int i = 0; i < qatorlar.Length; i++)
                {
                    if (i == cursor)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"[{qatorlar[i]}]");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else
                        Console.WriteLine($" {qatorlar[i]}");
                }
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow && cursor > 0)
                    cursor--;
                else if (key.Key == ConsoleKey.DownArrow && cursor < qatorlar.Length - 1)
                    cursor++;
                Console.Clear();
            }
        }
    }
}
