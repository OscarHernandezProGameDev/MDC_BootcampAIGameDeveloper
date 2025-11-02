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

    private void Awake()
    {
        edad = 4;
        peso = 20;
        nombre = "Perro";
        Familia = "Canidae";

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
}