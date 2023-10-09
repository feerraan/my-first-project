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
    }
}
