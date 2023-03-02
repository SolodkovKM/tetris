using EntityesClass;
using Background;

namespace Tetris
{
    public class Game
    {
        static void Main(string[] args)
        {
            int[,] EmptyFone = new GameFone().matrix;
            GameFone fone = new GameFone();
            fone.PrintFone(EmptyFone);
            Entity entity = new Entity().CreateEntity();
            Console.WriteLine($"{entity.type} {entity.rotation} {entity.x} {entity.y}");
        }
    }
}