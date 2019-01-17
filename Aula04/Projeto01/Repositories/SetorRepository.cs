﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto01.Entities;

namespace Projeto01.Repositories
{
    public class SetorRepository : Conexao
    {
        //Método para inserir um setor no banco de dados
        public void Inserir(Setor setor)
        {
            //Instrução SQL
            string query = "insert into Setor(Nome) values(@Nome)";

            //Executando a instrução SQL...
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Nome", setor.Nome);
            Command.ExecuteNonQuery();
        }

        public void Atualizar(Setor setor)
        {
            string query = "update Setor set Nome = @Nome where IdSetor = @IdSetor";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Nome", setor.Nome);
            Command.Parameters.AddWithValue("@IdSetor", setor.IdSetor);
            Command.ExecuteNonQuery();
        }

        public void Excluir(int idSetor)
        {
            string query = "delete from Setor where IdSetor = @IdSetor";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@IdSetor", idSetor);
            Command.ExecuteNonQuery();
        }
    }
}