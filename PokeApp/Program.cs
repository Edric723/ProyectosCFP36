using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using PokeApp;

namespace PokeApp
{
    class Program
    {
        private static readonly Random rng = new(); // Implementación de random, para poder interactuar con la precisión de los ataques.

        static void Main()
        {
            // CREACIÓN DE MOVIMIENTOS:
            
            // 45454545454####

            Movimiento impactoElectrico = new("Impacto Electrico", "Electrico", "Especial", 40, 100);
            Movimiento corte = new("Corte", "Normal", "Fisico", 50, 95);
            Movimiento latigoCepa = new("Latigo Cepa", "Planta", "Especial", 45, 100);
            Movimiento hojaAfilada = new("Hoja Afilada", "Planta", "Fisico", 55, 95);
            Movimiento bofetonLodo = new("Bofeton Lodo", "Tierra", "Fisico", 20, 100);
            Movimiento arañazo = new("Arañazo", "Normal", "Fisico", 40, 100);
            Movimiento lanzallamas = new("Lanzallamas", "Fuego", "Especial", 90, 10);
            Movimiento pulsoDragon = new("Pulso Dragon", "Dragon", "Especial", 85, 100);
            Movimiento ondaIgnea = new("Onda Ignea", "Fuego", "Especial", 95, 90);
            Movimiento golpeCabeza = new("Golpe Cabeza", "Normal", "Fisico", 70, 100);
            Movimiento pistolaDeAgua = new("Pistola de Agua", "Agua", "Especial", 40, 100);
            Movimiento vientoHielo = new("Viento Hielo", "Hielo", "Especial", 55, 95);
            Movimiento psicoCorte = new("PsicoCorte", "Psiquico", "Fisico", 70, 100);
            Movimiento psicoRrayo = new("Psicorrayo", "Psiquico", "Especial", 65, 100);
            Movimiento puñoDinamico = new("Puño Dinamico", "Normal", "Fisico", 100, 50);
            Movimiento fuerza = new("Fuerza", "Normal", "Fisico", 80, 100);
            Movimiento golpeKarate = new("Golpe Karate", "Lucha", "Especial", 50, 100);
            Movimiento tumbaRocas = new("Tumba Rocas", "Roca", "Especial", 60, 95);
            Movimiento vuelo = new("Vuelo", "Volador", "Especial", 90, 95);
            Movimiento tornado = new("Tornado", "Volador", "Especial", 40, 100);
            Movimiento rayoHielo = new("Rayo Hielo", "Hielo", "Especial", 90, 100);
            Movimiento voltioCruel = new("Voltio Cruel", "Electrico", "Especial", 90, 100);
            Movimiento trueno = new("Trueno", "Electrico", "Especial", 110, 70);
            Movimiento llamaFinal = new("Llama Final", "Fuego", "Especial", 130, 100);
            Movimiento hiperRrayo = new("Hiperrayo", "Normal", "Especial", 150, 90);
            Movimiento garraUmbria = new("Garra Umbria", "Fantasma", "Fisico", 70, 100);
            Movimiento ondaToxica = new("Onda Toxica", "Veneno", "Especial", 95, 100);
            Movimiento gigaImpacto = new("Giga Impacto", "Normal", "Fisico", 150, 90);
            Movimiento colaDragon = new("Cola Dragon", "Dragon", "Fisico", 130, 90);

            // CREACIÓN DE POKEMONES:
            List<Movimiento> movimientosVenusaur = [corte, latigoCepa, hojaAfilada, bofetonLodo];
            Pokemon venusaur = new("Venusaur", "Planta", 263, 265, 299, 299, 364, 364, 259, movimientosVenusaur);

            List<Movimiento> movimientosCharizard = [lanzallamas, arañazo, llamaFinal, colaDragon];
            Pokemon charizard = new("Charizard", "Fuego", 267, 255, 317, 269, 360, 360, 299, movimientosCharizard);

            List<Movimiento> movimientosBlastoise = [pistolaDeAgua, golpeCabeza, fuerza, vientoHielo];
            Pokemon blastoise = new("Blastoise", "Agua", 265, 299, 269, 309, 362, 362, 255, movimientosBlastoise);

            List<Movimiento> movimientosAlakazam = [psicoCorte, corte, psicoRrayo, golpeCabeza];
            Pokemon alakazam = new("Alakazam", "Psiquico", 169, 159, 339, 239, 284, 284, 309, movimientosAlakazam);

            List<Movimiento> movimientosMachamp = [fuerza, golpeKarate, tumbaRocas, puñoDinamico];
            Pokemon machamp = new("Machamp", "Lucha", 359, 259, 299, 269, 384, 384, 209, movimientosMachamp);

            List<Movimiento> movimientosJinx = [hiperRrayo, vuelo, rayoHielo, vientoHielo];
            Pokemon jinx = new("Jinx", "Hielo", 269, 299, 289, 349, 384, 384, 269, movimientosJinx);

            List<Movimiento> movimientosZapdos = [tornado, voltioCruel, trueno, vuelo];
            Pokemon zapdos = new("Zapdos", "Electrico", 279, 269, 349, 279, 384, 384, 299, movimientosZapdos); // Este

            List<Movimiento> movimientosMoltres = [tornado, lanzallamas, ondaIgnea, llamaFinal];
            Pokemon moltres = new("Moltres", "Fuego", 299, 279, 349, 269, 384, 384, 279, movimientosMoltres); // Este

            List<Movimiento> movimientosDragonair = [colaDragon, gigaImpacto, pulsoDragon, fuerza];
            Pokemon dragonair = new("Dragonair", "Dragon", 267, 229, 239, 239, 326, 326, 239, movimientosDragonair);

            List<Movimiento> movimientosSnorlax = [gigaImpacto, fuerza, tumbaRocas, bofetonLodo];
            Pokemon snorlax = new("Snorlax", "Normal", 319, 229, 229, 319, 524, 524, 159, movimientosSnorlax);

            List<Movimiento> movimientosGengar = [garraUmbria, ondaToxica, arañazo, corte];
            Pokemon gengar = new("Gengar", "Fantasma", 199, 189, 329, 209, 294, 294, 289, movimientosGengar);

            List<Movimiento> movimientosPikachu = [impactoElectrico, voltioCruel, trueno, golpeCabeza];
            Pokemon pikachu = new("Pikachu", "Electrico", 209, 179, 199, 199, 274, 274, 179, movimientosPikachu);


            // Lista PULL de todos los pokemones
            List<Pokemon> pull = [venusaur, charizard, blastoise, alakazam, machamp, jinx, zapdos, moltres, dragonair, snorlax, gengar, pikachu];


            // Creando entrenadores - Podría implementar un readline y que el usuario haga la creación del entrenador a futuro.
            //Entrenador ash = new("Ash Ketchum", []);
            //Entrenador misty = new("Misty", []);

            Entrenador entrenador1 = new("", new List<Pokemon>());
            Entrenador entrenador2 = new("", new List<Pokemon>());

            //----------------------------------------------------------------------------------------------------------------------------
            InstanciarEntrenadores(entrenador1, entrenador2);
            SeleccionarEquipo(pull, entrenador1, entrenador2);
            MostrarDefinicionDeEquipos(entrenador1, entrenador2);
            AnunciarInicioDeCombate();
            EmularCombate(entrenador1, entrenador2);

        }


