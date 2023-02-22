using static System.Console;

namespace OitavaAula {
    struct Point {
        public int X;
        public int Y;

        public override string ToString(){
            return "(" +    X +")" + "(" +  Y + ")";
        }
    }
    class Program {
        static void Main(){
            Point p = new Point();

            p.X = 3;
            p.Y = 96;

            Write(" " + p);
        }
    }
}
