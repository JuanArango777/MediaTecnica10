/******************************************************************************

Autor: Juan Arango
Fecha: 2024-05-22
Descripción: Programa con decisiones para
             verdadero o falso

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    // variables
    bool sexoMasculino;
    
    // capturar informacion del usuario
    Console.WriteLine("Digite verdadero si es hombre: ");
    sexoMasculino = Convert.ToBoolean(Console.ReadLine());
    // validacion
    if (sexoMasculino == true )
    {
     Console.WriteLine("Felicidades, es hombre");
    }
    else{
        Console.WriteLine("Felicidades, es mujer");
    }
    Console.WriteLine("proceso terminado.");
  }
}