        public static void InstanciarEntrenadores(Entrenador entrenador1, Entrenador entrenador2)
        {
            Console.Write("Por favor ingresa tu nombre a continuación Entrenador/a: ");
            entrenador1.Nombre = Console.ReadLine() ?? "Entrenador Anónimo 1";

            Console.WriteLine();

            Console.Write("Por favor ingresa tu nombre a continuación Entrenador/a: ");
            entrenador2.Nombre = Console.ReadLine() ?? "Entrenador Anónimo 2";
        }


        // PRINTS DE INFO (POKEMON, MOVIMIENTOS)
        public static void MostrarDefinicionDeEquipos(Entrenador entrenador1, Entrenador entrenador2)
        {
            Console.WriteLine($"¡ASÍ QUEDARON DEFINIDOS LOS EQUIPOS DE CADA ENTRENADOR!");

            Console.WriteLine($"\nEquipo final de {entrenador1.Nombre}:");
            MostrarListaDePokemon(entrenador1.Pokemones);

            Console.WriteLine($"\nEquipo final de {entrenador2.Nombre}:");
            MostrarListaDePokemon(entrenador2.Pokemones);
        }

        public static void AnunciarInicioDeCombate()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine($"*****    ¡ES HORA DE INICIAR EL COMBATE!    *****");
            Console.WriteLine("**************************************************");
            Console.WriteLine();
        }

