using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoClases.Clases;
class Equipo {
    public string nombre { get; set; }
    public List <string> propietarios { get; set; }
    public List<Jugador> jugadores { get; set; }
    public List<Masajista> masajistas { get; set; }
    public List<Entrenador> entrenadores { get; set; }

    public Equipo (string nombre){
        this.nombre = nombre;
        this.propietarios = new List<string>();
        this.jugadores = new List<Jugador>();
        this.masajistas = new List<Masajista>();
        this.entrenadores = new List<Entrenador>();
    }
    public Equipo(){
        this.propietarios = new List<string>();
        this.jugadores = new List<Jugador>();
        this.masajistas = new List<Masajista>();
        this.entrenadores = new List<Entrenador>();
    }

    public Equipo AgregarEquipo(){
        Equipo equipo = new();
        Console.Write("Ingrese el nombre del equipo :");
        equipo.nombre = Console.ReadLine();
        return equipo;
    }
    public void ListarEquipos(List<Equipo> equipoList){
        foreach(var equipo in equipoList){
            Console.WriteLine(equipo.nombre);
        }
    }
    public void MostrarEquipo(Equipo equipo){
        Console.WriteLine(equipo.nombre);
        Console.WriteLine($"Jugadores {equipo.jugadores.Count()}");
        Console.WriteLine($"Entrenadores {equipo.entrenadores.Count()}");
        Console.WriteLine($"Masajistas {equipo.masajistas.Count()}");
        Console.Write("Presione Enter Para Continuar-> ");
        Console.ReadLine();
    }
    public Equipo BuscarEquipos(List<Liga> ligas){
        Liga liga1 = new();
        liga1.mostrarLigas(ligas);
        Console.Write("Seleccione una liga -> ");
        int SeleccionLiga = int.Parse(Console.ReadLine());
        Liga ligaSeleccionada = ligas.Find(e => e.Id == SeleccionLiga);
        ListarEquipos(ligaSeleccionada.EquiposDeLiga);
        Console.Write("Seleccione un Equipo-> ");
        string seleccionEquipo = Console.ReadLine();
        Equipo equipoSeleccionado = ligaSeleccionada.EquiposDeLiga.Find(e => e.nombre.Equals(seleccionEquipo));
        MostrarEquipo(equipoSeleccionado);
        return equipoSeleccionado;
    }


}