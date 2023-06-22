using System;
using System.Collections.Generic;
using EmpresaConsola;




namespace Empresas
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<Tarea> ListaDeDatos=new List<Tarea>(); //COLECCION

Empleados[] empleado = new Empleados[3];
DateTime[] antiguedad = new DateTime[3];
DateTime[] edad = new DateTime[3];
 int[] edadTotal = new int[3];
 int[] antiguedadTotal = new int[3];
 double[] sueldoTotal=new double[3];
 int[] jubilacion = new int[3];

            
            string salida="";
            bool valido=false;
            string? nom="";
            string? ape="";
            string? texto="";
            char genero=' ';
            char estadoC=' ';

  
    for (int i = 0; i < 3; i++)
    {
    
             empleado[i] = new Empleados();
              valido =false;
             
                 while (!valido)
                 {
                     Console.WriteLine("Ingrese el nombre del empleado:");

                     nom=Console.ReadLine();
                    
                    if (nom== null)
                    {
                          Console.WriteLine("Nombre invalido");
                    }else
                    {
                         valido=true;
                 }
                      }



                       empleado[i].Nombre=nom;
                     valido =false;
         
                    while (!valido){


                    Console.WriteLine("Ingrese el apellido del empleado:");

                    ape=Console.ReadLine();
                    
                    if (ape== null)  {
                                      
                     Console.WriteLine("Apellido invalido");                       
                     }else {   
                        valido=true;                                 
                      }                                         
                                                           
                  

                    }
                    
                     
                    
                    empleado[i].Apellido=ape;
           
                    valido =false;
                    // // Option 1.
                    // // The Console.ReadLine() function returns a string.
                    // string strDob = Console.ReadLine();
                    // DateTime? dob1 = strDob.();

                        DateTime Dob;
                       Console.WriteLine("Ingrese su fecha de nacimiento DD/MM/YYYY:");

                        //accepts date in MM/dd/yyyy format
                        Dob = DateTime.Parse(Console.ReadLine());

                         empleado[i].FechaDeN=Dob;



                     DateTime Dob2;
                       Console.WriteLine("Ingrese su fecha de ingreso DD/MM/YYYY:");

                        //accepts date in MM/dd/yyyy format
                        Dob2 = DateTime.Parse(Console.ReadLine());

                         empleado[i].FechaDeI=Dob2;

                    while (!valido)
                    {
                          Console.WriteLine("Ingrese el género del empleado (f/femenino) - (m/masculino) - (o/otro)");
                    texto = Console.ReadLine();
                        valido = char.TryParse(texto, out genero);




                        if (genero =='F' || genero=='M' || genero=='f' || genero=='m'|| genero=='o' || genero=='O')
                        {
                           empleado[i].Genero=genero;
               

                        }else
                        {
                            Console.WriteLine("error al ingresar el genero");
                        }
                      
                    }
                          valido=false;
       
                          while (!valido)
                    {
                    Console.WriteLine("Ingrese el estado civil c:casado / v:viudo / d:divorciado / s:soltero ");
                    texto = Console.ReadLine();
                        valido = char.TryParse(texto, out estadoC);

                        
                        
                        if (estadoC=='c' || estadoC =='C' || estadoC=='v' || estadoC== 'V' || estadoC== 'd' || estadoC=='D' || estadoC=='s' || estadoC=='S')
                        {
                           empleado[i].EstadoCivil=estadoC;
                        }else
                        {
                            Console.WriteLine("error el ingresar el estado");
                        }

                    }
                          
                    
                      valido=false;
                        


            Console.WriteLine("Ingrese el sueldo basico:");

              double sueldoB=Convert.ToDouble(Console.ReadLine());
                            
empleado[i].SueldoBasico=sueldoB;
         

                Console.WriteLine("Ingrese el estado: ((1=Auxiliar) - (2=Administrativo) -  (3=Ingeniero) - (4=Especilista) - (5=Especialista))");

               int state=Convert.ToInt32(Console.ReadLine());

              switch (state)
              {
                case 1: 
                   empleado[i].Cargos= Cargo.Auxiliar;
            
                
                break;


                case 2:
                   empleado[i].Cargos= Cargo.Administrativo;
            
                
                break;


                case 3:
                   empleado[i].Cargos= Cargo.Ingeniero;
            
                
                break;

                case 4:
                   empleado[i].Cargos= Cargo.Especialista;
                
                break;

                case 5:
                   empleado[i].Cargos= Cargo.Investigador;
                
                break;
                default:
                 Console.WriteLine("Cargo no valido");
                break;
              }
              
    }


      


    for (int i = 0; i < 3; i++)
    {
        
                // Console.WriteLine(TareaE.Nombre + " - " + TareaE.Apellido + " - " + TareaE.Genero + " - " + TareaE.EstadoCivil + " - " + TareaE.Cargos);
              edadTotal[i] = empleado[i].calcularEdad(empleado[i].FechaDeN);
               antiguedadTotal[i]=empleado[i].calcularAntiguedad(empleado[i].FechaDeI);
               sueldoTotal[i]=empleado[i].calcularSalario(empleado[i].SueldoBasico, empleado[i].FechaDeI, empleado[i].Cargos, empleado[i].Genero);
                jubilacion[i]=empleado[i].calcularJubilacion(empleado[i].Genero ,empleado[i].FechaDeN);
        
                 Console.WriteLine(empleado[i].Nombre + " - " + empleado[i].Apellido );
                 Console.WriteLine(empleado[i].FechaDeN);
                  Console.WriteLine("Su sueldo basico es " + empleado[i].SueldoBasico);
                  Console.WriteLine(empleado[i].Genero);
                  Console.WriteLine(empleado[i].EstadoCivil);
                  Console.WriteLine(empleado[i].Cargos);
                 Console.WriteLine("Su edad es : " + edadTotal[i]);
                 Console.WriteLine("Su antiguedad es : " + antiguedadTotal[i]);
                 Console.WriteLine("El sueldo total es :" + sueldoTotal[i]);
                 Console.WriteLine("Falta para su jubilacion : " +  jubilacion[i]);



              
              Console.WriteLine("PROXIMO A JUBILARSE");

 
                   
                  






                 
                  
    
    }

     if (antiguedadTotal[0]>antiguedadTotal[1] && antiguedadTotal[0] > antiguedadTotal[2]) {
                    Console.WriteLine("El empleado mas proximo es :");
                    Console.WriteLine(empleado[0].Nombre + " - " + empleado[0].Apellido );
                 Console.WriteLine(empleado[0].FechaDeN);
                  Console.WriteLine("Su sueldo basico es " + empleado[0].SueldoBasico);
                  Console.WriteLine(empleado[0].Genero);
                  Console.WriteLine(empleado[0].EstadoCivil);
                  Console.WriteLine(empleado[0].Cargos);
                 Console.WriteLine("Su edad es : " + edadTotal[0]);
                 Console.WriteLine("Su antiguedad es : " + antiguedadTotal[0]);
                //  Console.WriteLine("El sueldo total es :" + sueldoTotal[0]);
                //  Console.WriteLine("Falta para su jubilacion : " +  jubilacion[0]);
                 

                  }
                  
                   if (antiguedadTotal[1]> antiguedadTotal[0] && antiguedadTotal[1] > antiguedadTotal[2])
                  {
                   
                    Console.WriteLine("El empleado mas proximo es :");
                    Console.WriteLine(empleado[1].Nombre + " - " + empleado[1].Apellido );
                 Console.WriteLine(empleado[1].FechaDeN);
                  Console.WriteLine("Su sueldo basico es " + empleado[1].SueldoBasico);
                  Console.WriteLine(empleado[1].Genero);
                  Console.WriteLine(empleado[1].EstadoCivil);
                  Console.WriteLine(empleado[1].Cargos);
                  } 
                  
                  if (antiguedadTotal[2] >antiguedadTotal[0] && antiguedadTotal[2] > antiguedadTotal[1])
                  {
                    Console.WriteLine("El empleado mas proximo a jubilarse es :");
                    Console.WriteLine(empleado[2].Nombre + " - " + empleado[2].Apellido );
                //  Console.WriteLine(empleado[2].FechaDeN);
                //   Console.WriteLine("Su sueldo basico es " + empleado[2].SueldoBasico);
                //   Console.WriteLine(empleado[2].Genero);
                //   Console.WriteLine(empleado[2].EstadoCivil);
                //   Console.WriteLine(empleado[2].Cargos);
                  }
                 

/**DE ESTA FORMA ME LO MUESTRA MUCHAS VECES*/
// int j=0;


             
//     int aux=0;
//           if (antiguedadTotal[j]>=antiguedadTotal[aux]) {
//                     Console.WriteLine("El empleado mas proximo es :");
//                     Console.WriteLine(empleado[j].Nombre + " - " + empleado[j].Apellido );
//                  Console.WriteLine(empleado[j].FechaDeN);
//                   Console.WriteLine("Su sueldo basico es " + empleado[j].SueldoBasico);
//                   Console.WriteLine(empleado[j].Genero);
//                   Console.WriteLine(empleado[j].EstadoCivil);
//                   Console.WriteLine(empleado[j].Cargos);
//                  Console.WriteLine("Su edad es : " + edadTotal[j]);
//                  Console.WriteLine("Su antiguedad es : " + antiguedadTotal[j]);
//                 //  Console.WriteLine("El sueldo total es :" + sueldoTotal[0]);
//                 //  Console.WriteLine("Falta para su jubilacion : " +  jubilacion[0]);
//                    j++;
//                  aux=j+1; 
                 

//                   }
                  



        }
    }
}