        public static void ImprimirDatosPokemon(Pokemon pokemon)
        {
            Colorizar colorTipo = new(pokemon.Tipo);

            Console.ForegroundColor = colorTipo.color; // Coloreo.

            string espacio = new(' ', 5);
            Console.WriteLine("╔═══════════════════════════════════════════════════╗");
            Console.WriteLine($"║{espacio}FICHA DE ENTRENAMIENTO DE: {pokemon.Nombre.ToUpper(),-19}║");
            Console.WriteLine("╠═══════════════════════════════════════════════════╣");
            Console.WriteLine($"║{espacio}Tipo:         {pokemon.Tipo,-32}║");
            Console.WriteLine($"║{espacio}PS:           {pokemon.PS,-32}║");
            Console.WriteLine($"║{espacio}Ataque:       {pokemon.Atq,-10} Defensa:    {pokemon.Def,-9}║");
            Console.WriteLine($"║{espacio}Atq. Esp:     {pokemon.AtqEsp,-10} Def. Esp:   {pokemon.DefEsp,-9}║");
            Console.WriteLine($"║{espacio}Velocidad:    {pokemon.Velocidad,-32}║");
            Console.WriteLine("╚═══════════════════════════════════════════════════╝\n");

            // Reseteo el color.
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void ImprimirMovimiento(Movimiento movimiento)
        {
            // Crear una instancia de Colorizar para poder obtener el color del tipo de movimiento y usarlo en la función.
            Colorizar colorTipo = new(movimiento.Tipo);

            // Aplico el color a todo el cuadro de info
            Console.ForegroundColor = colorTipo.color;

            Console.WriteLine();
            Console.WriteLine("╔═══════════════════════════════════════╗");
            Console.WriteLine($"║  📦  Movimiento: {movimiento.Nombre.ToUpper(),-21}║");
            Console.WriteLine("╠═══════════════════════════════════════╣");
            Console.WriteLine($"║ Tipo:      {movimiento.Tipo,-27}║");
            Console.WriteLine($"║ Categoría: {movimiento.Categoria,-27}║");
            Console.WriteLine($"║ Poder:     {movimiento.Poder,-27}║");
            Console.WriteLine($"║ Puntería:  {movimiento.Punteria,-27}║");
            Console.WriteLine("╚═══════════════════════════════════════╝");

            // Reseteo el color.
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void ImprimirSetMovimientos(Pokemon pokemon)
        {
            pokemon.Movimientos.ForEach(ImprimirMovimiento);
        }

        public static void AnunciarGanador(Entrenador trainer1, Entrenador trainer2) // Función para el display del entrenador Ganador.
        {
            string ganador = TieneEquipoDebilitado(trainer1.Pokemones) ? trainer2.Nombre : trainer1.Nombre; // Operador ternario

            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine($"*****      {ganador.ToUpper()} GANÓ EL COMBATE      *****");
            Console.WriteLine("**************************************************");
            Console.WriteLine();
        }


        // FUNCIÓN PARA SELECCIONAR EQUIPO (debe recibir la pull de pokemones, y 2 entrenadores)

        // DE LA PULL DE 12 POKEMONES, PERMITIR A DOS ENTRENADORES SELECCIONAR DE A UN POKEMON POR TURNO HASTA COMPLETAR UN EQUIPO DE 3
        // PARA DECIDIR QUIEN ELIGE PRIMERO, IMAGINO QUE LO RESOLVEREMOS POR RNG (DecidirPrimeraSeleccion(recibe 2 entrenadores como param.)
        // RESUELTO EL ORDEN DE LA ELECCIÓN, debemos seleccionar CUAL pokemon adicionar de la pull
        // ElegirPokemon( que dada una lista, seleccionamos un pokemon)
        // COMENZAR A ADICIONAR EL POKEMON SELECCIONADO A LA LISTA DE POKEMONES VACIAS DEL ENTREDADOR
        // SumarPkmnAlEquipo(recibe una lista de pkmns, un pokemon) Adicionamos el pokemon seleccionado.
        // Al sumar los 3 se completa la selección ---> se inicia el combate.


        public static void SeleccionarEquipo(List<Pokemon> Pull, Entrenador trainer1, Entrenador trainer2)
        {
            //Decidir la primera selección debe estar por fuera del bucle
            Entrenador primero = DecidirPrimeraSeleccion(trainer1, trainer2);

            // Si primero es igual a trainer1, entonces segundo es trainer2. Si el primero fue trainer2, entonces el segundo será trainer1.
            Entrenador segundo = (primero == trainer1) ? trainer2 : trainer1;

            Console.WriteLine($"¡SALISTE FAVORECIDO/A EN EL SORTEO PARA ELEGIR PRIMERO/A, ENTRENADOR/A: {primero.Nombre}!");
            Console.WriteLine();

            int turno = 0;

            // Mientras que el conteo de pokemones en el equipo de ambos entrenadores sea menor a 3, seleccionar.
            while (trainer1.Pokemones.Count + trainer2.Pokemones.Count < 6)
            {
                if (turno > 0)
                {
                    Console.Clear();
                }

                Entrenador actual = (EsTurnoPar(turno)) ? primero : segundo;


                Console.WriteLine($"ES TU TURNO DE ELEGIR POKEMON, ENTRENADOR/A {actual.Nombre}");
                Console.WriteLine();

                Pokemon elegido = ElegirPokemonDesdeLista(Pull); // Selecciono al pokemon que quiero sumar al equipo, de la pull.

                SumarPkmnAlEquipo(actual, elegido, Pull); // Adición del pokemon elegido al equipo del entrenador actual.

                turno++;
            }

            Console.Clear();


        }



        // FUNCIONES AUXILIARES PARA SeleccionarEquipo().
        public static Entrenador DecidirPrimeraSeleccion(Entrenador trainer1, Entrenador trainer2)
        {
            Random rng = new();
            return rng.Next(0, 2) == 0 ? trainer1 : trainer2; // Operador ternario.
            //if (numeroRandom < 1)
            //{
            //    return trainer1;
            //}
            //else
            //{
            //    return trainer2;
            //}
        }

        public static Pokemon ElegirPokemonDesdeLista(List<Pokemon> pokemons)
        {
            {
                //Console.WriteLine("Por favor elija un Pokémon de la siguiente lista:");
                //Console.WriteLine();



                int eleccion; // La puedo insertar pero prefiero conservarlo así para motivos de claridad.

                while (true)
                {
                    Console.WriteLine("Por favor elija un Pokémon de la siguiente lista:");
                    Console.WriteLine();
                    MostrarListaDePokemon(pokemons); // Mostramos todos los Pokémon disponible

                    Console.WriteLine();
                    Console.Write("Ingrese el número del Pokémon elegido: ");
                    string? input = Console.ReadLine(); // Pedimos que ingrese el número del pokemon elegido.

                    if (int.TryParse(input, out eleccion) && eleccion >= 1 && eleccion <= pokemons.Count) // Se lo parsea para no truncarlo, y por condición se exige la elección de un pokemon.
                    {
                        {
                            Pokemon elegido = pokemons[eleccion - 1];

                            // Mostrar datos del Pokémon
                            ImprimirDatosPokemon(elegido);
                            ImprimirSetMovimientos(elegido);

                            Console.Write("¿Deseás confirmar esta elección? (s/n): ");
                            Console.WriteLine();
                            string? confirmacion = Console.ReadLine()?.ToLower();

                            if (confirmacion == "s")
                            {
                                return elegido;
                            }
                            else
                            {
                                Console.WriteLine("Elección cancelada. Elegí otro Pokémon.");
                                Console.ReadKey(); // Pausa un segundo para que se vea el mensaje
                                Console.Clear();   // Limpia toda la consola
                                continue;          // Vuelve al principio del while

                            }
                        }
                    }

                    Console.WriteLine("Selección inválida. Intentá nuevamente."); // Error
                    Console.WriteLine();
                }
            }
        }

        public static void SumarPkmnAlEquipo(Entrenador trainer, Pokemon pokemon, List<Pokemon> pokemons)
        {
            if (trainer.Pokemones.Contains(pokemon))
            {
                Console.WriteLine($"El Pokemon {pokemon.Nombre} ya se forma parte del equipo, por favor selecciona otro Pokemon.");
                Console.WriteLine();
                ElegirPokemonDesdeLista(pokemons);
            }
            else
            {
                trainer.Pokemones.Add(pokemon.Clone());
            }
        }

        public static void MostrarListaDePokemon(List<Pokemon> pokemons)
        {
            for (int i = 0; i < pokemons.Count; i++) // Inicializando el índice en cero, por cada elemento presente en la lista de pokemones, numeralo y seguí iterando hasta llegar al tope de la lista.
            //   Iniciar contador   Condición                Iteración
            {
                Pokemon pokemon = pokemons[i];
                Colorizar.EscribirConColor($"{i + 1}. {pokemon.Nombre.ToUpper()}", pokemon.Tipo);
            }
        }

        public static bool EsTurnoPar(int turno) // Una función booleana que es verdadera cuando un turno es Par.
        {
            return turno % 2 == 0;
        }




        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------


        // FUNCIÓN PRINCIPAL PARA SIMULAR LOS TURNOS.
        public static void EmularCombate(Entrenador trainer1, Entrenador trainer2)
        {
            while (!TieneEquipoDebilitado(trainer1.Pokemones) && !TieneEquipoDebilitado(trainer2.Pokemones))
            {
                SimularTurno(trainer1, trainer2);
            }
            AnunciarGanador(trainer1, trainer2);
        }


        // FUNCION PARA UN TURNO
        public static Pokemon SimularTurno(Entrenador trainer1, Entrenador trainer2)
        {

            // Asignación de variables.
            Pokemon atacante = ElegirPokemon(trainer1);
            Pokemon defensor = ElegirPokemon(trainer2);

            while (!EstaDebilitado(atacante) && !EstaDebilitado(defensor))
            {
                Movimiento movimientoAtq = ElegirMovimiento(atacante);
                Movimiento movimientoDef = ElegirMovimiento(defensor);

                Pokemon elQueAtacaPrimero = DecidirPrimerGolpe(atacante, defensor); // Resolver cuál es el atacante y el defensor según la velocidad de los pokemones.
                Pokemon elQueAtacaDespues = (elQueAtacaPrimero == atacante) ? defensor : atacante; // Si el que atacó primero fue el atacante, el defensor ahora golpea.


                Movimiento movimientoRespuesta = (elQueAtacaPrimero == atacante) ? movimientoDef : movimientoAtq;


                //string nombreEntrenador = trainer1.Pokemones.Contains(elQueAtacaPrimero) ? trainer1.Nombre : trainer2.Nombre; // Para saber el nombre del entrenador del pokemon más veloz.

                //Esto dice: Le asigno a movimientoUsado el valor movimientoAtq si pokemon es igual a atacante, si no, asigno movimientoDef.
                Movimiento movimientoUsado = (elQueAtacaPrimero == atacante) ? movimientoAtq : movimientoDef; // Operador ternario
                //Pokemon objetivo = (elQueAtacaPrimero == atacante) ? defensor : atacante;                     // (condición) ? valorSiEsVerdadera : valorSiEsFalsa;


                EjecutarAtaque(elQueAtacaPrimero, movimientoUsado, elQueAtacaDespues);

                // Si el objetivo sobrevivió, responde
                if (!EstaDebilitado(elQueAtacaDespues))
                {
                    EjecutarAtaque(elQueAtacaDespues, movimientoRespuesta, elQueAtacaPrimero);

                    if (EstaDebilitado(elQueAtacaPrimero))
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine("AMBOS POKEMON SIGUEN DE PIE");
                Console.WriteLine();

            }
            return atacante.PS <= 0 ? defensor : atacante;

        }






        // FUNCIONES AUXILIARES PARA EL ATAQUE

        // Me di cuenta que la invocación de Acierta ataque se multiplicaba, asi q era necesario encapsular.
        public static void EjecutarAtaque(Pokemon atacante, Movimiento movimiento, Pokemon objetivo)
        {
            string separador = new string('#', 50);  // Para crear un borde superior e inferior de 50 caracteres

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(separador);  // Borde superior

            if (AciertaAtaque(movimiento))
            {
                float danio = CalcularDanio(movimiento, atacante, objetivo);
                float efectividad = TablaDeTipos.ObtenerEfectividad(movimiento.Tipo, objetivo.Tipo);


                Console.WriteLine($"{atacante.Nombre} atacó con {movimiento.Nombre} e hizo {danio:F0} de daño a {objetivo.Nombre}.");
                Console.WriteLine();
                Console.WriteLine($"Tipo movimiento: {movimiento.Tipo}, Tipo objetivo: {objetivo.Tipo}");


                objetivo.PS -= (int)Math.Round(danio);
                MostrarPS(objetivo);
                Console.WriteLine(MostrarEfectividad(efectividad));
                if (objetivo.PS <= 0) objetivo.PS = 0;
                Console.WriteLine();
                Console.WriteLine($"A {objetivo.Nombre} le quedan {objetivo.PS} PS.");
                Console.WriteLine();

                if (EstaDebilitado(objetivo))
                {
                    Console.WriteLine($"{objetivo.Nombre} se debilitó.");
                }
                else
                {
                    Console.WriteLine($"{objetivo.Nombre} resistió el turno.");
                }
            }

            else
            {
                Console.WriteLine($"{atacante.Nombre} falló su ataque.");

            }
            Console.WriteLine(separador);
        }

        // FUNCIÓN QUE DEFINE CUÁL POKEMON GOLPEA PRIMERO (según velocidad) Y ESTABLECE LA JERARQUÍA DE TURNOS.
        public static Pokemon DecidirPrimerGolpe(Pokemon atacante, Pokemon defensor)
        {
            if (atacante.Velocidad > defensor.Velocidad)
            {
                return atacante;
            }
            else if (atacante.Velocidad < defensor.Velocidad)
            {
                return defensor;
            }
            else
            {
                // Velocidades iguales: Decidimos por rng.
                if (rng.Next(0, 2) == 0)
                {
                    return atacante;
                }
                else
                {
                    return defensor;
                }
            }
        }

        // FUNCIÓN QUE INDICA SI UN ATAQUE ACIERTA O FALLA.
        public static bool AciertaAtaque(Movimiento movimiento) // Es bool porque me indica true si acierta o false si falla
        {
            int numeroAleatorio = rng.Next(0, 100); // Genera un número entre 0 y 99

            // Si el número aleatorio es menor que la puntería, el ataque acierta
            return numeroAleatorio < movimiento.Punteria;
        }

        // FUNCION PARA CALCULAR EL DAÑO (la formula de cálculo de daño de la GEN 1).
        public static float CalcularDanio(Movimiento movimientoAtq, Pokemon atacante, Pokemon defensor)
        // Que recibe un movimiento, un pkmn atacante y un pkmn defensor.
        {
            float ataque, defensa;

            // Determinamos si el movimiento es de categoría físico o especial
            if (movimientoAtq.Categoria == "Fisico")
            {
                ataque = atacante.Atq;  // El pokemon atacante utiliza su stat de ataque.
                defensa = defensor.Def; // Acá tomamos la defensa del pokemon defensor.
            }
            else
            {
                ataque = atacante.AtqEsp;
                defensa = defensor.DefEsp;
            }

            // Cálculo del daño base
            float danioBase = ((42f * movimientoAtq.Poder * (ataque / (float)defensa)) / 50f) + 2f;



            // Calculamos el STAB.          
            float stab;
            if (atacante.Tipo == movimientoAtq.Tipo) // Si el tipo del Pokémon coincide con el tipo del movimiento
            {
                stab = 1.5f; // Se aplica STAB
            }

            else
            {
                stab = 1f; // No se aplica STAB
            }




            // Efectividad de tipo (utiliza la tabla de tipos para definir la eficacia).
            float efectividad = TablaDeTipos.ObtenerEfectividad(movimientoAtq.Tipo, defensor.Tipo);

            // Variación aleatoria (Este es el valor "random" que permite aportar aleatoriedad a los combates).
            int variacionDefault = rng.Next(217, 256); // Entre 217 y 255 inclusive, por los bytes que tenian como limitación.
            float variacion = variacionDefault / 255f; // ~0.85 a 1.0 , esta es la variación original de la primer Gen

            //Mínimo: 85% del daño base (multiplicado por 0.85)
            //Máximo: 100 % del daño base(multiplicado por 1.00)
            //Rango de variación: del 85 % al 100 %.


            // Calcular el daño final
            float danioFinal = danioBase * stab * efectividad * variacion;

            return danioFinal;
        }

        // FUNCION PARA MOSTRAR LA EFECTIVIDAD DE UN ATAQUE.
        public static string MostrarEfectividad(float efectividad)
        {
            if (efectividad == 2f)
            {
                return "¡Es super eficaz!";
            }
            else if (efectividad == 0.5f)
            {
                return "Es poco eficaz...";
            }
            else if (efectividad == 0f)
            {
                return "No afecta al enemigo.";
            }
            else
            {
                return "Es eficaz.";
            }
        }



        // FUNCIONONES RELACIONADAS A LOS PS
        public static void MostrarPS(Pokemon pokemon)
        {
            int total = 20;
            int psActual = pokemon.PS < 0 ? 0 : (pokemon.PS > pokemon.PSMax ? pokemon.PSMax : pokemon.PS);
            int relleno = (int)((psActual / (float)pokemon.PSMax) * total);
            string barra = new string('█', relleno).PadRight(total, ' ');
            Console.WriteLine($"Vida de {pokemon.Nombre}: [{barra}] {psActual}/{pokemon.PSMax} PS");
        }

        public static bool EstaDebilitado(Pokemon pokemon) // Aporta Claridad al código y lo mantiene hablando siempre en términos del combate.
        {
            return pokemon.PS <= 0;
        }

        public static bool TieneEquipoDebilitado(List<Pokemon> pokemones) // Función que me indica verdadero si no le quedan pokemones vivos al equipo.
        {
            if (EstaDebilitado(pokemones[0]) && EstaDebilitado(pokemones[1]) && EstaDebilitado(pokemones[2]))
            { return true; }
            return false;
        }




        // FUNCIONES PARA ELEGIR POKEMON/MOVIMIENTO DURANTE EL TURNO.

        public static Pokemon ElegirPokemon(Entrenador entrenador)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{entrenador.Nombre}, elegí un Pokémon para pelear:");
            Console.WriteLine();

            for (int i = 0; i < 3; i++) // Recorremos todos los pokemones del entrenador
            {
                Pokemon pokemon = entrenador.Pokemones[i];
                Colorizar.EscribirConColor($"{i + 1}. {pokemon.Nombre.ToUpper()}", pokemon.Tipo); // Enumeramos cada pokemon encontrado en el equipo dle entrenador
            }

            string? opcion = Console.ReadLine(); // lleva ? porque le estoy permitiendo que devuelva null

            while (opcion != "1" && opcion != "2" && opcion != "3" || entrenador.Pokemones[int.Parse(opcion) - 1].PS <= 0) // Si recibe algun input distinto de los números usados para enumerar, da error.
            {
                Console.WriteLine("Opción inválida o el Pokemon está Debilitado. Elegí otra opción (1, 2 o 3).");
                opcion = Console.ReadLine();
                Console.WriteLine();
            }


            return entrenador.Pokemones[int.Parse(opcion) - 1]; // Retorna el índice del pokemon en el equipo del entrenador. 
            // Todos los int.parse de la función son para convertir los string solicitados en los inputs, en int para operar en los indices de las listas.
        }

        public static Movimiento ElegirMovimiento(Pokemon pokemon)
        {
            Console.WriteLine();
            Console.WriteLine();
            Colorizar.EscribirConColor($"ELEGÍ UN MOVIMIENTO PARA {pokemon.Nombre.ToUpper()}:", pokemon.Tipo); // REVISAR ME COLOREA TODA LA LINEA
            Console.WriteLine();

            for (int i = 0; i < 4; i++)

            {
                Movimiento movimiento = pokemon.Movimientos[i];
                Colorizar.EscribirConColor($"{i + 1}. {movimiento.Nombre} ({movimiento.Tipo})", movimiento.Tipo);

            }

            string? opcion = Console.ReadLine();

            while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4")
            {
                Console.WriteLine("Opción inválida. Elegí 1, 2, 3 o 4.");
                opcion = Console.ReadLine();
                Console.WriteLine();
            }

            return pokemon.Movimientos[int.Parse(opcion) - 1];
        }
    }
}







