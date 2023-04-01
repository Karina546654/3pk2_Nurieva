using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
    {
        var Sam = new Student("Sam", 15, ColorHair.Dark);

        Console.WriteLine(Sam.ToString());

        var Mas = Sam;
        Mas.NAME = "Mas";

        Console.WriteLine(Sam.ToString());
        Console.WriteLine(Mas.ToString());

        var Jack = new Student("Jack", 14, ColorHair.Red);
        var Max = (Student)Jack.Clone();
        Max.NAME = "Max";

        Console.WriteLine(Jack.ToString());
        Console.WriteLine(Max.ToString());
    }
}
    enum ColorHair
    {
        Dark,
        Blond,
        Red
    }

    internal class Student : ICloneable, IComparable<Student>
    {

        private string nam;
        private int years;
        private ColorHair col;

        public Student(string name, int yo, ColorHair colorHair)
        {
            nam = name;
            years = yo;
            col = colorHair;
        }

        public string NAME
        {
            get
            {
                return nam;
            }
            set
            {
                nam = value;
            }
        }

        public int YO
        {
            get
            {
                return years;
            }
            set
            {
                years = value;
            }
        }

        public ColorHair Color
        {
            get
            {
                return col;
            }
            set
            {
                col = value;
            }
        }

        public object Clone()
        {
            return new Student(NAME, YO, Color);
        }

        public int CompareTo(Student? other)
        {
            if (other is Student student) return NAME.CompareTo(student.NAME);
            else throw new ArgumentException("некорректное значение"); throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Имя:{nam}, {years} лет, цвет волос: {col}";
        }

    }
}
     internal interface ICloneable
        {
            object Clone();
        }
    internal interface IComparable
    {
        int CompareTo(object? o);
}
