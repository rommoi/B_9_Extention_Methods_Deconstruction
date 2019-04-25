using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Lesson_9.Practice
{
    public static class Practice
    {
        /// <summary>
        /// L9-P-EX-1/2
        /// Создать структуру Coordinates (трехмерных). 
        /// Добавить экземплярный метод деконструкции значений координат.
        /// Вывести на консоль длину вектора по координатам.
        /// </summary>
        struct Coordinate
        {
            public double X;
            public double Y;
            public double Z;
            public Coordinate(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }
            public void Deconstruct(out double x, out double y, out double z)
            {
                x = X;
                y = Y;
                z = Z;
            }
        }
        public static void L9_P_EX_1_from_2()
        {
            Random rnd = new Random();
            Coordinate c = new Coordinate(rnd.Next(-100, 100), rnd.Next(-100, 100), rnd.Next(-100, 100));
            var (x, y, z) = c;
            Console.WriteLine($"Coordinates: x = {x}, y = {y}, z = {z}");
            Console.WriteLine($"Vector Lenght: {Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2))}");

        }

        /// <summary>
        /// L9-P-EX-2/2. 
        /// Создать деконструктор для обьекта DateTime 
        /// (год, месяц, день, час, минуты, секунды). 
        /// Получить и вывести на консоль текущее время.
        /// Использовать пустые параметры.
        /// </summary>
        
        public static void L9_P_EX_2_from_2()
        {
            DateTime t = DateTime.Now;
            var(year, month, day, dayOfWeek, hour, minutes, seconds) = t;

            Console.WriteLine($"{year} {month} {day} {dayOfWeek} {hour} {minutes} {seconds}");
            Console.WriteLine();

            var (_, _, _, _, Hour, Minutes, Seconds) = t;
            Console.WriteLine($"Now is {Hour}:{Minutes}:{Seconds}");

        }
    }
    public static class DateTimeDeconstruct
    {
        public static void Deconstruct(this DateTime dt, out int year, out int month, out int day, out DayOfWeek dayOfWeek, out int hour, out int minutes, out int seconds)
        {
            year = dt.Year;
            month = dt.Month;
            day = dt.Day;
            dayOfWeek = dt.DayOfWeek;
            hour = dt.Hour;
            minutes = dt.Minute;
            seconds = dt.Second;
        }
    }
}
