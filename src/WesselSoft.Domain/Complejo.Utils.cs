using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WesselSoft.Domain
{
    public class Utils
    {
        public static bool EsComplejoBinario(String stringAVerificar)
        {
            return Regex.IsMatch(stringAVerificar, patronBinomico);
        }

        public static bool EsComplejoPolar(String stringAVerificar)
        {
            return Regex.IsMatch(stringAVerificar, patronPolar);
        }

        public static double ParteRealComplejoBinario(String complejo)
        {
            String real = complejo.Substring(complejo.IndexOf('(')+1);
            real = real.Remove(real.IndexOf(','));
            return Double.Parse(real);
        }
        public static double ParteImaginariaComplejoBinario(String complejo)
        {
            String imaginario = complejo.Substring(complejo.IndexOf(',')+1);
            imaginario = imaginario.Remove(imaginario.IndexOf(')'));
            return Double.Parse(imaginario);
        }

        public static double ParteModuloComplejoPolar(string complejo)
        {
            String modulo = complejo.Substring(complejo.IndexOf('[')+1);
            modulo = modulo.Remove(modulo.IndexOf(';'));
            return Double.Parse(modulo);
        }

        public static double ParteAnguloComplejoPolar(String complejo)
        {
            String angulo = complejo.Substring(complejo.IndexOf(';')+1);
            angulo = angulo.Remove(angulo.IndexOf(']'));
            return Double.Parse(angulo);
        }



        static String  floatRegex = @"([-+]?\d+\.?\d*|[-+]?\d*\.?\d+)";
        static String espaciosRegex = @"\s*";
        static string patronBinomico = @"\(" + floatRegex + espaciosRegex + "," + floatRegex + @"\)";
        static string patronPolar = @"\[" + floatRegex + espaciosRegex + ";" + floatRegex + @"\]";
    }
}
