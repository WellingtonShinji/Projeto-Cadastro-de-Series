using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDio.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornarPorId(int id);
        void Criar(T entidades);
        void Deletar(int Id);
        void Atualizar(int Id, T entidades);
        int ProximoId();






    }
}