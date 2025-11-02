using System;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [Serializable]
    public struct Descubridor
    {
        public string nombre;
        public DateTime fecha;

        public Descubridor(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fecha = fecha;
        }
    }

    [Serializable]
    public struct Clasificacion
    {
        public string clase;
        public string familia;
        public string nombreCientifico;

        public Clasificacion(string clase, string familia, string nombreCientifico)
        {
            this.clase = clase;
            this.familia = familia;
            this.nombreCientifico = nombreCientifico;
        }
    }

    [SerializeField] private int edad;
    [SerializeField] private float peso;
    [SerializeField] private string nombre;
    [SerializeField] private bool dormiendo;
    [SerializeField] private string familia;

    private string[] familias;
    private string[] animalesEnExtincion;

    public int Edad
    {
        get => edad;
        set => edad = value;
    }

    public float Peso
    {
        get => peso;
        set => peso = value;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public bool Dormiendo
    {
        get => dormiendo;
        set => dormiendo = value;
    }

    public string Familia
    {
        get => familia;
        set => familia = value;
    }

    public Descubridor descubridor;
    public Clasificacion clasificacion;

    public void ImprimirValores()
    {
        Debug.Log($"Edad: {edad}");
        Debug.Log($"Peso: {peso}");
        Debug.Log($"Nombre: {nombre}");
        Debug.Log($"Dormiendo: {dormiendo}");
        Debug.Log($"Familia: {familia}");
    }

    public void DescribirClase()
    {
        Debug.Log("Describe un animal con sus propiedades más simples");
    }

    public void RecorrerArrays()
    {
        Debug.Log("Familias:");

        foreach (var familia in familias)
            Debug.Log(familia);

        Debug.Log("Animales en extinción:");
        for (var i = 0; i < animalesEnExtincion.Length; i++)
        {
            var animal = animalesEnExtincion[i];

            Debug.Log(animal);
        }
    }

    public void MostrarDescubridor()
    {
        Debug.Log($"El descubridor fue {descubridor.nombre} en la fecha {descubridor.fecha}");
    }

    private void Awake()
    {
        edad = 4;
        peso = 20;
        nombre = "Perro";
        dormiendo = false;
        Familia = "Manifero";

        familias = new string[] { "Manifero", "Ave", "Insecto" };
        animalesEnExtincion = new string[]
        {
            "Oso polar",
            "Tigre de Sumatra",
            "Rinoceronte de Java",
            "Gorila de montaña",
            "Leopardo de Amur",
        };

        descubridor = new("El nombre", new DateTime());
        clasificacion = new Clasificacion("Manifero", "Canidae", "lupus familiaris");
    }

    private void Start()
    {
        Debug.Log("La clase animal se ha instanciado correctamente.");
    }
}