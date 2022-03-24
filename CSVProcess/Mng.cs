using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVProcess
{
    public class Mng
    {
        OnePais[] AllList;
        public void Run()
        {
            
            string fileName = @"C:\Users\haim\source\repos\Tech-CSV\CSVProcess\Data\Lotto.csv";
            PaisFile pais = new PaisFile();
            AllList = pais.Load(fileName);
        }

        public int GetNumerOfTimesThat4ExistedInFirstNumer()
        {
            int ret = 0;
            for (int i = 0; i < AllList.Length-1; i++)
            {
                if(AllList[i].numbers[0]==4)
                {
                    ret++;
                }
            }
            return ret;
        }

        public int GetNumerOfTimesThatExistedInFirstNumer(byte digit)
        {
            int ret = 0;
            for (int i = 0; i < AllList.Length - 1; i++)
            {
                if (AllList[i].numbers[0] == digit)
                {
                    ret++;
                }
            }
            return ret;
        }
    }
}
