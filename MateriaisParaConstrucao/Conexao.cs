﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriaisParaConstrucao
{
    public class Conexao
    {
        //Atributo que é a String de Conexão.
        private static string conexao = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Construcao;Integrated Security=True";

        //Método acessor de leitura da String de Conexão.
        public static string stringConexao
        {
            get { return conexao; }
        }
    }
}
