using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_arhitectura_sistemelor_de_calcul
{
    internal class ASMParser
    {
        private static readonly char[] DELIMITATORS = new char[] { ' ', ',', '\t', '\r', '\n' };

        public static List<String> Parse(String path)
        {
            if (!File.Exists(path))
                return new List<string>();

            String content = File.ReadAllText(path);

            List<String> lines = content.Split(
                DELIMITATORS,
                StringSplitOptions.RemoveEmptyEntries
                ).ToList();

            return lines;
        }
    }
}
