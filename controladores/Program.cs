using ejerciciosCollection.servicios;

namespace ejerciciosCollection.controladores
{
    /// <summary>
    /// Clase principal del programa
    /// msm -22042024
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo que contiene el procedimiento principal
        /// msm - 22042024
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            int opcionSelecionada;
            bool cerrarMenu = false;
           
            Queue<string> clientes = new Queue<string>();


            while (!cerrarMenu)
            {
                opcionSelecionada = mi.respuestaUsuario();

                switch (opcionSelecionada)
                {
                    case 0:
                        
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine(" ");
                        Console.WriteLine("Inserte clientes");
                        string respuestaInsertar = Console.ReadLine();
                        clientes.Enqueue(respuestaInsertar);
                        break;
                    case 2:
                        Console.WriteLine(" ");
                        clientes.Dequeue();
                        break;
                    case 3:
                        foreach (string cliente in clientes)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine(cliente);
                            Console.WriteLine(" ");
                        }
                        break;


                }

            }

        }

    }

        //UTILIZARIA HASH SET POR QUE NOS INDICA SI EXISTE UN ELEMENTO ESPEFICO EN LA LISTA
    }
