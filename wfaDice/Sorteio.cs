using System;

namespace wfaDice
{
    public class Sorteio
    {
        /// <summary>
        /// Sorteia um número entre 1 e 6.
        /// </summary>
        /// <returns>Retorna uma string com um número.</returns>
        public string Sorteia()
        {
            Random randNum = new Random();
            return randNum.Next(1, 6).ToString();
        }

        /// <summary>
        /// Sorteia um número entre 1 e o valor passado.
        /// </summary>
        /// <param name="intMumMax">Número tipo int máximo do sorteio.</param>
        /// <returns>Retorna uma string com um número.</returns>
        public string Sorteia(int intMumMax)
        {
            Random randNum = new Random();
            return randNum.Next(1, intMumMax + 1).ToString();
        }

        /// <summary>
        /// Sorteia um número entre os valores passados.
        /// </summary>
        /// <param name="bytNumMin">Número tipo byte mínimo do sorteio</param>
        /// <param name="byeMumMax">Número tipo byte máximo do sorteio.</param>
        /// <returns>Retorna uma string com um número.</returns>
        public string Sorteia(byte bytNumMin, byte byeNumMax)
        {
            Random randNum = new Random();
            return randNum.Next(bytNumMin, byeNumMax + 1).ToString();
        }

        /// <summary>
        /// Sorteia um número entre 1 e o valor passado.
        /// </summary>
        /// <param name="strNumMax">Número tipo string máximo do sorteio.</param>
        /// <returns>Retorna uma string com um número.</returns>
        public string Sorteia(string strNumMax)
        {
            Random randNum = new Random();
            return randNum.Next(1, Convert.ToInt32(strNumMax + 1)).ToString();
        }

        /// <summary>
        /// Sorteia um número entre os valores passados.
        /// </summary>
        /// <param name="strNumMin">Número tipo string mínimo do sorteio</param>
        /// <param name="strNumMax">Número tipo string máximo do sorteio.</param>
        /// <returns>Retorna uma string com um número.</returns>
        public string Sorteia(string strNumMin, string strNumMax)
        {
            Random randNum = new Random();
            return randNum.Next(Convert.ToInt32(strNumMin), Convert.ToInt32(strNumMax + 1)).ToString();
        }
    }
}
