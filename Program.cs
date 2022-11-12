/* Enunciado: Escribe una función que reciba dos palabras (String) y retorne verdadero o falso (Bool) según sean o no anagramas.
 * Un Anagrama consiste en formar una palabra reordenando TODAS las letras de otra palabra inicial.
 * NO hace falta comprobar que ambas palabras existan.
 * Dos palabras exactamente iguales no son anagrama.
 */

using System.Text.RegularExpressions;

Console.WriteLine("Escribe 2 Palabras");



  //  bool Resp =Enumerable.(chars, chars1);
  //  Text=Regex.Replace(Text, @"\s+", " ").Trim();
  //  bool Igualdad = Regex.Equals(chars,chars1);


  
      
      static int buscarIndice(char[] arreglo, char[] arreglo1)
        {
          int k=0;
            for (int i = 0; i < arreglo.Length; i++)
            {
              for (int j = 0; j < arreglo1.Length; j++)
              {
                if (arreglo[j] == arreglo1[i])
                {
                    k++;
                }
              }
            }
            return k;
        }

   string Palabra= Console.ReadLine();
   string Palabra1= Console.ReadLine();
   char[] chars = Palabra.ToCharArray();
   char[] chars1 = Palabra1.ToCharArray();
      
    

      int indice = buscarIndice(chars,chars1);
      
if(Palabra==Palabra1){
    Console.WriteLine(false);
  }
  else if ( indice==chars.Length )
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
  
    
  

