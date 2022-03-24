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
        public OnePais[] Load(string fileName)
        {
            
            string[] lines = File.ReadAllLines(fileName);
            OnePais[] ret = new OnePais[lines.Length];

            for (int i = 1; i < lines.Length; i++)
            {
                OnePais o = new OnePais();
                string line = lines[i];
                string[] values = line.Split(',');
                o.Id = int.Parse(values[0]);
                o.date = DateTime.Parse(values[1]);
                o.numbers[0] = byte.Parse(values[2]);
                o.numbers[1] = byte.Parse(values[3]);
                o.numbers[2] = byte.Parse(values[4]);
                o.numbers[3] = byte.Parse(values[5]);
                o.numbers[4] = byte.Parse(values[6]);
                o.numbers[5] = byte.Parse(values[7]);
                ret[i-1] = o;

            }

            return ret;

        }
    }
}
