using System;

namespace DelegateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Action showTime = () =>
            {
                Console.WriteLine("Время сейчас: " + DateTime.Now.ToShortTimeString());
            };

            Action showDate = () =>
            {
                Console.WriteLine("Дата сегодня: " + DateTime.Now.ToShortDateString());
            };

            Action showDay = () =>
            {
                Console.WriteLine("День недели: " + DateTime.Now.DayOfWeek);
            };

            Func<double, double, double> triangleArea = (b, h) => 0.5 * b * h;

            Func<double, double, double> rectArea = (w, h) => w * h;

            Predicate<double> isPositive = (x) => x > 0;

            showTime();
            showDate();
            showDay();

            Console.WriteLine();

            double triBase = 10;
            double triHeight = 5;

            if (isPositive(triBase) && isPositive(triHeight))
            {
                double areaT = triangleArea(triBase, triHeight);
                Console.WriteLine($"Площадь треугольника (основание {triBase}, высота {triHeight}): " + areaT);
            }

            double rectW = 4;
            double rectH = 6;

            if (isPositive(rectW) && isPositive(rectH))
            {
                double areaR = rectArea(rectW, rectH);
                Console.WriteLine($"Площадь прямоугольника ({rectW} на {rectH}): " + areaR);
            }

            Console.ReadKey();
        }
    }
}
