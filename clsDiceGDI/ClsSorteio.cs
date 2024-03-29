﻿using System;

namespace clsDiceGDI
{
    internal class ClsSorteio
    {
        /// <summary>
        /// Sorteia um número entre 1 e 6.
        /// </summary>
        /// <returns>Retorna uma string com um número.</returns>
        public static string Sorteia()
        {
            Random randNum = new Random();
            return randNum.Next(1, 7).ToString();
        }
    }
}
