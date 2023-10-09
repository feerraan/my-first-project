using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
    
{
    [SerializeField] private float num1;
    [SerializeField] private float num2;
    [SerializeField] private int num;

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(message: $"El resultado de la suma entre {num1} y {num2} es: {num1 + num2} ");
        Debug.Log(message: $"El resultado de la resta entre {num1} y {num2} es: {num1 - num2}");
        Debug.Log(message: $"El resultado de la multiplicación entre {num1} y {num2} es: {num1 * num2}");
        Debug.Log(message: $"El resultado de la división entre {num1} y {num2} es: {num1 / num2}");
       

        Debug.Log(num % 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
