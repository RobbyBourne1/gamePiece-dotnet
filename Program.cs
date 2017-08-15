using System;

namespace gamePiece_dotnet
{
    class Program
    {
        public class GamePiece
        {
            public int PositionX { get; set; } = 0;
            public int PositionY { get; set; } = 0;
            public bool Frozen { get; set; } = false;
            public string Name { get; set; }
            public string Color { get; set; }

            public Boolean freeze()
            {
                Frozen = true;
                return Frozen;
            }

            public Boolean unFreeze()
            {
                Frozen = false;
                return Frozen;
            }
            public int MoveForward()
            {
             if (Frozen == false)
             {
                 PositionX++;
                 PositionY++;
                 return PositionX;
             }
             else
             {
                 return PositionX;
             }
            }
            
            public int MoveBack()
            {
                if (Frozen == false)
                {
                    PositionX--;
                    PositionY--;
                    return PositionX;
                }
                else
                {
                    return PositionX;
                }
            }
            public override string ToString()
            {
                if (Frozen == false)
                {
                   return $"{Name} {Color} has moved to X:{PositionX}, Y:{PositionY}."; 
                }
                else
                {
                    return $"You are Frozen and Can't Move";
                }
            }
        }
        static void Main(string[] args)
        {
            var piece1 = new GamePiece();
            piece1.Color = "Blue";
            piece1.Name = "My Boy";

            piece1.MoveForward();
            Console.WriteLine(piece1);

            piece1.freeze();
            Console.WriteLine(piece1);

            piece1.unFreeze();

            piece1.MoveBack();
            Console.Write(piece1);
        }
    }
}
