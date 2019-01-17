﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto01.Entities;

namespace Projeto01.Repositories
{
    public class FuncionarioRepository : Conexao
    {
        public void Inserir(Funcionario funcionario)
        {
           string query = "insert into Funcionario(Nome, Salario, DataAdmissao, IdSetor)" 
                + " values(@Nome, @Salario, @DataAdmissao, @IdSetor)";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Nome", funcionario.Nome);
            Command.Parameters.AddWithValue("@Salario", funcionario.Salario);
            Command.Parameters.AddWithValue("@DataAdmissao", funcionario.DataAdmissao);
            Command.Parameters.AddWithValue("@IdSetor", funcionario.Setor.IdSetor);
            Command.ExecuteNonQuery();
        }
    }
}
