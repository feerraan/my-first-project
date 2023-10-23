using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{
    [SerializeField] private int num;
    [SerializeField] private int edad;
    // Start is called before the first frame update
    void Start()
    {

        if (num % 2 == 0)
        {
            Debug.Log(message:$"{num} es par");
        }
        
        if (edad >= 18)
        {
            Debug.Log(message: $"Si es mayor de edad porque tiene {edad} años");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
