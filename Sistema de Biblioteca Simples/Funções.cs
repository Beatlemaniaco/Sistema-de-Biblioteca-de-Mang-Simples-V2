using System;

namespace Sistema_de_Biblioteca_Simples
{
    public class FuncoesBiblioteca
    {
        public static int Ler_Opcao(string mensagem)
        {
            Console.WriteLine(mensagem);
             return Convert.ToInt32(Console.ReadLine());
        }

        public static void VerificarManga(string[] estado_manga, int i, ref int manga_emprestado, ref int manga_disponivel, ref bool erro)
        {
            if (estado_manga[i] == "Emprestado")
            {
                manga_emprestado++;
            }
            else if (estado_manga[i] == "Disponivel")
            {
                manga_disponivel++;
            }
            else
            {
                erro = true;
            }
        }
    }

}