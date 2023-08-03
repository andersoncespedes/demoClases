using DemoClases.View;
using DemoClases.Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Liga> Ligas = new List<Liga>(); 
        MainMenu menu = new MainMenu();
        int opcion = 0;
        do
        {
            opcion = menu.menu();
            switch (opcion)
            {
                case 1:
                    int opcionPlantel = 0;
                    MenuPlantel menuPlantel = new MenuPlantel();
                    do
                    {
                        opcionPlantel = menuPlantel.menuPlantel();
                        switch (opcionPlantel)
                        {
                            case 1:
                                Liga ligabuscar= new ();
                                Liga opcionliga=ligabuscar.buscarLiga(Ligas);
                                Console.WriteLine(opcionliga.nombre);
                                Equipo equipo = new ();
                                Equipo nuevoequipo = equipo.AgregarEquipo();
                                Console.WriteLine(nuevoequipo.nombre);
                                opcionliga.EquiposDeLiga.Add(nuevoequipo);
                                break;
                            case 2:
                                Jugador jugador = new();
                                jugador.CrearJugador(Ligas);
                                break;
                            case 3:
                                Entrenador entrenador = new();
                                entrenador.CrearEntrenador(Ligas);
                                break;
                            default:
                                break;
                        }
                    } while (opcionPlantel != 6);
                    break;
                case 2:
                    int opcionBuscar = 0;
                    MenuBusqueda menuBusqueda = new MenuBusqueda ();
                    do
                    {
                        opcionBuscar = menuBusqueda.menuBuscar();
                        switch (opcionBuscar){
                            case 1:
                                Equipo equipos = new();
                                equipos.BuscarEquipos(Ligas);
                                break;
                            case 2:
                                Jugador jugador = new();
                                jugador.Delanteros(Ligas);
                                break;

                        }
                    } while (opcionBuscar != 5);
                    break;
                case 3:
                    Liga liga = new Liga();
                    Ligas.Add(liga.agregarLiga());
                    liga.mostrarLigas(Ligas);
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        } while (opcion != 4);
    }



}



