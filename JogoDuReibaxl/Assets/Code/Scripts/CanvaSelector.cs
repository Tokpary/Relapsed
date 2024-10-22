using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputManagerEntry;
using UnityEngine.UI;
using TMPro;

public class CanvaSelector : MonoBehaviour
{
    [SerializeField] private Sprite[] imagen;
    [SerializeField] private Image campoImagen;

    [SerializeField] private List<string> nombre = new List<string>(5);
    [SerializeField] private TMP_InputField campoNombre;

    [SerializeField] private List<string> nacimiento = new List<string>(5);
    [SerializeField] private TMP_InputField campoNacimiento;

    [SerializeField] private List<string> creencia = new List<string>(5);
    [SerializeField] private TMP_InputField campoCreencia;

    [SerializeField] private List<string> estadoCivil = new List<string>(5);
    [SerializeField] private TMP_InputField campoEstadoCivil;

    [SerializeField] private List<string> ocupacion = new List<string>(5);
    [SerializeField] private TMP_InputField campoOcupacion;

    [SerializeField] private List<string> hobbies = new List<string>(5);
    [SerializeField] private TMP_InputField campoHobbies;

    [SerializeField] private List<string> observaciones = new List<string>(5);
    [SerializeField] private TMP_InputField campoObservaciones;

    [SerializeField] private List<string> traumas = new List<string>(5);
    [SerializeField] private TMP_InputField campoTraumas;




    private int currentIndx = 0;



    public void saveR()
    {
 
        nombre[currentIndx] = campoNombre.text;
        nacimiento[currentIndx] = campoNacimiento.text;
        creencia[currentIndx] = campoCreencia.text;
        estadoCivil[currentIndx] = campoEstadoCivil.text;
        ocupacion[currentIndx] = campoOcupacion.text;
        hobbies[currentIndx] = campoHobbies.text;
        observaciones[currentIndx] = campoObservaciones.text;
        traumas[currentIndx] = campoTraumas.text;

        currentIndx++;
        if (currentIndx > 4)
        {
            currentIndx = 0; // Volver al primero
        }

        actualizarFicha();

    }

    public void saveL()
    {
        nombre[currentIndx] = campoNombre.text;
        nacimiento[currentIndx] = campoNacimiento.text;
        creencia[currentIndx] = campoCreencia.text;
        estadoCivil[currentIndx] = campoEstadoCivil.text;
        ocupacion[currentIndx] = campoOcupacion.text;
        hobbies[currentIndx] = campoHobbies.text;
        observaciones[currentIndx] = campoObservaciones.text;
        traumas[currentIndx] = campoTraumas.text;

        currentIndx--;
        if (currentIndx < 0)
        {
            currentIndx = 4; // Volver al último
        }

        actualizarFicha();

    }

    public void actualizarFicha()
    {
            campoImagen.sprite = imagen[currentIndx];
            campoNombre.text = nombre[currentIndx];
            campoNacimiento.text = nacimiento[currentIndx];
            campoCreencia.text = creencia[currentIndx];
            campoEstadoCivil.text = estadoCivil[currentIndx];
            campoOcupacion.text = ocupacion[currentIndx];
            campoHobbies.text = hobbies[currentIndx];
            campoObservaciones.text = observaciones[currentIndx];
            campoTraumas.text = traumas[currentIndx];
    }
}
