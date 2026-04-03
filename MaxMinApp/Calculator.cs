using System;

namespace MaxMinApp
{
    // Вспомогательный класс с логикой вычислений
    // Вынесен отдельно, чтобы его можно было тестировать без WPF
    public static class Calculator
    {
        // Возвращает максимум из трёх вещественных чисел
        public static double GetMax(double a, double b, double c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        // Возвращает минимум из трёх вещественных чисел
        public static double GetMin(double a, double b, double c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
    }
}
