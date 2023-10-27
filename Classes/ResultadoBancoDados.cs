using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PimFolhaPagamento.Classes
{
    public class ResultadoBancoDados
    {
        public List<List<Dictionary<string, object>>> Resultado { get; set; }
    }

    public class RsToArray
    {
        public static ResultadoBancoDados CriarJSONDoDataReader(SqlDataReader reader)
        {
            ResultadoBancoDados resultadoBanco = new ResultadoBancoDados();
            resultadoBanco.Resultado = new List<List<Dictionary<string, object>>>();

            // Loop para ler cada conjunto de resultados
            do
            {
                List<Dictionary<string, object>> listaDeDados = new List<Dictionary<string, object>>();

                while (reader.Read())
                {
                    Dictionary<string, object> dadosDoBanco = new Dictionary<string, object>();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string nomeColuna = reader.GetName(i);
                        object valorColuna = reader.GetValue(i);

                        if (valorColuna == null) valorColuna = "";

                        dadosDoBanco[nomeColuna] = valorColuna.ToString().Trim();
                    }

                    listaDeDados.Add(dadosDoBanco);
                }

                resultadoBanco.Resultado.Add(listaDeDados);

            }
            while (reader.NextResult());

            return resultadoBanco;
        }
    }

}