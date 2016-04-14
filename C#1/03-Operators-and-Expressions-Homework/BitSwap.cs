﻿using System;

//Write a program first reads 3 numbers n, p, q and k and than swaps bits  {p, p+1, …, p+k-1}  
//with bits  {q, q+1, …, q+k-1}  of n. 
//Print the resulting integer on the console.

//Input
//•On the only four lines of the input you will receive the integers n, p, q and k in this order.

//Output
//•Output a single value - the value of n after the bit swaps.

//Constraints
//•The first and the second sequence of bits will never overlap.
//•n will always be a valid 32-bit positive integer.


 class BitSwap
 {
      static void Main()
      {
          uint n = uint.Parse(Console.ReadLine());
          int p = int.Parse(Console.ReadLine());
          int q = int.Parse(Console.ReadLine());
          int k = int.Parse(Console.ReadLine());

          uint result = n;
          uint bitP = 0;
          uint bitQ = 0;

          Console.WriteLine(Convert.ToString(n, 2).PadLeft(32,'0'));

          for (int i = 0; i < k; i++)
          {
              bitP = (((uint)1 << p) & n) >> p;
              bitQ = (((uint)1 << q) & n) >> q;

              //exchange bits
              if (bitP == 0 && bitQ == 1)
              {
                  //set bitP to 1 
                result = ((uint)1 << p) | result;

                //set bitQ to 0
                result = (~((uint)1 << q)) & result;
              }
              else if (bitP == 1 && bitQ == 0)
              {
                //set bitP to 0
                result = (~((uint)1 << p)) & result;

                //set bitQ to 1
                result = ((uint)1 << q) | result;
             }
             
             //move to the next position in the range (0,k)
             p++;
             q++;
          }
          Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
          Console.WriteLine(result);

      //    for (int i = 0; i < 32; i++)
      //    {
      //        for (int j = p; j <= p+k-1; j++)
      //        {
      //            bitP = (((uint)1 << j) & n) >> j;
      //        }
      //        for (int l = q; l <= q + k - 1; l++)
      //        {
      //            bitQ = (((uint)1 << l) & n) >> l;
      //            //Console.WriteLine("l = {0} bitQ={1}", l, bitQ);
      //        }
      //        result = exchangeBits(bitP, bitQ,i,n);
      //        break;
      //    }
      //    Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
      //    Console.WriteLine(result);
      }

      static uint exchangeBits(uint bit1, uint bit2, int position, uint n)
      {
          uint result = n;

          if (bit1 == bit2)
          {
              //no change
          }
          else if (bit1 == 0 && bit2 == 1)
          {
              //set bit1 to 1 
              result = ((uint)1 << position) | result;

              //set bit2 to 0
              result = (~((uint)1 << position)) & result;
          }
          else if (bit1 == 1 && bit2 == 0)
          {
              //set bit1 to 0
              result = (~((uint)1 << position)) & result;

              //set bit2 to 1
              result = ((uint)1 << position) | result;

          }

          return result;
      }
}
