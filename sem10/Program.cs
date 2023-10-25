using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje01_sem10
{
    internal class Class1
    {
        private static string opcion2Texto;
        private static int opcion3;

        static void Main(string[] args)
        {
            int opcion = MenúPrincipal();
            do
            {
                switch (opcion)
                {
                    case 0:
                        opcion = MenúPrincipal();
                        break;
                    case 1:
                        opcion = mPhone3000();
                        break;
                    case 2:
                        opcion = mPad3500();
                        break;
                    case 3:
                        opcion = MAPBrook3800();
                        break;
                    case 4:
                        opcion = MWatch8000();
                        break;

                }
            } while (opcion != 5);

            int opcion2 = GetOpcion2()
;
            do
            {
                switch (opcion2)
                {
                    case 0:
                        opcion2= Total();
                        break;

                    case 1:
                        opcion2 = ventaunmPhone3000();

                        break;
                    case 2:
                        opcion2 = ventamPad3500();
                        break;
                    case 3:
                        opcion2= ventaMAPBrook3800();
                        break;
                    case 4:
                        opcion2= ventamWatch8000();
                        break;
                }


            } while (opcion2 != 0);


        }

        private static int ventamPhone3000()
        {
            throw new NotImplementedException();
        }

        private static int MenúPrincipal()
        {
            Console.Clear();
            Console.Write("================================\n" +
                "Productos de mPhone\n" +
                "================================\n" +
                "1: Ventas de mPhone 3000\n" +
                "2: Ventas de mPad 3500\n" +
                "3: Ventas de MAPBrook 3800\n" +
                "4: Ventas de mWatch 8000\n" +
                "5: Salir\n" +
                "================================\n" +
                "Ingrese una opción: \n");
            return GetOpcion();
        }
        //VENTAS
        private static int mPhone3000()
        {
            Console.Clear();
            Console.Write("" +
                       "================================\n" +
                       "Registrar Venta de mPhone 3000\n" +
                       "================================\n" +
                       "1: Registrar Venta\n" +
                       "2: Registrar Devolución\n" +
                       "3: Menu Principal\n" +
                       "================================\n" +
                       "Ingrese una opción: \n");
            int opcion2 = GetOpcion2();
            if (opcion2 == 3) return 0;
            return opcion2;
        }
        private static int mPad3500()
        {
            Console.Clear();
            Console.Write("" +
                       "================================\n" +
                       "Registrar Venta de mPad 3500\n" +
                       "================================\n" +
                       "1: Registrar Venta\n" +
                       "2: Registrar Devolución\n" +
                       "3: Menu Principal\n" +
                       "================================\n" +
                       "Ingrese una opción: \n");
            int opcion2 = GetOpcion2();
            if (opcion2 == 3) return 0;
            return opcion2;
        }
        private static int MAPBrook3800()
        {
            Console.Clear();
            Console.Write("" +
                       "================================\n" +
                       "Registrar Venta de MAPBrook 3800\n" +
                       "================================\n" +
                       "1: Registrar Venta\n" +
                       "2: Registrar Devolución\n" +
                       "3: Menu Principal\n" +
                       "================================\n" +
                       "Ingrese una opción: \n");
            int opcion2 = GetOpcion2();
            if (opcion2 == 3) return 0;
            return opcion2;
        }
        private static int MWatch8000()
        {
            Console.Clear();
            Console.Write("" +
                       "================================\n" +
                       "Registrar Venta de mWatch 8000\n" +
                       "================================\n" +
                       "1: Registrar Venta\n" +
                       "2: Registrar Devolución\n" +
                       "3: Menu Principal\n" +
                       "================================\n" +
                       "Ingrese una opción: \n");
            int opcion2 = GetOpcion2();
            if (opcion2 == 3) return 0;
            return opcion2;
        }
        //REGSITRAR VENTAS: 
        private static int ventaunmPhone3000()
        {
            Console.Clear();
            Console.Write("" +
                       "================================\n" +
                       "Registrar venta de:\n" +
                       "================================\n" +
                       "Se va a registrar la venta de unmPhone 3000\n" +
                       "¿Desea Continuar?\n" +
                       "1: Sí\n" +
                       "2: No\n" +
                       "================================\n" +
                       "Ingrese una opción:\n");
            int opcion3 = GetOpcion3();
            if (opcion3 == 0) return 0;
            return opcion3;
        }
        private static int ventamPad3500()
        {
            Console.Clear();
            Console.Write("" +
                       "================================\n" +
                       "Registrar venta de:\n" +
                       "================================\n" +
                       "Se va a registrar la venta de mPad 3500\n" +
                       "¿Desea Continuar?\n" +
                       "1: Sí\n" +
                       "2: No\n" +
                       "================================\n" +
                       "Ingrese una opción:\n");
            int opcion3 = GetOpcion3();
            if (opcion3 == 0) return 0;
            return opcion3;
        }
        private static int ventaMAPBrook3800()
        {
            Console.Clear();
            Console.Write("" +
                       "================================\n" +
                       "Registrar venta de:\n" +
                       "================================\n" +
                       "Se va a registrar la venta de MAPBrook 3800\n" +
                       "¿Desea Continuar?\n" +
                       "1: Sí\n" +
                       "2: No\n" +
                       "================================\n" +
                       "Ingrese una opción:\n");
            int opcion3 = GetOpcion3();
            if (opcion3 == 0) return 0;
            return opcion3;
        }
        private static int ventamWatch8000()
        {
            Console.Clear();
            Console.Write("" +
                       "================================\n" +
                       "Registrar venta de:\n" +
                       "================================\n" +
                       "Se va a registrar la venta de mWatch 8000\n" +
                       "¿Desea Continuar?\n" +
                       "1: Sí\n" +
                       "2: No\n" +
                       "================================\n" +
                       "Ingrese una opción:\n");
            int opcion3 = GetOpcion3();
            if (opcion3 == 0) return 0;
            return opcion3;
        }
        //REGSITRAR DEVOLUCIÓN: 
        private static int devolcionunmPhone3000()
        {
            Console.Clear();
            Console.Write("" +
                       "================================\n" +
                       "Registrar devolución  de:\n" +
                       "================================\n" +
                       "Se va a registrar la devolución  de unmPhone 3000\n" +
                       "¿Desea Continuar?\n" +
                       "1: Sí\n" +
                       "2: No\n" +
                       "================================\n" +
                       "Ingrese una opción:\n");
            int opcion = GetOpcion();
            if (opcion == 2) return 0;
            return opcion;
        }
        private static int devolcionmPad3500()
        {
            Console.Clear();
            Console.Write("" +
                       "================================\n" +
                       "Registrar devolución  de:\n" +
                       "================================\n" +
                       "Se va a registrar la devolución  de mPad 3500\n" +
                       "¿Desea Continuar?\n" +
                       "1: Sí\n" +
                       "2: No\n" +
                       "================================\n" +
                       "Ingrese una opción:\n");
            int opcion2 = GetOpcion2();
            if (opcion2 == 2) return 0;
            return opcion2;
        }
        private static int devolucionMAPBrook3800()
        {
            Console.Clear();
            Console.Write("" +
                       "================================\n" +
                       "Registrar devolución  de:\n" +
                       "================================\n" +
                       "Se va a registrar la devolución  de MAPBrook 3800\n" +
                       "¿Desea Continuar?\n" +
                       "1: Sí\n" +
                       "2: No\n" +
                       "================================\n" +
                       "Ingrese una opción:\n");
            int opcion2 = GetOpcion();
            if (opcion2 == 2) return 0;
            return opcion2;
        }
        private static int devolucionmWatch8000()
        {
            Console.Clear();
            Console.Write("" +
                       "================================\n" +
                       "Registrar devolución  de:\n" +
                       "================================\n" +
                       "Se va a registrar la devolución  de mWatch 8000\n" +
                       "¿Desea Continuar?\n" +
                       "1: Sí\n" +
                       "2: No\n" +
                       "================================\n" +
                       "Ingrese una opción:\n");
            int opcion2 = GetOpcion();
            if (opcion2 == 2) return 0;
            return opcion2;
        }
        private static int Total()
        {
            Console.Clear();
            Console.WriteLine("" +
                "================================\n" +
                "Productos de mPhone\n" +
                "================================\n" +
                "1: Ventas de mPhone 3000\n" +
                "2: Ventas de mPad 3500\n" +
                "3: Ventas de MAPBrook 3800\n" +
                "4: Ventas de mWatch 8000\n" +
                "5: Salir\n" +
                "================================\n" +
                "Ingrese una opción: \n" +
                "================================\n" +
                "Reporte Final\n" +
                "================================\n" +
                "Productos Vendidos | Cantidad\n" +
                "--------------------------------\n" +
                "mPhones |\n" +
                "mPads |\n " +
                "MAPBrooks |\n " +
                "mWatches |\n" +
                "--------------------------------\n" +
                "Total | \n" +
                "================================\n" +
                "¡Hasta Luego!\n");
            return opcion3;

        }
        private static int GetOpcion()
        {
            string opcionTexto = Console.ReadLine();
            return int.Parse(opcionTexto);

        }
        private static int GetOpcion2()
        {
            string opcion2Texto = Console.ReadLine();
            return int.Parse(opcion2Texto);
        }
        private static int GetOpcion3()
        {
            string opcion3Texto = Console.ReadLine();
            return int.Parse(opcion3Texto);

        }
    }

}
