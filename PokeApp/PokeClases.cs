using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PokeApp
{
    // CLASE ENTRENADOR
    internal class Entrenador
    {
        public string Nombre;
        public List<Pokemon> Pokemones;


        public Entrenador(string nombre, List<Pokemon> pokemones)
        {
            Nombre = nombre;
            Pokemones = pokemones;
        }
    }

    // CLASE MOVIMIENTO
    internal class Movimiento
    {
        public string Nombre;
        public string Tipo;
        public string Categoria;
        public int Poder;
        public int Punteria;

        // Constructor
        public Movimiento(string nombre, string tipo, string categoria, int poder, int punteria)
        {
            Nombre = nombre;
            Tipo = tipo;
            Categoria = categoria; // tiene dos variaciones especial o fìsico
            Poder = poder;
            Punteria = punteria;
        }

        // Constructor clonador: Creamos una nueva instancia que copia los datos del movimiento original dado.
        public Movimiento(Movimiento otro)
        {
            Nombre = otro.Nombre;
            Tipo = otro.Tipo;
            Categoria = otro.Categoria; // tiene dos variaciones especial o fìsico
            Poder = otro.Poder;
            Punteria = otro.Punteria;
        }


        // Método Clone : una función que usa al clonador para devolver una copia.
        public Movimiento Clone()
        {
            return new Movimiento (this);
        }

    }

    // CLASE POKEMON
    internal class Pokemon
    {
        public string Nombre;
        public string Tipo;
        public int Atq;
        public int Def;
        public int AtqEsp;
        public int DefEsp;
        public int PS; 
        public int PSMax; 
        public int Velocidad;
        public List<Movimiento> Movimientos;

        // Constructor común : Creamos el Pkmn dsd cero.
        public Pokemon(string nombre, string tipo, int atq, int def, int atqEsp, int defEsp, int ps, int psMax, int velocidad, List<Movimiento> movimientos)
        {
            Nombre = nombre;
            Tipo = tipo;
            Atq = atq;
            Def = def;
            AtqEsp = atqEsp;
            DefEsp = defEsp;
            PS = ps;
            PSMax = psMax;
            Velocidad = velocidad;
            Movimientos = movimientos;
        }

        public Pokemon(Pokemon otro)
        {
            Nombre = otro.Nombre;
            Tipo = otro.Tipo;   
            Atq = otro.Atq;
            Def = otro.Def;
            AtqEsp = otro.AtqEsp;
            DefEsp = otro.DefEsp;
            PS = otro.PS;
            PSMax = otro.PSMax;
            Velocidad = otro.Velocidad;
            // Acá cuidado porque clonamos movimiento a movimiento para q sean instancias separadas, para a futuro ver pp, stats , reducciones , etc.
            Movimientos = otro.Movimientos
                .Select(Movimiento => Movimiento.Clone()) // Clonamos cada movimiento
                .ToList(); // Metemos cada movimiento en la lista.
        }


        // Método Clone : Delegamos en el constructor.
        public Pokemon Clone()
        {
            return new Pokemon(this);
        }

    }

    
    // DICCIONARIO DE TIPOS - EFICACIA
    public static class TablaDeTipos // Hice un diccionario con tuplas de tipos como Key y el multiplicador de la eficacia.
    {
        public static readonly Dictionary<(string, string), float> efectividades = new()
        // diccionario (key,valor)
        {
            // NORMAL
            { ("Normal", "Roca"), 0.5f },           // Poco efectivo
            
            { ("Normal", "Fantasma"), 0f },         // No afecta
            
            // FUEGO
            { ("Fuego", "Planta"), 2f },            // Súper efectivo
            { ("Fuego", "Hielo"), 2f },             // Súper efectivo
            { ("Fuego", "Bicho"), 2f },             // Súper efectivo

            { ("Fuego", "Fuego"), 0.5f },           // Poco efectivo
            { ("Fuego", "Agua"), 0.5f },            // Poco efectivo
            { ("Fuego", "Roca"), 0.5f },            // Poco efectivo
            { ("Fuego", "Dragón"), 0.5f },          // Poco efectivo
            
            // AGUA
            { ("Agua", "Fuego"), 2f },              // Súper efectivo
            { ("Agua", "Tierra"), 2f },             // Súper efectivo
            { ("Agua", "Roca"), 2f },               // Súper efectivo

            { ("Agua", "Agua"), 0.5f },             // Poco efectivo
            { ("Agua", "Planta"), 0.5f},            // Poco efectivo
            { ("Agua", "Dragon"), 0.5f},            // Poco efectivo

            // ELECTRICO
            { ("Electrico", "Agua"), 2f},           // Súper efectivo
            { ("Electrico", "Volador"), 2f},        // Súper efectivo

            { ("Electrico", "Electrico"), 0.5f},    // Poco efectivo
            { ("Electrico", "Planta"), 0.5f},       // Poco efectivo
            { ("Electrico", "Dragon"), 0.5f},       // Poco efectivo

            { ("Electrico", "Tierra"), 0f},         // No afecta

            // PLANTA
            { ("Planta", "Agua"), 2f},              // Súper efectivo
            { ("Planta", "Tierra"), 2f},            // Súper efectivo
            { ("Planta", "Roca"), 2f},              // Súper efectivo

            { ("Planta", "Fuego"), 0.5f},           // Poco efectivo
            { ("Planta", "Planta"), 0.5f},          // Poco efectivo
            { ("Planta", "Veneno"), 0.5f},          // Poco efectivo
            { ("Planta", "Volador"), 0.5f},         // Poco efectivo
            { ("Planta", "Bicho"), 0.5f},           // Poco efectivo
            { ("Planta", "Dragon"), 0.5f},          // Poco efectivo

            // HIELO
            { ("Hielo", "Planta"), 2f},             // Súper efectivo
            { ("Hielo", "Tierra"), 2f},             // Súper efectivo
            { ("Hielo", "Volador"), 2f},            // Súper efectivo
            { ("Hielo", "Dragon"), 2f},             // Súper efectivo

            { ("Hielo", "Agua"), 0.5f},             // Poco efectivo
            { ("Hielo", "Hielo"), 0.5f},            // Poco efectivo
            
            // LUCHA
            { ("Lucha", "Normal"), 2f},             // Súper efectivo
            { ("Lucha", "Hielo"), 2f},              // Súper efectivo
            { ("Lucha", "Roca"), 2f},               // Súper efectivo

            { ("Lucha", "Veneno"), 0.5f},           // Poco efectivo
            { ("Lucha", "Volador"), 0.5f},          // Poco efectivo    
            { ("Lucha", "Psiquico"), 0.5f},         // Poco efectivo
            { ("Lucha", "Bicho"), 0.5f},            // Poco efectivo

            { ("Lucha", "Fantasma"), 0f},           // No afecta    
            
            // VENENO
            { ("Veneno", "Planta"), 2f},            // Súper efectivo
            { ("Veneno", "Bicho"), 2f},             // Súper efectivo
                
            { ("Veneno", "Veneno"), 0.5f},          // Poco efectivo
            { ("Veneno", "Tierra"), 0.5f},          // Poco efectivo
            { ("Veneno", "Roca"), 0.5f},            // Poco efectivo
            { ("Veneno", "Fantasma"), 0.5f},        // Poco efectivo
        
            // TIERRA
            { ("Tierra", "Fuego"), 2f},             // Súper efectivo
            { ("Tierra", "Electrico"), 2f},         // Súper efectivo
            { ("Tierra", "Veneno"), 2f},            // Súper efectivo
            { ("Tierra", "Roca"), 2f},              // Súper efectivo

            { ("Tierra", "Planta"), 0.5f},          // Poco efectivo
            { ("Tierra", "Bicho"), 0.5f},           // Poco efectivo

            { ("Tierra", "Volador"), 0f},           // No afecta  

            // VOLADOR
            { ("Volador", "Planta"), 2f},           // Súper efectivo
            { ("Volador", "Lucha"), 2f},            // Súper efectivo
            { ("Volador", "Bicho"), 2f},            // Súper efectivo

            { ("Volador", "Electrico"), 0.5f},      // Poco efectivo
            { ("Volador", "Roca"), 0.5f},           // Poco efectivo

            // PSIQUICO
            { ("Psiquico", "Lucha"), 2f},           // Súper efectivo
            { ("Psiquico", "Veneno"), 2f},          // Súper efectivo

            { ("Psiquico", "Psiquico"), 0.5f},      // Poco efectivo

            // BICHO
            { ("Bicho", "Planta"), 2f },            // Súper efectivo
            { ("Bicho", "Veneno"), 2f },            // Súper efectivo
            { ("Bicho", "Psiquico"), 2f },          // Súper efectivo

            { ("Bicho", "Fuego"), 0.5f },           // Poco efectivo
            { ("Bicho", "Lucha"), 0.5f },           // Poco efectivo
            { ("Bicho", "Volador"), 0.5f },         // Poco efectivo
            { ("Bicho", "Fantasma"), 0.5f },        // Poco efectivo


            // ROCA
            { ("Roca", "Fuego"), 2f },              // Súper efectivo
            { ("Roca", "Hielo"), 2f },              // Súper efectivo
            { ("Roca", "Volador"), 2f },            // Súper efectivo   
            { ("Roca", "Bicho"), 2f },              // Súper efectivo

            { ("Roca", "Lucha"), 0.5f },            // Poco efectivo
            { ("Roca", "Tierra"), 0.5f },           // Poco efectivo

            // FANTASMA
            { ("Fantasma", "Psiquico"), 2f},        // Súper efectivo (Este era un error en el juego original, el daño era nulo)
            { ("Fantasma", "Fantasma"), 2f},        // Súper efectivo

            { ("Fantasma", "Dragon"), 0f},          // No afecta
            
            // DRAGON
            { ("Dragon", "Dragon"), 2f},           // Súper efectivo

        };

        public static float ObtenerEfectividad(string tipoMovimiento, string tipoDefensor) // es float por el 1/2
        {
            if (efectividades.TryGetValue((tipoMovimiento, tipoDefensor), out float valor)) // Intenta obtener el valor si existe la clave. Utilizo try xq me interesa el caso en el que no encuentra clave, es justamente el caso default.
            {
                return valor;
            }
            return 1f; // // Efectividad neutra por defecto (Es el valor default que se usa al no encontrar la key deseada).
        }


    }


    // COLOREAR TEXTO
    internal class Colorizar
    {
        public string tipo; // Ojo q no sea NULL
        public ConsoleColor color;


        public Colorizar(string tipoDeAtaque)
        {
            tipo = tipoDeAtaque;
            color = ObtenerColor(tipoDeAtaque);
        }





        public static readonly Dictionary<string, ConsoleColor> colorpedia = new()
        {
            { "Fuego", ConsoleColor.Red },
            { "Agua", ConsoleColor.Blue },
            { "Planta", ConsoleColor.Green },
            { "Electrico", ConsoleColor.Yellow },
            { "Hielo", ConsoleColor.Cyan },
            { "Lucha", ConsoleColor.DarkRed },
            { "Veneno", ConsoleColor.Magenta },
            { "Tierra", ConsoleColor.DarkYellow },
            { "Volador", ConsoleColor.Gray },
            { "Psiquico", ConsoleColor.Magenta },
            { "Bicho", ConsoleColor.DarkGreen },
            { "Roca", ConsoleColor.DarkGray },
            { "Fantasma", ConsoleColor.DarkMagenta },
            { "Dragon", ConsoleColor.DarkBlue },
            { "Normal", ConsoleColor.White }
        };


        public static ConsoleColor ObtenerColor(string tipoBuscado)
        {
            if (Colorizar.colorpedia.TryGetValue(tipoBuscado, out ConsoleColor value))
            {
                return value;
            }
            return ConsoleColor.White; // color por defecto si no se encuentra el tipo
        }


        public static void EscribirConColor(string texto, string tipo)
        {
            var original = Console.ForegroundColor;
            Console.ForegroundColor = ObtenerColor(tipo);
            Console.WriteLine(texto);
            Console.ForegroundColor = original;
        }

    }
    // Recibe un tipo y cambia el color del texto por el color asignado a ese tipo

}


// IF ABIERTOS DEL OPERADOR TERNARIO.
//Movimiento movimientoUsado;

//if (pokemon == atacante)
//{
//    movimientoUsado = movimientoAtq;
//}
//else
//{
//    movimientoUsado = movimientoDef;
//}

//Pokemon objetivo;

//if (pokemon == atacante)
//{
//    objetivo = defensor;
//}
//else
//{
//    objetivo = atacante;
//}
