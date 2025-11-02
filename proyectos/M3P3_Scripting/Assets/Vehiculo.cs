using System;
using UnityEngine;

public class Vehiculo : MonoBehaviour
{
    [Serializable]
    public struct ADAS
    {
        public bool frenadoAutomaticoEmergencia;
        public bool controlCruceroAdaptativo;
        public bool mantenimientoCarril;

        public ADAS(bool frenado, bool controlCrucero, bool mantenimientoCarril)
        {
            this.frenadoAutomaticoEmergencia = frenado;
            this.controlCruceroAdaptativo = controlCrucero;
            this.mantenimientoCarril = mantenimientoCarril;
        }
    }

    [Serializable]
    public struct ITV
    {
        public DateTime fechaUltima;
        public bool fueFavorable;
        public DateTime fechaProximaITV;

        public ITV(DateTime fechaUltima, bool fueFavorable, DateTime fechaProximaITV)
        {
            this.fechaUltima = fechaUltima;
            this.fueFavorable = fueFavorable;
            this.fechaProximaITV = fechaProximaITV;
        }
    }

    [SerializeField] private int numeroCilindros;
    [SerializeField] private float litros;
    [SerializeField] private string modelo;
    [SerializeField] private bool tieneAlarma;
    [SerializeField] private string marca;

    private string[] marcas;
    private int[] potencias;

    public int NumeroCilindros
    {
        get => numeroCilindros;
        set => numeroCilindros = value;
    }

    public float Litros
    {
        get => litros;
        set => litros = value;
    }

    public string Modelo
    {
        get => modelo;
        set => modelo = value;
    }

    public bool TieneAlarma
    {
        get => tieneAlarma;
        set => tieneAlarma = value;
    }

    public string Marca
    {
        get => marca;
        set => marca = value;
    }

    public ADAS Adas;
    public ITV itv;

    private void Awake()
    {
        numeroCilindros = 4;
        litros = 23.3f;
        modelo = "IONIC";
        tieneAlarma = true;
        Marca = "Hyunday";

        marcas = new[]
        {
            "Hyunday", "Seat", "Ford", "Porsche", "Audi"
        };

        potencias = new int[] { 1400, 3600, 900, 600, 1100 };

        Adas = new ADAS(true, true, true);
        itv = new ITV(new DateTime(2025, 4, 4), true, new DateTime(2029, 4, 10));
    }
}