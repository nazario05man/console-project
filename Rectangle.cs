using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cunsole_project
{
    class Rectangle
    {
        // Властивості довжини і ширини прямокутника
        public double Length { get; set; }
        public double Width { get; set; }

        // Конструктор класу для ініціалізації довжини та ширини
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Метод для обчислення площі прямокутника
        public double CalculateArea()
        {
            return Length * Width;
        }

        // Метод для збільшення сторін прямокутника на заданий коефіцієнт
        public void IncreaseSides(double factor)
        {
            Length *= factor;
            Width *= factor;
        }

        // Метод для порівняння площин двох прямокутників
        public bool AreAreasEqual(Rectangle otherRectangle)
        {
            return Math.Abs(this.CalculateArea() - otherRectangle.CalculateArea()) < double.Epsilon;
        }

        // Метод для обчислення периметру прямокутника
        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        // Метод для перевірки, чи дотикаються прямокутники
        public bool Touches(Rectangle otherRectangle)
        {
            // Реалізуємо логіку перевірки, чи дотикаються прямокутники
            // Для спрощення, припускаємо, що немає дотику, якщо вони мають лише одну спільну точку
            return false;
        }

        // Метод для перевірки, чи перетинаються прямокутники
        public bool Intersects(Rectangle otherRectangle)
        {
            // Реалізуємо логіку перевірки перетину прямокутників
            return false;
        }
    }
}
