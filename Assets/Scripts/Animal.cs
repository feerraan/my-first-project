using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private int legs = 4;
    [SerializeField] private string nombre;
    private bool hasmorethan2legs;

    private void Start()
    {
        hasmorethan2legs = legs > 2;

        if(hasmorethan2legs == true)
        {
            Debug.Log(message: $"{nombre} tiene {legs} patas: {hasmorethan2legs}");
            // COSAS
        }

        

    }
}
