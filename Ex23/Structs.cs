using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23
{
    public struct ConsoleAvancee
    {
        public void RainbowWrite(string texte)
        {
            const int NB_COLORS = 16;
            for (int i = 0; i < texte.Length; i++)
            {
                char letter = texte[i];
                Console.ForegroundColor = (ConsoleColor)(i % NB_COLORS);
                Console.BackgroundColor = (ConsoleColor)(NB_COLORS - 1 - (i % NB_COLORS));
                Console.Write(letter);
            }
            Console.ResetColor();
        }
    }
}
