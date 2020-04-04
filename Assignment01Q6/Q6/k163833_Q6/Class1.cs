using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k163833_Q6
{
    public class Bubble_Sort
    {

        public void bubbleSort(int[] arr, int size)

        {
            bool pass = true;
            unsafe
            {
                int *temp;

                for (int i = 1; (i <= (size - 1)) && pass; i++)
                {
                    pass = false;
                    for (int j = 0; j < (size - 1); j++)
                    {
                        if (arr[j+1] > arr[j])
                        {
                            temp = (int*)arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = (int)temp;
                            pass = true;
                        }
                    }

                }
            }

        }
    }
}
