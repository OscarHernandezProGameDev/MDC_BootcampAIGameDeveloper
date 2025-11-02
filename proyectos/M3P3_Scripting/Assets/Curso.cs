using System;
using UnityEngine;

public class Curso : MonoBehaviour
{
    [Serializable]
    public struct Profesor
    {
        public string nombre;
        public string apellido;
        public int edad;

        public Profesor(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
    }

    [Serializable]
    public struct Analita
    {
        public int totalAlumnos;
        public int alumnosAcabadoCurso;

        public Analita(int totalAlumnos, int alumnosAcabadoCurso)
        {
            this.totalAlumnos = totalAlumnos;
            this.alumnosAcabadoCurso = alumnosAcabadoCurso;
        }
    }

    [SerializeField] private int duracion;
    [SerializeField] private float precio;
    [SerializeField] private string titulo;
    [SerializeField] private bool esBootcamp;
    [SerializeField] private float descuento;

    private string[] misCursos;
    private string[] codigosDescuentos;

    public int Duracion
    {
        get => duracion;
        set => duracion = value;
    }

    public float Precio
    {
        get => precio;
        set => precio = value;
    }

    public string Titulo
    {
        get => titulo;
        set => titulo = value;
    }

    public bool ESBootcamp
    {
        get => esBootcamp;
        set => esBootcamp = value;
    }

    public float Descuento
    {
        get => descuento;
        set => descuento = value;
    }

    public Profesor profesor;
    public Analita analita;

    public void ImprimirValores()
    {
        Debug.Log($"duracion: {duracion}");
        Debug.Log($"precio: {precio}");
        Debug.Log($"titulo: {titulo}");
        Debug.Log($"esBootcamp: {esBootcamp}");
        Debug.Log($"descuento: {descuento}");
    }

    public void DescribirClase()
    {
        Debug.Log("Describe una clase con sus propiedades más importante");
    }

    public void MostrarProfesor()
    {
        Debug.Log($"El profesor es {profesor.nombre} {profesor.apellido} de {profesor.edad} años");
    }

    public void RecorrerArrays()
    {
        Debug.Log("misCursos:");

        foreach (var curso in misCursos)
            Debug.Log(curso);

        Debug.Log("codigosDescuentos:");
        for (var i = 0; i < codigosDescuentos.Length; i++)
        {
            var descuentos = codigosDescuentos[i];

            Debug.Log(descuentos);
        }
    }

    private void Awake()
    {
        duracion = 40;
        precio = 200.15f;
        Titulo = "Aprenda C# en nivel experto";
        esBootcamp = true;
        descuento = 50f;
        misCursos = new string[]
        {
            "Aprenda C# en nivel experto",
            "Domine los principios Solid",
            "Deje de tener miedo a C++",
            "La historia de los lenguajes de programacion",
            "Fans de mortadelo y filemon"
        };
        codigosDescuentos = new string[] { "HORRORC++", "C#", "SOLID", "MORTADELO", "HIST" };
        profesor = new Profesor("Óscar", "Hernández Bañó", 54);
        analita = new Analita(30, 23);
    }

    private void Start()
    {
        Debug.Log("La clase curso se ha instanciado correctamente.");
    }
}