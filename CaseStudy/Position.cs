using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy
{
    public enum Directions
    {
        N = 1,//North
        S = 2,//South
        E = 3,//East
        W = 4//West
    }


    public class Position 
    {
        public int X { get;  set; }
        public int Y { get;  set; }
        public Directions Direction { get;  set; }
        public List<int> MaxPoints { get;  set; } 

        public Position(int x,int y,Directions direction,List<int> maxPoints)
        {
            X = x;
            Y = y;
            Direction = direction;
            MaxPoints = maxPoints;
        }


        private void Rotate90Left()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.W;
                    break;
                case Directions.S:
                    this.Direction = Directions.E;
                    break;
                case Directions.E:
                    this.Direction = Directions.N;
                    break;
                case Directions.W:
                    this.Direction = Directions.S;
                    break;
                default:
                    break;
            }
        }

        private void Rotate90Right()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.E;
                    break;
                case Directions.S:
                    this.Direction = Directions.W;
                    break;
                case Directions.E:
                    this.Direction = Directions.S;
                    break;
                case Directions.W:
                    this.Direction = Directions.N;
                    break;
                default:
                    break;
            }
        }

        private void MoveInSameDirection()
        {
            int x = this.X;
            int y = this.Y;
            switch (this.Direction)
            {

                case Directions.N:
                    y += 1;
                    break;
                case Directions.S:
                    y -= 1;
                    break;
                case Directions.E:
                    x += 1;
                    break;
                case Directions.W:
                    x -= 1;
                    break;
                default:
                    break;
            }
            CheckBorder(x, y);
            this.X = x;
            this.Y = y;
        }
        public void CheckBorder(int x,int y)
        {
            if (x < 0 || x > MaxPoints[0] || y< 0 || y > MaxPoints[1])
            {
                throw new Exception($"Pozisyonunuz sinirlarinizi asamaz. (0 , 0) ve ({MaxPoints[0]} , {MaxPoints[1]})");
            }
        }

        public void StartMoving(string moves)
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                        this.MoveInSameDirection();
                        break;
                    case 'L':
                        this.Rotate90Left();
                        break;
                    case 'R':
                        this.Rotate90Right();
                        break;
                    default:
                        Console.WriteLine($"Tanimsiz karakter {move}");
                        break;
                }


            }
        }
    }
}
