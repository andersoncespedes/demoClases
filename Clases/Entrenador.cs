using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoClases.Clases;
class Entrenador : Persona {
    public int codFederacion { get; set; }
    public string especialidad { get; set; }

    public Entrenador (string nombre, int id, int edad, string ciudadOrigen, int codFederacion,string especialidad): base (nombre,id,edad,ciudadOrigen){
        this.codFederacion = codFederacion;
        this.especialidad = especialidad;
    }
    public Entrenador(){

    }
    public void CrearEntrenador(List<Liga> ligas){
        Equipo equipo = new();
        Equipo equipoSeleccionado = equipo.BuscarEquipos(ligas);
        Console.Write("Nombre->");
        string nombre = Console.ReadLine();
        Console.Write("edad->");
        int edad = int.Parse(Console.ReadLine());
        Console.Write("Ciudad de Origen->");
        string ciudadOrigen = Console.ReadLine();
        Console.Write("Codigo de Federacion->");
        int codFederacion = int.Parse(Console.ReadLine());
        Console.Write("Especialidad->");
        string especialidad = Console.ReadLine();
        Entrenador entrenador = new(nombre,1,edad,ciudadOrigen, codFederacion, especialidad);
        equipoSeleccionado.entrenadores.Add(entrenador);

    }
}