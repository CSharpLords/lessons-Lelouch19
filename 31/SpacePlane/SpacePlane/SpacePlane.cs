using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class SpacePlane
    {
         public string speed = "";
         public string dist = "";
         public SpacePlane(int speedX)
         {      
            for (int i = 0; i < speedX; i++)
            {
                speed = speed + "-";
            }
         }
         public void Fly()
         {
             dist = dist + speed;
             Console.WriteLine(dist);
         }

    }
}
