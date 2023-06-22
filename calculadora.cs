using System;
using System.Collections.Generic;
using System.Text;


namespace EspacioCalculadora
{
   public class Calculadora
    {
       private double dato;
     

        public double Resultado { get => dato; }


     public void suma (double sumando){
        dato += sumando;


     }

        public void resta (double sustraendo){
        dato -= sustraendo;

        
     }

        public void multiplicacion (double multiplicador){
        dato *= multiplicador;

     }


       public void dividir (double divisor){
        string entrada;
        bool valido =false;

        if (divisor ==0)
        {
            do
            {
                Console.WriteLine("el divisor debe ser distinto de cero, ingrese otro divisor");
                entrada=Console.ReadLine();
                valido=double.TryParse(entrada, out divisor);
            } while (divisor ==0 || !valido);
        }
        
        dato /=divisor;
        
     }
 public void Limpiar(double dato){
        dato = 0;
    }





    }
}