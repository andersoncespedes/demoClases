using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoClases.Clases;

class Persona {
    public string nombre { get; set; }
    public int id { get; set; }
    public int edad { get; set; }
    public string ciudadOrigen {get; set;}

    public Persona (string nombre,int id,int edad, string ciudadOrigen){
        this.nombre = nombre;
        this.id = id;
        this.edad = edad;
        this.ciudadOrigen = ciudadOrigen;
    }
    public Persona(){
        
    }
} 

