/*

    Escriba un programa que determine si el seno de un ángulo
    dado es positivo, negativo o cero. El programa pedirá al 
    usuario que introduzca un número, entre 0 y 360, correspondiente
    a la amplitud en grados del ángulo. Recuerde que el seno es cero
    para el ángulo de amplitud cero o múltiplo de 180, es positivo 
    siempre que esté entre cero y 180 y negativo si se encuentra entre
    180 y 360.

*/

using System;

class EP_3_9
{
	static void Main()
	{
        float angulo;

        do {
            Console.Write("Introduzca un ángulo entre 0° y 360°: ");
            angulo = float.Parse(Console.ReadLine());
        } while (angulo < 0 || angulo > 360);

        if (esPositivo(angulo)) Console.WriteLine("Es positivo");

        if (esNegativo(angulo)) Console.WriteLine("Es negativo");

        if (esNeutro(angulo)) Console.WriteLine("Es neutro");
    }

    static Boolean esPositivo(float angulo) {
        // Ángulo entre 180° y 360°
        if (angulo > 0 && angulo < 180) return true;
        return false;
    }

    static Boolean esNegativo(float angulo) {
        // Ángulo entre 180° y 360°
        if (angulo > 180 && angulo < 360) return true;
        return false;
    }

    static Boolean esNeutro(float angulo) {
        // Ángulo 0° o múltiplo de 180°
        if (angulo == 0 || angulo%180 == 0) return true;
        return false;
    }
}