using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Entregable3 : MonoBehaviour
{
    [SerializeField] private int num1;
    [SerializeField] private int num2;
    [SerializeField] private string letra;
    private float result;
    private string vocal;
    
    // Start is called before the first frame update
    void Start()
    {
        result = Math.Max(num1, num2);
        Debug.Log($"El numero mayor entre {num1} y {num2} es: {result}");
         
        vocal ==;
        if (letra == "a, e, i, o, u")
        {
            Debug.Log($"{letra} es una vocal");

        }
        else
        {
            Debug.Log($"{letra} es una consonante");
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
