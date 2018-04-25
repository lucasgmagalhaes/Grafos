﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using listaPraticaGrafo.estrutura;
using listaPraticaGrafo.interfaces;
using System.IO;
using listaPraticaGrafo.utils;
namespace listaPraticaGrafo
{
    class Program
    {
        static void Main(string[] args)
        {

            LeitorArquivo leitor = new LeitorArquivo();
           string[] linhas =  leitor.lerArquivo("grafo.txt");
            Grafo grafo = new Grafo();
            //grafo.GerarGrafo(linhas);
            grafo.GerarGrafo(FileArray.GRAFO1_NAO_DIRIGIDO);
            Console.WriteLine(grafo.ToString());
            Console.CursorVisible = false;
            Console.ReadKey();
            
        }
    }
}
