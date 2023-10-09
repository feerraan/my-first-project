using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private int legs = 4;
    [SerializeField] private string nombre;

    private void Start()
    {
        Debug.Log(message: $"{nombre} tiene {legs} patas");
    }
}
