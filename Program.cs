using System;
using System.Collections.Generic;

namespace structures
{
    
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Uzunluk giriniz : ");
            int x=Convert.ToInt32(Console.ReadLine());
            
            DRAW_TRIANGLE(x);


     
        }

        public static void DRAW_TRIANGLE(int x){
                    for(int i=0;i<x;i++){

                        for(double z=0;z<(x-i)/2;z+=1){
                            Console.Write(" ");
                        }

                        for(int y=0;y<2*i+1;y++){
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                    }
        }
    }
}