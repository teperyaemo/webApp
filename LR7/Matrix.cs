using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LR7
{
    public class Matrix
    {
        public int[,] array = new int[3, 3];
        public int[,] array2 = new int[3, 3];

        /*public Matrix(int multi_A, int multi_B, int Num1_1, int Num1_2, int Num1_3, int Num2_1, int Num2_2, int Num2_3, int Num3_1, int Num3_2, int Num3_3)
        {
            array[0, 0] = multi_A * Num1_1;
            array[0, 1] = multi_A * Num1_2;
            array[0, 2] = multi_A * Num1_3;
            array[1, 0] = multi_A * Num2_1;
            array[1, 1] = multi_A * Num2_2;
            array[1, 2] = multi_A * Num2_3;
            array[2, 0] = multi_A * Num3_1;
            array[2, 1] = multi_A * Num3_2;
            array[2, 2] = multi_A * Num3_3;
        }*/

        public Matrix(int multi_A, int multi_B, int Num1_1, int Num1_2, int Num1_3, int Num2_1, int Num2_2, int Num2_3, int Num3_1, int Num3_2, int Num3_3, int B_Num1_1, int B_Num1_2, int B_Num1_3, int B_Num2_1, int B_Num2_2, int B_Num2_3, int B_Num3_1, int B_Num3_2, int B_Num3_3)
        {
            array[0, 0] = multi_A * Num1_1;
            array[0, 1] = multi_A * Num1_2;
            array[0, 2] = multi_A * Num1_3;
            array[1, 0] = multi_A * Num2_1;
            array[1, 1] = multi_A * Num2_2;
            array[1, 2] = multi_A * Num2_3;
            array[2, 0] = multi_A * Num3_1;
            array[2, 1] = multi_A * Num3_2;
            array[2, 2] = multi_A * Num3_3;


            array2[0, 0] = multi_B * B_Num1_1;
            array2[0, 1] = multi_B * B_Num1_2;
            array2[0, 2] = multi_B * B_Num1_3;
            array2[1, 0] = multi_B * B_Num2_1;
            array2[1, 1] = multi_B * B_Num2_2;
            array2[1, 2] = multi_B * B_Num2_3;
            array2[2, 0] = multi_B * B_Num3_1;
            array2[2, 1] = multi_B * B_Num3_2;
            array2[2, 2] = multi_B * B_Num3_3;
        }

        public int[,] umn()
        {
            int[,] carray=new int[3,3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 3; k++)
                        carray[i, j] = array[i, k] * array2[k, j];

            return carray;
        }
    }
}
