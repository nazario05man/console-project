using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cunsole_project
{
    class Circle
    {
        // Властивість радіуса кола
        public double Radius { get; set; }

        // Конструктор класу для ініціалізації радіуса
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Метод для обчислення площі кола
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Метод для збільшення радіуса кола на заданий коефіцієнт
        public void IncreaseRadius(double factor)
        {
            Radius *= factor;
        }

        // Метод для порівняння площин двох кругів
        public bool AreAreasEqual(Circle otherCircle)
        {
            return Math.Abs(this.CalculateArea() - otherCircle.CalculateArea()) < double.Epsilon;
        }

        // Метод для обчислення довжини кола
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        // Метод для обчислення відстані між центрами двох кіл
        public double CalculateDistanceBetweenCenters(Circle otherCircle)
        {
            // Реалізуємо логіку обчислення відстані між центрами кіл
            return 0.0;
        }

        // Метод для перевірки, чи дотикаються круги в одній точці
        public bool Touches(Circle otherCircle)
        {
            // Реалізуємо логіку перевірки, чи дотикаються круги
            return false;
        }

        // Метод для перевірки, чи перетинаються круги
        public bool Intersects(Circle otherCircle)
        {
            // Реалізуємо логіку перевірки перетину кіл
            return false;
        }
    }
}
