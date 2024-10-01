using System;
class Program
{
    static (double, double) CalculateRoots(double t)
    {
        if (t < 0) throw new ArgumentException($"Ошибка: Значение t = {t:F3} отрицательное, корней нет.");
        return (Math.Sqrt(t), -Math.Sqrt(t));
    }

    static void Main()
    {
        try
        {
            double t1, t2, x1 = 0, x2 = 0, x3 = 0, x4 = 0, Dis;
            bool validRootsForT1 = false, validRootsForT2 = false;
            Console.WriteLine("Введите значения a, b и c:");
            double a = Convert.ToDouble(Console.ReadLine()), b = Convert.ToDouble(Console.ReadLine()), c = Convert.ToDouble(Console.ReadLine());
            if (a == 0) throw new DivideByZeroException("Значение 'a' не должно быть равно 0.");
            Dis = Math.Pow(b, 2) - 4 * a * c;
            if (Dis < 0) Console.WriteLine("Дискриминант ниже 0! Корней уравнения нет.");
            else
            {
                t1 = (-b + Math.Sqrt(Dis)) / (2 * a); 
                t2 = (-b - Math.Sqrt(Dis)) / (2 * a);
                try { (x1, x2) = CalculateRoots(t1); validRootsForT1 = true; Console.WriteLine($"Корни для t1: {x1:F3}, {x2:F3}"); }
                catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
                try { (x3, x4) = CalculateRoots(t2); validRootsForT2 = true; Console.WriteLine($"Корни для t2: {x3:F3}, {x4:F3}"); }
                catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
                if (validRootsForT1 && validRootsForT2 && (x1 == x3 && x2 == x4))
                    Console.WriteLine($"Корни двойного квадратного уравнения: {x1}, {x2}");
                else
                {
                    if (validRootsForT1) Console.WriteLine($"Действительные корни для t1: {x1:F3}, {x2:F3}");
                    if (validRootsForT2) Console.WriteLine($"Действительные корни для t2: {x3:F3}, {x4:F3}");
                }
            }
        }
        catch (FormatException) { Console.WriteLine("Ошибка: Введено некорректное число."); }
        catch (DivideByZeroException ex) { Console.WriteLine($"Ошибка: {ex.Message}"); }
        catch (Exception ex) { Console.WriteLine($"Произошла ошибка: {ex.Message}"); }
    }
}

