using System;
using System.Text.RegularExpressions;

namespace WesselSoft.Domain
{
    public class Utils
    {
        private const string floatRegex = @"([-+]?\d+\.?\d*|[-+]?\d*\.?\d+)";
        private const string espaciosRegex = @"\s*";
        private const string patronBinomico = @"\(" + floatRegex + espaciosRegex + "," + floatRegex + @"\)";
        private const string patronPolar = @"\[" + floatRegex + espaciosRegex + ";" + floatRegex + @"\]";

        public static bool EsComplejoBinario(String stringAVerificar) {
            return Regex.IsMatch(stringAVerificar, patronBinomico);
        }

        public static bool EsComplejoPolar(String stringAVerificar) {
            return Regex.IsMatch(stringAVerificar, patronPolar);
        }

        public static double ParteRealComplejoBinario(String complejo) {
            string real = complejo.Substring(complejo.IndexOf('(') + 1);
            real = real.Remove(real.IndexOf(','));
            return double.Parse(real);
        }
        public static double ParteImaginariaComplejoBinario(String complejo) {
            string imaginario = complejo.Substring(complejo.IndexOf(',') + 1);
            imaginario = imaginario.Remove(imaginario.IndexOf(')'));
            return double.Parse(imaginario);
        }

        public static double ParteModuloComplejoPolar(string complejo) {
            string modulo = complejo.Substring(complejo.IndexOf('[') + 1);
            modulo = modulo.Remove(modulo.IndexOf(';'));
            return double.Parse(modulo);
        }

        public static double ParteAnguloComplejoPolar(String complejo) {
            string angulo = complejo.Substring(complejo.IndexOf(';') + 1);
            angulo = angulo.Remove(angulo.IndexOf(']'));
            return double.Parse(angulo);
        }
    }
}
