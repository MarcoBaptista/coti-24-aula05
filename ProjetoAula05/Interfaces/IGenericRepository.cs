using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Interfaces
{
    
    /// <summary>
    /// interface genérica para definir os métodos básicos de repositório
    /// </summary>
    public interface IGenericRepository<T, Id>
        where T : class
    {
        #region métodos abstratos
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);

        List<T> GetAll();
        T GetById(Id id);

        #endregion


    }
}
