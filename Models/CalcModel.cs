using System;
namespace lab1.Models
{
    public class CalcModel
    {
        public int RandValueFirst { get; set; }
        public int RandValueSecond { get; set; }
        public int Add { get; set; }
        public int Sub { get; set; }
        public int Mult { get; set; }
        public string Div { get; set; }

        public CalcModel()
        {
            Random rnd = new Random();
            RandValueFirst = rnd.Next(0,10);
            RandValueSecond = rnd.Next(0,10);
            Add = RandValueFirst + RandValueSecond;
            Sub = RandValueFirst - RandValueSecond;
            Mult = RandValueFirst * RandValueSecond;
            if (RandValueSecond == 0) {
                Div = "Division by zero";
            }
            else {
                Div = (RandValueFirst / RandValueSecond).ToString();
            }
        }
    }
}