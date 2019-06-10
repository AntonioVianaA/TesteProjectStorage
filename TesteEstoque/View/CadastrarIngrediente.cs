using Estoque.DAL;
using Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.View
{
    class CadastrarIngrediente
    {

        public static void Renderizar()
        {
            Ingrediente i = new Ingrediente();
            //Storage s = new Storage();

            Console.WriteLine("\nCADASTRO DE INGREDIENTES");
            Console.WriteLine("\nDigite o nome do Ingrediente:");
            i.Nome = Console.ReadLine();
            Console.WriteLine("Digite a descrição do Ingrediente:");
            i.Descricao = Console.ReadLine();
            //Console.WriteLine("Preço do Ingrediente:");
            //i.Preco = Convert.ToDouble(Console.ReadLine());
            if (IngredienteDAO.CadastrarIngrediente(i))
            {
                Console.WriteLine("\nIngrediente Cadastrado na base de dados com sucesso!");
            }
            else
            {
                Console.WriteLine("\nIngrediente ja cadastrado");
            }

        } 
    }
}
