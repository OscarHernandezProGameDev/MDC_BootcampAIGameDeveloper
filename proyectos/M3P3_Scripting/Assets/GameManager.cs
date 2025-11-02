using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Animal animal;
    public Vehiculo vehiculo;
    public Curso curso;

    private void Start()
    {
        Debug.Log("Game Manager inicializado");
        if (animal)
        {
            Debug.Log("Ejecutando metodos del animal");
            animal.ImprimirValores();
            animal.DescribirClase();
            animal.RecorrerArrays();
            animal.MostrarDescubridor();
        }
        else
            Debug.Log("No se asignado la referencia de Animal al Game Manager");

        if (vehiculo)
        {
            Debug.Log("Ejecutando metodos del vehículo");
            vehiculo.ImprimirValores();
            vehiculo.DescribirClase();
            vehiculo.RecorrerArrays();
            vehiculo.MostrarITV();
        }
        else
            Debug.Log("No se asignado la referencia de Vehiculo al Game Manager");

        if (curso)
        {
            Debug.Log("Ejecutando metodos del curso");
            curso.ImprimirValores();
            curso.DescribirClase();
            curso.RecorrerArrays();
            curso.MostrarProfesor();
        }
        else
            Debug.Log("No se asignado la referencia de Curso al Game Manager");
    }
}