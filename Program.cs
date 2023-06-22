using EspacioCalculadora;

using System;




namespace Myapp
{
   class Program
  {

     static void Main(string[] args){ 
    


  Calculadora calc1;
    calc1= new Calculadora();
 calc1.suma(100);
   Console.WriteLine(calc1.Resultado);


  double num;
  bool valido =false;

  string entrada;
int opcion;
int op=0;
  
//   Calculadora cal= new Calculadora();
do
{
    op=1;




do
  {
     Console.WriteLine("Ingrese el primer numero: ");
     entrada=Console.ReadLine();

     valido=double.TryParse(entrada, out num);

     Console.WriteLine("Ingrese la operacion a realizar \n1-suma\n  2-resta\n 3-multiplacion\n 4-division\n 5\n limpiar");
     entrada=Console.ReadLine();
     valido=int.TryParse(entrada, out opcion);
      switch (opcion)
      {
        case 1:
        Console.WriteLine("El resultado de la suma es");
        calc1.suma(num);
        Console.WriteLine(calc1.Resultado);
        break;


        case 2:
       Console.WriteLine("El resultado de la resta es");
        calc1.resta(num);
        Console.WriteLine(calc1.Resultado);
        break;

    
        case 3:
       Console.WriteLine("El resultado de la multiplicacion es");
        calc1.multiplicacion(num);
        Console.WriteLine(calc1.Resultado);
        break;
  


     case 4:
       Console.WriteLine("El resultado de la division es");
        calc1.dividir(num);
        Console.WriteLine(calc1.Resultado); 
        break;

        case 5:
       
        
        calc1.Limpiar(num);
        Console.WriteLine(calc1.Resultado);

        break;


        default:
        break;
      }
    

    if (!valido)
    {
        Console.WriteLine("el numero ingresado no es valido:");
    }
  

  


  } while (!valido);


 Console.WriteLine("Desea realizar otra operacion (1.SI / 0.NO):");
    op = Convert.ToInt32(Console.ReadLine());



} while (op!=0);














  







////////////////////////////////////////////////////


// public void UsarCalc(){


// }



// static void Main( string [] args){

//   Console.WriteLine("Hello World!");

//   Calculadora cal= new Calculadora();
//   cal.suma(15);
//    Console.WriteLine(cal.Resultado);






// }










 }



  } 

   }