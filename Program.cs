class Program {
    static void Main(string[] args) {
        double x1, y1, r1, x2, y2, r2;

        x1 = double.Parse(Console.ReadLine());
        y1 = double.Parse(Console.ReadLine());
        x2 = double.Parse(Console.ReadLine());
        y2 = double.Parse(Console.ReadLine());
        r2 = double.Parse(Console.ReadLine());
        r1 = double.Parse(Console.ReadLine());

        double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        if (d <= r1 + r2) {
            double a = (Math.Pow(r1, 2) - Math.Pow(r2, 2) + Math.Pow(d, 2)) / (2 * d);
            double h = Math.Sqrt(Math.Pow(r1, 2) - Math.Pow(a, 2));
            double x3 = x1 + a * (x2 - x1) / d;
            double y3 = y1 + a * (y2 - y1) / d;
            double x4 = x3 - h * (y2 - y1) / d;
            double y4 = y3 + h * (x2 - x1) / d;
            double x5 = x3 + h * (y2 - y1) / d;
            double y5 = y3 - h * (x2 - x1) / d;

            if(d == r1 + r2){
                Console.WriteLine(x4);
                Console.WriteLine(y4);
            }else{
                Console.WriteLine(x4);
                Console.WriteLine(y4);
                Console.WriteLine(x5);
                Console.WriteLine(y5);
            }
        }
    }
}