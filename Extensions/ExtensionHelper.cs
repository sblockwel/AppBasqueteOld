using System;

namespace AppBasquete.Extensions
{
    public static class ExtensionHelper
    {
        public static int ToInt(this string numero) => int.Parse(numero);
        public static double ToDouble(this string numero) => double.Parse(numero);
        public static double ToDouble(this int numero) => (numero);
        public static DateTime ToDate(this string data) => DateTime.Parse(data);
    }
}