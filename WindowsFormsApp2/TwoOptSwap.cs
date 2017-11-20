using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public static class TwoOptSwap
    {
        public static int[] OptSwap(int [] TempTour,int i,int v)
        {
            int size = TempTour.Length;
            int[] newtour = new int[size];

            for(int j=0;j<=i-1;++j)
            {
                newtour[j] = TempTour[j];
            }

            int eff = 0;
            for(int j=i;j<=v; ++j)
            {
                newtour[j] = TempTour[v - eff];
                eff++;
            }

            for(int j=v+1;j<size;++j)
            {
                newtour[j] = TempTour[j];

            }

            return newtour;
        }


    }
}
