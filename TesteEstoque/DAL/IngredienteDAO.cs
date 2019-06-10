using Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DAL
{
    class IngredienteDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        //Busca Ingrediente
        public static Ingrediente BuscarIngrediente(Ingrediente i)
        {
            return ctx.Ingrediente.FirstOrDefault(x => x.Nome.ToUpper().Equals(i.Nome.ToUpper()));
        }
        //Metodo de Cadastro de Ingrediente
        public static bool CadastrarIngrediente(Ingrediente i)
        {
            if (BuscarIngrediente(i) == null)
            {
                ctx.Ingrediente.Add(i);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
        //Remover Receita
        public static bool RemoverIngrediente(Ingrediente i)
        {
            if (BuscarIngrediente(i) != null)
            {
                ctx.Ingrediente.Remove(i);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        //Alterar Ingrediente que ja esta cadastrado no Banco de Dados
        public static void AlterarIngrediente(Ingrediente i)
        {
            ctx.Entry(i).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
