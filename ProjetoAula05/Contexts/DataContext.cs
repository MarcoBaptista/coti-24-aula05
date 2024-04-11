using Microsoft.EntityFrameworkCore;
using ProjetoAula05.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Contexts
{
    //context do entityframework
    public class DataContext : DbContext
    {
        //comando para implementar métodos (sobrescrever)

        /// <summary>
        /// método implementado para config o BD
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDProjetoAula05;Integrated Security=True");
        }

        /// <summary>
        /// método implementado para adicionar classes de mapeamento do projeto
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }

    }

}
