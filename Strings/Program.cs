namespace Strings
{
    class program
    {
        public static void Main(string[] args)
        {
            //Texto seco
            String texto = "Larem ipsum, dalor, sit";
            string espacio = " ";
            Console.WriteLine(texto);
       
            //Añadir espacios
            Console.WriteLine(String.Concat(espacio, texto, espacio));



            //Eliminar espacios
            String textoSinEspaciosTemp = texto.TrimStart();
            String textoSinEspacios = textoSinEspaciosTemp.TrimEnd();
            Console.WriteLine( textoSinEspacios );

            //Separacion mediante comas
            string[] textoSeparado = texto.Split(',');

            for (int i = 0; i < textoSeparado.Length; i++)
            {
                Console.WriteLine(textoSeparado[i]);
            }

            //Contar las a
            char letra = 'a';

            int contador = texto.Count(f => (f == letra));
            Console.WriteLine(contador);

            //Todo a mayuscula
            Console.WriteLine(texto.ToUpper());
        }
    }
}
