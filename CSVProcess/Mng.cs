using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVProcess
{
    public class Mng
    {
        public void Run()
        {
            
            string fileName = @"C:\Users\haim\source\repos\Tech-CSV\CSVProcess\Data\Lotto.csv";
            PaisFile pais = new PaisFile();
            pais.Load(fileName);
        }
    }
}
