using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ejercicio1
{
    public partial class Principal : Form
    {
       
        public Principal()
        {
            InitializeComponent();
            //lenguajes de programacion
            lenguajesDeProgramacion = new List<LenguajeDeProgramacion>
                {
                    new LenguajeDeProgramacion
                    {
                        Nombre = "JAVA",
                        Desarrollador = "James Gosling y SunMicrosystems",
                        Extensiones = "java, class, jar, jad y jmod",
                        AparecioEn = 1996,
                        SistemaOperativo = "Multiplataforma",
                        Paradigma = "Orientado a objetos, imperativo",
                        UltimaVersionEstable = "14.01",
                        Licencia = "GNU GPL / Java CommunityProcess"
                    },
                    new LenguajeDeProgramacion
                    {
                        Nombre = "Javascript",
                        Desarrollador = "-",
                        Extensiones = ".js",
                        AparecioEn = 1995,
                        SistemaOperativo = "-",
                        Paradigma = ": Multiparadigma, programación funcional,1 programación basada en prototipos, imperativo, interpretado (scripting)",
                        UltimaVersionEstable = "ECMAScript2016",
                        Licencia = "-"
                    },
                    new LenguajeDeProgramacion
                    {
                        Nombre = "Python",
                        Desarrollador = "Python Software Foundation",
                        Extensiones = ".py.pyc, .pyd, .pyo, .pyw, .pyz",
                        AparecioEn = 1991,
                        SistemaOperativo = "Multiplataforma",
                        Paradigma = "Multiparadigma: imperativo, orientado a objetos, funcional",
                        UltimaVersionEstable = "3.10",
                        Licencia = "Python Software Foundation License"
                    }
                };
            //libros
            libros = new List<Libro>
                {
                    new Libro
                    {
                        Titulo = "Harry Potter",
                        Autor = "J.K Rowling",
                        Genero = "Novela",
                        SubGenero = "Literatura fantástica, literaturajuvenil, novela de desarrollo y literatura infantil y juvenil",
                        NumeroDePaginas = 3400,
                        Protagonistas = "Harry Potter,Ron weasley,Hermione Granger,Ginny Weasley,Neville Longbottom,Albus Dumbledore",
                        Antagonistas = "Lord Voldemort,Mortifagos",
                        Argumento = "La historia comienza con la celebración del mundo mágico. Durante muchos años, había sido aterrorizado por el malvado mago Lord"+
                        "Voldemort. La noche del 31 de octubre, mató a Lily y James Potter. Sin embargo, cuando intenta matar a su hijo de 1 año, Harry, la maldición asesina Avada Kedavra se"+
                        "vuelve sobre sí mismo. El cuerpo de Voldemort resulta destruido, pero él sobrevive: no está muerto ni vivo. Por su parte, a Harry solo le queda una cicatriz con forma de"+
                        "rayo en la frente que es el único remanente físico de la maldición de Voldemort.Harry es el único sobreviviente de la maldición asesina, y a raíz de la"+ 
                        "misteriosa derrota de Voldemort, el mundo mágico empieza a llamarlo como «el niño que sobrevivió»"
                    },
                    new Libro
                    {
                        Titulo = "GOOSEBUMPS",
                        Autor = "Robert Lawrence Stine",
                        Genero = "Ciencia ficción, literatura infantil y suspenso",
                        SubGenero = "Suspenso, terror, juvenil",
                        NumeroDePaginas = 578,
                        Protagonistas = "El protagonista principal de una historia de Pesadillas / Escalofríos, es a menudo situado en una ubicación"+
                        "remota o de alguna manera aislada en algunas situaciones.",
                        Antagonistas = "",
                        Argumento = "La serie consta de un total de 60 libros para España, el último de los cuales (Sangre de monstruo IV) se publicó en 1999, mientras que en Hispanoamérica consta de 45"+
                        "historias. El nombre se tradujo en España como Pesadillas y en Hispanoamérica como Escalofríos."
                    },
                    new Libro
                    {
                        Titulo = "Perry Mason",
                        Autor = "Erle Stanley Gardner",
                        Genero = "Novela Policiaca",
                        SubGenero = "-",
                        NumeroDePaginas = 765,
                        Protagonistas = "Perry Mason",
                        Antagonistas = "-",
                        Argumento = "El personaje era un abogado que llegó a aparecer en 80 novelas ehistorias cortas, la mayoría de las cuales versaban sobre la"+
                        "defensa de un cliente que había sido acusadode asesinato. En general, Perry Mason era capaz de demostrar la inocencia de su cliente mediante la averiguación de la"+ 
                        "culpabilidad del verdadero asesino, otro personaje de la historia."
                    }
                };
            //TV
            tvShows = new List<TVShow>
                {
                    new TVShow
                    {
                        Nombre = "Chernóbil",
                        Creadopor = "Craig Mazin",
                        Protagonistas = "Jared Harris,Stellan Skarsgård,Emily Watson",
                        PaisOrigen = "USA,Reino Unido",
                        Temporadas = 1,
                        Episodios = 5,
                        Descripcion = "La serie gira en torno al desastre nuclear de Chernóbil de abril de 1986 y los esfuerzos de limpieza sin" +
                                        "precedentes que sig uieron. Cuenta con un reparto encabezado por Jared Harris, Stellan Skarsgård y Emily Watson",
                        Imagen = "imagenes/chernobil.jpg"
                    },
                    new TVShow
                    {
                        Nombre = "Juego de tronos",
                        Creadopor = "David Benioff, D. B. Weiss",
                        Protagonistas = "Emilia Clarke, Kit Harington",
                        PaisOrigen = "USA",
                        Temporadas = 8,
                        Episodios = 73,
                        Descripcion = "La trama de Game of Thrones está basada en la serie de novelas Canción de hielo y fuego, y relata las" +                  
                                      "vivencias de un grupo de personajes de distintas casas nobiliarias en el continente ficticio Poniente para tener el"+
                                        "control del Trono de Hierro y gobernar los siete reinos que conforman el territorio",
                        Imagen = "imagenes/juegodetronos.jpg"
                    },
                    new TVShow
                    {
                        Nombre = "La maravillosa Señora Maisel ",
                        Creadopor = "Amy Sherman-Palladino",
                        Protagonistas = "s Rachel Brosnahan,Michael Zegen,Alex Borstein,Tony Shalhoub,Marin Hinkle",
                        PaisOrigen = "USA",
                        Temporadas= 3,
                        Episodios = 26,
                        Descripcion = "La serie cuenta la historia de un ama de casa en Nueva York que descubre que tiene una habilidad especial para la comedia en vivo. El primer"+
                        "episodio se estrenó como parte de la temporada de pilotos de primavera de Amazon Studios el 17 de marzo de 2017, recibiendo la aclamación de la crítica.",
                        Imagen = "images/foto3.jpg"
                    }
                };

            // Cargar nombres en el ListBox
            foreach (var show in tvShows)
            {
                lstTvShows.Items.Add(show.Nombre);
            }

            // Asociar el evento SelectedIndexChanged
            lstTvShows.SelectedIndexChanged += lstTvShows_SelectedIndexChanged;
            // Cargar títulos en el ComboBoxlibros
            foreach (var libro in libros)
            {
                cmbLibros.Items.Add(libro.Titulo);
            }

            // Asociar el evento SelectedIndexChanged
            cmbLibros.SelectedIndexChanged += cmbLibros_SelectedIndexChanged;
            // Cargar nombres de los lenguajes en el ComboBox
            foreach (var lenguaje in lenguajesDeProgramacion)
            {
                cmbLenguajes.Items.Add(lenguaje.Nombre);
            }

            // Asociar el evento SelectedIndexChanged
            cmbLenguajes.SelectedIndexChanged += cmbLenguajes_SelectedIndexChanged;

        }
        public class TVShow
        {
            public string Nombre { get; set; }
            public string Creadopor { get; set; }         // Creador(es) del programa
            public string Protagonistas{ get; set; }      // Protagonistas principales
            public string PaisOrigen{ get; set; }
            public int Temporadas { get; set; } // País de origen del programa
            public int Episodios { get; set; }
            public string Descripcion { get; set; }
            public string Imagen { get; set; }
        }
        public class Libro
        {
            public string Titulo { get; set; }            // Título del libro
            public string Autor { get; set; }             // Autor del libro
            public string Genero { get; set; }            // Género del libro
            public string SubGenero { get; set; }         // Subgénero del libro
            public int NumeroDePaginas { get; set; }      // Número de páginas
            public string Protagonistas { get; set; }     // Protagonistas
            public string Antagonistas { get; set; }      // Antagonistas
            public string Argumento { get; set; }         // Argumento del libro
        }
        public class LenguajeDeProgramacion
        {
            public string Nombre { get; set; }               // Nombre del lenguaje de programación
            public string Desarrollador { get; set; }        // Desarrollador del lenguaje
            public string Extensiones { get; set; }          // Extensiones de archivo asociadas
            public int AparecioEn { get; set; }              // Año en que apareció
            public string SistemaOperativo { get; set; }     // Sistemas operativos soportados
            public string Paradigma { get; set; }            // Paradigma de programación
            public string UltimaVersionEstable { get; set; } // Última versión estable
            public string Licencia { get; set; }             // Licencia del lenguaje
        }
        private List<TVShow> tvShows;
        private List<Libro> libros;
        private List<LenguajeDeProgramacion> lenguajesDeProgramacion;

        private void lstTvShows_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstTvShows.SelectedIndex;
            if (selectedIndex != -1)
            {
                TVShow selectedShow = tvShows[selectedIndex];

                // Mostrar la información del programa de televisión
                lblTv.Text = $"Creado por: {selectedShow.Creadopor}\n" +
                                          $"Protagonistas: {selectedShow.Protagonistas}\n" +
                                          $"Pais de origen: {selectedShow.PaisOrigen}\n" +
                                          $"Temporadas: {selectedShow.Temporadas}\n" +
                                          $"Episodios: {selectedShow.Episodios}\n" +
                                          $"Sinopsis: {selectedShow.Descripcion}";

                // Mostrar la imagen del programa de televisión
                if (File.Exists(selectedShow.Imagen))
                {
                    picTv.Image = Image.FromFile(selectedShow.Imagen);
                }
                else
                {
                    picTv.Image = null; // O una imagen por defecto si la imagen no se encuentra
                }
            }
        }

        private void LoadChartData()
        {
            
        }

        private void cmbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbLibros.SelectedIndex;
            if (selectedIndex != -1)
            {
                Libro libroSeleccionado = libros[selectedIndex];

                // Mostrar la información del libro
                lblLibros.Text = $"Autor: {libroSeleccionado.Autor}\n" +
                                          $"Género: {libroSeleccionado.Genero}\n" +
                                          $"Subgénero: {libroSeleccionado.SubGenero}\n" +
                                          $"Número de páginas: {libroSeleccionado.NumeroDePaginas}\n" +
                                          $"Protagonistas: {libroSeleccionado.Protagonistas}\n" +
                                          $"Antagonistas: {libroSeleccionado.Antagonistas}\n" +
                                          $"Argumento: {libroSeleccionado.Argumento}";
            }
        }

        private void cmbLenguajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbLenguajes.SelectedIndex;
            if (selectedIndex != -1)
            {
                LenguajeDeProgramacion lenguajeSeleccionado = lenguajesDeProgramacion[selectedIndex];

                // Mostrar la información del lenguaje de programación
                lblLenguajes.Text = $"Desarrollador: {lenguajeSeleccionado.Desarrollador}\n" +
                                             $"Extensiones: {lenguajeSeleccionado.Extensiones}\n" +
                                             $"Apareció en: {lenguajeSeleccionado.AparecioEn}\n" +
                                             $"Sistema Operativo: {lenguajeSeleccionado.SistemaOperativo}\n" +
                                             $"Paradigma: {lenguajeSeleccionado.Paradigma}\n" +
                                             $"Última versión estable: {lenguajeSeleccionado.UltimaVersionEstable}\n" +
                                             $"Licencia: {lenguajeSeleccionado.Licencia}";
            }
        }
        // Método para cargar las estadísticas
        private void CargarEstadisticas()
        {
            // Estadísticas para los Libros
            int totalLibros = libros.Count;
            int totalPaginas = libros.Sum(libro => libro.NumeroDePaginas);
            double promedioPaginas = totalLibros > 0 ? (double)totalPaginas / totalLibros : 0;

            // Estadísticas para los Programas de TV
            int totalProgramasTV = tvShows.Count;
            int totalEpisodios = tvShows.Sum(programa => programa.Episodios);

            // Estadísticas para los Lenguajes de Programación
            int totalLenguajes = lenguajesDeProgramacion.Count;

            // Mostrar las estadísticas en los Labels
            lblTotalLibros.Text = $"Total de Libros: {totalLibros}";
            lblPromedioPaginas.Text = $"Promedio de Páginas por Libro: {promedioPaginas:F2}";

            lblTotalProgramasTV.Text = $"Total de Programas de TV: {totalProgramasTV}";
            lblTotalEpisodios.Text = $"Total de Episodios: {totalEpisodios}";

            lblTotalLenguajes.Text = $"Total de Lenguajes de Programación: {totalLenguajes}";
        }

        // Método MainForm_Load modificado
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Cargar los datos en las otras pestañas
            CargarDatosLibros();
            CargarDatosProgramasTV();
            CargarDatosLenguajesDeProgramacion();

            // Cargar las estadísticas en la cuarta pestaña
            CargarEstadisticas();
        }




    }
}