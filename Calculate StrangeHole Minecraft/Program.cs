using System.Drawing;

class Program
{
    static public string GetValue(string Sentence)
    {
        while (true)
        {
            string String_;
            Console.Write(Sentence);
            try
            {
                String_ = Console.ReadLine();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Incorrect!");
                continue;
                throw;
            }
            return String_;
            break;
        }

    }
    static public int GetIntValue(string Sentence)
    {
        try
        {
            return Convert.ToInt32(GetValue(Sentence));
        }
        catch (Exception)
        {
            Console.Clear();
            Console.WriteLine("Incorrect!");
            GetIntValue(Sentence);
        }
        return 0;
    }
    static public double GetDoubleValue(string Sentence)
    {
        try
        {

            return Convert.ToDouble(GetValue(Sentence));
        }
        catch (Exception)
        {
            Console.Clear();
            Console.WriteLine("Incorrect!");

            throw;
        }
        GetDoubleValue(Sentence);
    }
    static void Main(string[] args)
    {
        //Point FirstPossition = new Point(GetIntValue("First Possition X"), GetIntValue("First Possition Z"));
        //Point SecondPossition = new Point(GetIntValue("Second Possition X"), GetIntValue("Second Possition Z"));
        //double SecondAngle = GetDoubleValue("Second Possition Angle");
        //double FirstAngle = GetDoubleValue("First Possition Angle");
        Point FirstPossition = new Point(-320, 196);
        double FirstAngle = 11.24;
        Point SecondPossition = new Point(-266, 427);
        double SecondAngle = 35.5;

        double FirstWordlAngle = FirstAngle < 0 ? (180 + FirstAngle) + 180 : FirstAngle;
        
        double SecondWordlAngle = SecondAngle < 0 ? (180 + SecondAngle) + 180 : SecondAngle;
        double FirstTriangleAngle = (MathF.Atan((SecondPossition.Y - FirstPossition.Y) / (SecondPossition.X - FirstPossition.X)) * 180) / Math.PI;
        double FirstTriagAngle = (FirstTriangleAngle - FirstWordlAngle) * ((FirstTriangleAngle - FirstWordlAngle) < 0 ? -1 : 1);
        double SecondTriagAngle = (SecondWordlAngle - FirstWordlAngle) * ((SecondWordlAngle - FirstWordlAngle) < 0 ? -1 : 1);
        double ThirdTriagAngle = 180 - SecondTriagAngle - FirstTriangleAngle;
        double FirstDistance = MathF.Sqrt(MathF.Pow(SecondPossition.X - FirstPossition.X, 2) + MathF.Pow(SecondPossition.Y - FirstPossition.Y, 2));
        double SecondDistance = FirstDistance * MathF.Sin((float)SecondTriagAngle) / MathF.Sin((float)ThirdTriagAngle);
        double ThirdDistance = FirstDistance * MathF.Sin((float)FirstTriagAngle) / MathF.Cos((float)ThirdTriagAngle);

        Console.WriteLine(FirstPossition.X + (MathF.Sin((float)FirstAngle)) * SecondDistance);
        Console.WriteLine(FirstPossition.Y + (MathF.Cos((float)FirstAngle)) * SecondDistance);





    }
}


