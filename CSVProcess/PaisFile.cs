using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CSVProcess
{
    public class PaisFile
    {
        public void Load(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            for(int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] values = line.Split(',');


            }

        }
    }
}
