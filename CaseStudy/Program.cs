using System;
using System.Linq;

namespace CaseStudy
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            var maxPoints = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var startPositions = Console.ReadLine().Trim().Split(' ');
            Position position = null;

            if (startPositions.Count() == 3)
            {
                var x = Convert.ToInt32(startPositions[0]);
                var y = Convert.ToInt32(startPositions[1]);
                var direction = (Directions)Enum.Parse(typeof(Directions), startPositions[2]);
                position = new Position(x,y,direction,maxPoints);
            }
            else
            {
                Console.WriteLine("Baslangic pozisyonu gecersizdir.");
            }

            var moves = Console.ReadLine().ToUpper();

            try
            {
                position.StartMoving(moves);
                Console.WriteLine($"{position.X} {position.Y} {position.Direction.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
