using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoClases.Clases;
class Jugador : Persona {
    public string dorsal { get; set; }
    public string posicion { get; set; }
    public int nivelHabilidad { get; set; }

    public int? idEquipo {get; set; }

    public Jugador (string nombre, int id, int edad, string ciudadOrigen, string dorsal,string posicion, int nivelHabilidad): base (nombre,id,edad,ciudadOrigen){
        this.dorsal = dorsal;
        this.posicion = posicion;
        this.nivelHabilidad = nivelHabilidad;
    }
    public Jugador(){

    }
    public void CrearJugador(List<Liga> ligas){
        Equipo equipo = new();
        Equipo equipoSeleccionado = equipo.BuscarEquipos(ligas);
        Console.Write("Nombre->");
        string nombre = Console.ReadLine();
        Console.Write("edad->");
        int edad = int.Parse(Console.ReadLine());
        Console.Write("Ciudad de Origen->");
        string ciudadOrigen = Console.ReadLine();
        Console.Write("Dorsal->");
        string dorsal = Console.ReadLine();
        Console.Write("Posicion->");
        string posicion = Console.ReadLine();
        Console.Write("Nivel de Habilidad->");
        int nivelHabilidad = int.Parse(Console.ReadLine());
        Jugador jugador = new(nombre,1,edad, ciudadOrigen, dorsal, posicion, nivelHabilidad);
        equipoSeleccionado.jugadores.Add(jugador);
    }
    public void Delanteros(List<Liga> ligas){
        Equipo equipo = new();
        Equipo equipoSeleccionado = equipo.BuscarEquipos(ligas);
        Console.WriteLine("Nombre\tEdad\tCiudad de Origen\t");
        foreach(Jugador delantero in equipoSeleccionado.jugadores.FindAll(e => e.posicion.Equals("delantero"))){
            Console.WriteLine($"{delantero.nombre}\t{delantero.edad}\t{delantero.ciudadOrigen}");
        }
        Console.Write("Presione Enter Para Continuar-> ");
        Console.ReadLine();
    }
}