using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{ /*
     Comentario linea 1
     Comentario linea 2
     Comentario linea 3 
    */

    // Variable que representa la edad de un jugador
    [SerializeField] private int age = 18; // = 0;
    // Variable que representa la velocidad del jugador
    [SerializeField] private float speed = 1.5f; // = 0.0f
    //Variable que representa si el jugador está muerto o no
    [SerializeField] private bool isGameOver = false; // = false
    //Variable que representa el nombre del jugador
    [SerializeField] private string username; // = ""
    [SerializeField] private float num1;
    [SerializeField] private float num2;
    [SerializeField] private float coins;
    private float result;

    [SerializeField] private int hour;



    private void Start()
    {
        /*
        Debug.Log("Hola, mundo!");
        Debug.Log(username);
        Debug.Log(age);
        Debug.Log(speed);
        Debug.Log(isGameOver);

        // Forma 1
        Debug.Log(message: $"El nombre del usuario es: {username}");

        // Forma 2
        Debug.Log(message: string.Format("La velocidad del usuario es {0} m/s", speed));
        Debug.Log(message:string.Format("El usuario {0} va a {1} m/s.",username,speed));

        // Forma 3
        Debug.Log(message: "El usuario tiene " + age + " años.");
        */

        /*
        Debug.Log(message: 2 + 5);
        Debug.Log(message: num1 + num2);
        Debug.Log(message: num1 + 10);

        result = num1 + num2;
        Debug.Log(result);


        Debug.Log(message:$"Monedas: {coins}");
        // coins = coins + 10;
        coins += 10;
        Debug.Log(message:$"Monedas; {coins}");
        */


        /*
        Debug.Log(message:$"{num1} + {num2} = {num1 + num2}");
        Debug.Log(message: $"{num1} -{num2} = {num1 -num2}");
        Debug.Log(message: $"{num1} *{num2} = {num1 *num2}");
        Debug.Log(message: $"{num1} /{num2} = {num1 /num2}");

        // +=
        coins = coins + 5;
        coins += 5;

        coins += 1;
        coins++;

        // -=
        coins = coins - 5;
        coins -= 5;

        coins -= 1;
        coins--;

        // *=
        coins = coins * 5;
        coins *= 5;

        // /=
        coins = coins / 5;
        coins /= 5;
        */

        // 0,1,2,3,4,5,6,7,8,9,10,11
        Debug.Log(hour % 12);

        /*
       // OPERADORES CONDICIONALES
       // Igualdad ==
       // true si los objetos son iguales
       // false si los objetos son diferentes
       // Debug.Log(num1 == num2); 

       // Desigualdad !=
       // true si los objetos son diferentes
       // false si los objetos son iguales
       // Debug.Log(num1 != num2);

       // Menor <
       // true si el número de la izq es más pequeño que el de la der
       // false si el número de la izq es mayor o igual al de la der
       Debug.Log(num1 < num2);

       // Mayor >
       // true si el número de la izq es más grande que el de la der
       // false si el número de la izq es menor o igual al de la der
       Debug.Log(num1 > num2);

       // Menor o igual <=
       // true si el número de la izq es menor o igual al de la der
       // false si el número de la izq es mayor al de la der
       Debug.Log(num1 <= num2);

       // Mayor o igual >=
       // true si el número de la izq es mayor o igual al de la der
       // false si el número de la izq es menor al de la der
       Debug.Log(num1 >= num2);
       */
        /*
        if (num > 0)
        {
            Debug.Log($"{num} es positivo");
        }
        */

        
    }
}
