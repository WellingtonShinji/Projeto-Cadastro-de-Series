using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoDio.Interfaces;

namespace ProjetoDio.Classes
{
    public class RepositorioSeries : IRepositorio<Series>
    {
        private List<Series> ListaSerie = new List<Series>();
        public void Atualizar(int Id, Series objeto)
        {
            ListaSerie[Id] = objeto;
        }

        public void Criar(Series objeto)
        {
            ListaSerie.Add(objeto);
        }

        public void Deletar(int Id)
        {
            ListaSerie[Id].Excluir();
        }

        public List<Series> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Series RetornarPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}