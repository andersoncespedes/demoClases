
namespace DemoClases.View;

public class MainMenu
{
    public MainMenu()
    {

    }

    public int menu()
    {
            //Console.Clear();
            Console.WriteLine("1.Registro panel");
            Console.WriteLine("2.Consulta de datos");
            Console.WriteLine("3.Crear liga");
            Console.WriteLine("4.Salir");
            return int.Parse(Console.ReadLine());
    }  
}
