namespace DemoClases.View;

public class MenuBusqueda
{
    public MenuBusqueda()
    {
    }
    public int menuBuscar()
    {
            Console.Clear();
            Console.WriteLine("1.Listar Jugadores por equipo");
            Console.WriteLine("2.Buscar delanteros de cada equipo");
            Console.WriteLine("3.Buscar cuerpo de entrenadores");
            Console.WriteLine("4.Registro Masajista");
            Console.WriteLine("5.Regresar menu");
            return int.Parse(Console.ReadLine());
    }
}
