using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Floor
    {
        Bomzh[] bomzhes = new Bomzh[28];
        public Floor()
        {
            for (int i = 0; i < bomzhes.Length; i++)
            {
                bomzhes[i] = new Bomzh();
            }

        }


    }
}
