//Como aprendimos en la introducción a este desafío, el ganador del juego estará determinado por tres reglas simples:
//La piedra gana a tijera
//La tijera gana a papel
//El papel gana a piedra
//En este desafío, se le pedirá que cree un juego de piedra, papel y tijera simple. El juego debe ser jugado por dos jugadores, el usuario y la computadora.
//El programa debe hacer lo siguiente:
//Pedir al usuario que elija piedra, papel o tijera.
//Permitir que la computadora elija piedra, papel o tijera al azar.
//Mostrar la elección de la computadora.
//Mostrar un mensaje que indique si el usuario ganó, perdió o empató.
//Preguntar al usuario si desea jugar de nuevo.
//Si el usuario decide jugar de nuevo, el programa debe volver a ejecutarse. Si el usuario decide no jugar de nuevo, el programa debe cerrarse.
//Para este desafío, puede utilizar la clase Random para generar un número aleatorio que represente la elección de la computadora. Puede asignar un número a cada opción (piedra, papel o tijera) y utilizar una declaración switch para determinar la elección de la computadora.
//Para obtener una entrada del usuario, puede utilizar la clase Console y el método ReadLine. Puede utilizar una declaración if para determinar si el usuario ha ingresado una opción válida (piedra, papel o tijera).
//Para determinar el resultado del juego, puede utilizar una declaración if con múltiples condiciones para verificar todas las posibles combinaciones de elecciones del usuario y la computadora.
//Para preguntar al usuario si desea jugar de nuevo, puede utilizar una declaración if con una condición que verifique si el usuario ha ingresado "sí" o "no".
//A continuación, se muestra un ejemplo de cómo podría verse la salida del programa:
//Elige piedra, papel o tijera: piedra
//La computadora eligió papel.
//Perdiste.
//¿Quieres jugar de nuevo? (sí/no): sí
//Elige piedra, papel o tijera: papel
//La computadora eligió tijera.
//Perdiste.
//¿Quieres jugar de nuevo? (sí/no): no
//Gracias por jugar.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] choices = { "piedra", "papel", "tijera" };
            string userChoice;
            string computerChoice;
            string playAgain;
            do
            {
                Console.WriteLine("Elige piedra, papel o tijera:");
                userChoice = Console.ReadLine();
                computerChoice = choices[random.Next(0, 3)];
                Console.WriteLine("La computadora eligió " + computerChoice + ".");
                if (userChoice == computerChoice)
                {
                    Console.WriteLine("Empate.");
                }
                else if ((userChoice == "piedra" && computerChoice == "tijera") || (userChoice == "tijera" && computerChoice == "papel") || (userChoice == "papel" && computerChoice == "piedra"))
                {
                    Console.WriteLine("Ganaste.");
                }
                else
                {
                    Console.WriteLine("Perdiste.");
                }
                Console.WriteLine("¿Quieres jugar de nuevo? (s/n):");
                playAgain = Console.ReadLine();
            } while (playAgain == "s");
            Console.WriteLine("Gracias por jugar.");
        }
    }
}

