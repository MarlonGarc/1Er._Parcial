using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("LAS PALABRAS CONFIGURADAS DE FABRICA SON: '    Hola, mundo!    '");

            Console.WriteLine("\nSeleccione la Opcion de STRING que Desea Realizar:\n");
            Console.WriteLine("1. Compare");
            Console.WriteLine("2. Concat");
            Console.WriteLine("3. Contains");
            Console.WriteLine("4. EdsWith");
            Console.WriteLine("5. Equals");
            Console.WriteLine("6. Format");
            Console.WriteLine("7. IndexOf");
            Console.WriteLine("8. Insert");
            Console.WriteLine("9. IsNullOrEmpty");
            Console.WriteLine("10. Join");
            Console.WriteLine("11. LastIndexOf");
            Console.WriteLine("12. Length");
            Console.WriteLine("13. PadLegth");
            Console.WriteLine("14. PadRight");
            Console.WriteLine("15. Remove");
            Console.WriteLine("16. Replace");
            Console.WriteLine("17. Split");
            Console.WriteLine("18. StartsWith");
            Console.WriteLine("19. Substring");
            Console.WriteLine("20. ToLower");
            Console.WriteLine("21. ToUpper");
            Console.WriteLine("22. Trim");
            Console.WriteLine("23. OPERACIONES CON CADENAS");
            Console.WriteLine("24. Salir\n");

            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            string texto = "    Hola, mundo!   ";
            string texprueva = "ESTO ES UNA PRUEVA";
            string resultado = "";

            switch (opcion)
            {
                case 1:
                    resultado = string.Compare(texto, "Hola, munda!").ToString();
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 2:
                    resultado = string.Concat(texto, texprueva, "Concatenado");
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 3:
                    resultado = texto.Contains("Hola").ToString();
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 4:
                    resultado = texto.EndsWith(".jpg").ToString();
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine(); 
                    break;
                case 5:
                    resultado = texto.Equals("Hola, Mundo!").ToString();
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 6:
                    resultado = string.Format("{0} - {1}", texto, texprueva);
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 7:
                    resultado = texto.IndexOf("m").ToString();
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 8:
                    resultado = texto.Insert(5, " agregado");
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 9:
                    resultado = string.IsNullOrEmpty(texto).ToString();
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 10:
                    resultado = string.Join(",", "a", "b", "c", texprueva);
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 11:
                    resultado = texto.LastIndexOf("a").ToString();
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 12:
                    resultado = texto.Length.ToString();
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 13:
                    resultado = texto.PadLeft(15, '*');
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 14:
                    resultado = texto.PadRight(15, '*');
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 15:
                    resultado = texto.Remove(5);
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 16:
                    resultado = texto.Replace("o", "x");
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 17:
                    string[] resultArray = texto.Split(',');
                    Console.WriteLine(resultArray[0]);
                    Console.ReadLine();
                    break;
                case 18:
                    resultado = texto.StartsWith("H").ToString();
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 19:
                    resultado = texto.Substring(5);
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 20:
                    resultado = texto.ToLower();
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 21:
                    resultado = texto.ToUpper();
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 22:
                    resultado = texto.Trim();
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ReadLine();
                    break;
                case 23:
                    while (true)
                    {
                        Console.WriteLine("\nPor favor Seleccione que Operacion va a Realizar con las cadenas de texto:");
                        Console.WriteLine("1. Comparacion de Cadenas\n2. Concatenancion de Cadenas\n3. Busqueda de Patrones\n4. Formateo de Cadenas");
                        int num = int.Parse(Console.ReadLine());
                        Console.WriteLine("Por Favor Ingrese una Cadena de Texto");
                        string tex1 = Console.ReadLine();
                        Console.WriteLine("\nPor Favor Ingrese otra Cadena de Texto");
                        string tex2 = Console.ReadLine();

                        if (num == 1)
                        {
                            if (tex2.Equals(tex1, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("¡La palabra ingresada es igual a la cadena de referencia!");
                            }
                            else
                            {
                                Console.WriteLine("La palabra ingresada es diferente a la cadena de referencia.");
                            }
                        }
                        else if (num == 2)
                        {
                            string mensaje = string.Concat(tex1, ", ", tex2, "!");
                            Console.WriteLine(mensaje);
                        }
                        else if (num == 3)
                        {
                            Console.WriteLine("Escriba el patron que se buscara en el texto.");
                            string frace = Console.ReadLine();

                            if (tex1.Contains(frace) || tex2.Contains(frace))
                            {
                                Console.WriteLine("La frase contiene la palabra " + frace);
                            }
                            else
                            {
                                Console.WriteLine("La frase {frace} no se encuentra en las cadenas de Texto");
                            }
                        }
                        else if (num == 4)
                        {
                            string mensaje = string.Format("{0} '&' {1}.", tex1, tex2);
                            Console.WriteLine(mensaje);
                        }
                        else
                        {
                            Console.WriteLine("Introduce una opcion valida");
                        }
                        Console.ReadLine();
                    }
                    break;
                case 24:
                    return;
                default: //Opcion no Valida
                    //resultado = "Opción no válida";
                    Console.WriteLine("Resultado: " + resultado);
                    break;
            }
            
        }
    }
}