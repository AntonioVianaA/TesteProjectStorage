using Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DAL
{
    class EstoqueDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        //Busca de Ingredientes dentro do Estoque
        public static Storage BuscarIngredienteStr(Storage s)
        {
            return ctx.Storage.SingleOrDefault(x => x.Ingrediente.Equals(s.Ingrediente));
        }

        //Metodo de Cadastro de Ingrediente
        public static bool CadastrarIngredienteStr(Storage s)
        {
            if (BuscarIngredienteStr(s) == null)
            {
                ctx.Storage.Add(s);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        //Remover Receita
        public static bool RemoverIngredienteStr(Storage s)
        {
            if (BuscarIngredienteStr(s) != null)
            {
                ctx.Storage.Remove(s);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        //Alterar Ingrediente que ja esta cadastrado no Stoque
        public static void AlterarIngredienteStr(Storage s)
        {
            ctx.Entry(s).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
