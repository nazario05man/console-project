using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cunsole_project
{
    class Program
    {
        static void Main()
        {
            // Створюємо екземпляри прямокутників та кіл
            Rectangle rect1 = new Rectangle(5, 8);
            Rectangle rect2 = new Rectangle(3, 6);

            Circle circle1 = new Circle(4);
            Circle circle2 = new Circle(6);

            // Перевіряємо, чи прямокутники та круги перетинаються
            if (rect1.Intersects(rect2))
            {
                Console.WriteLine("Прямокутники перетинаються!");
            }
            else
            {
                Console.WriteLine($"Загальна площа прямокутників: {rect1.CalculateArea() + rect2.CalculateArea()}");
            }

            if (circle1.Intersects(circle2))
            {
                Console.WriteLine("Круги перетинаються!");
            }
            else
            {
                Console.WriteLine($"Загальна площа кругів: {circle1.CalculateArea() + circle2.CalculateArea()}");
            }

            // Збільшуємо сторони прямокутника на коефіцієнт
            rect1.IncreaseSides(1.5);

            // Виводимо нові розміри прямокутника
            Console.WriteLine($"Нові розміри прямокутника: {rect1.Length} x {rect1.Width}");

            // Порівнюємо площини прямокутників
            if (rect1.AreAreasEqual(rect2))
            {
                Console.WriteLine("Площини прямокутників рівні!");
            }
            else
            {
                Console.WriteLine("Площини прямокутників не рівні.");
            }

            // Обчислюємо та виводимо периметр прямокутника
            Console.WriteLine($"Периметр прямокутника: {rect1.CalculatePerimeter()}");

            // Перевіряємо, чи дотикаються прямокутники
            if (rect1.Touches(rect2))
            {
                Console.WriteLine("Прямокутники дотикаються!");
            }
            else
            {
                Console.WriteLine("Прямокутники не дотикаються.");
            }

            // Перевіряємо, чи перетинаються круги
            if (circle1.Intersects(circle2))
            {
                Console.WriteLine("Круги перетинаються!");
            }
            else
            {
                Console.WriteLine($"Загальна площа кругів: {circle1.CalculateArea() + circle2.CalculateArea()}");
            }

            // Збільшуємо радіус кола на коефіцієнт
            circle1.IncreaseRadius(2);

            // Виводимо новий радіус кола
            Console.WriteLine($"Новий радіус кола: {circle1.Radius}");

            // Порівнюємо площини кругів
            if (circle1.AreAreasEqual(circle2))
            {
                Console.WriteLine("Площини кругів рівні!");
            }
            else
            {
                Console.WriteLine("Площини кругів не рівні.");
            }

            // Обчислюємо та виводимо довжину кола
            Console.WriteLine($"Довжина кола: {circle1.CalculateCircumference()}");

            // Обчислюємо та виводимо відстань між центрами кіл
            Console.WriteLine($"Відстань між центрами кіл: {circle1.CalculateDistanceBetweenCenters(circle2)}");

            // Перевіряємо, чи дотикаються круги в одній точці
            if (circle1.Touches(circle2))
            {
                Console.WriteLine("Круги дотикаються в одній точці!");
            }
            else
            {
                Console.WriteLine("Круги не дотикаються в одній точці.");
            }
        }
    }
}
