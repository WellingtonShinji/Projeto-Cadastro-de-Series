using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoDio.Enum;

namespace ProjetoDio.Classes
{
    public class Series : Entidades
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }
        public override string ToString()
        {
            string retorno = "*";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição" + this.Descricao + Environment.NewLine;
            retorno += "Ano" + this.Ano + Environment.NewLine;
            retorno += "Excluido" + this.Excluido;
            return retorno;
        }
        public string RetornaTitulo()
        {
            return Titulo;
        }
        public bool RetornaExcluido()
        {
            return Excluido;
        }
        public int RetornaId()
        {
            return Id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }

    }
}