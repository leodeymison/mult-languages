using System;
using System.Collections.Generic;

namespace ProgramMenus {
    class Menus {
        private int createList(string title, Dictionary<int, string> list, List<int> options) {
            int response = 0;
            try {
                do {
                    int lines = 60;
                    Console.WriteLine(new String('=', lines));
                    Console.WriteLine(
                        "{0} {1} {2}", 
                        new String('=', ((lines / 2) - 1) - (title.Length / 2)), 
                        title,
                        new String('=', ((lines / 2) - 1) - (title.Length / 2))
                    );
                    Console.WriteLine(new String('=', lines));

                    foreach(KeyValuePair<int, string> item in list) {
                        Console.WriteLine("{0}. {1}", item.Key, item.Value);
                    }
                    Console.WriteLine(new String('=', lines));
                    Console.Write("> ");
                    response = int.Parse(Console.ReadLine());
                    Console.Clear();
                } while (!options.Contains(response));
            } catch {
                Console.Clear();
                Console.WriteLine("Opção inválida!");
            }
            return response;
            
        }
        public void MenuPrimary() {
            int res = this.createList(
                "MENU PRINCIPAL",
                new Dictionary<int, string>(){
                    {1, "Menu de categorias"},
                    {2, "Menu de entradas"},
                    {3, "Menu de saídas"},
                    {4, "Sair"},
                }, 
                new List<int>(){1, 2, 3, 4}
            );
            
            if(res == 1) {
                
            } else if(res == 2) {

            }
        }
        public int MenuExist() {
            int res = this.createList(
                "MENU DE SAIDAS",
                new Dictionary<int, string>(){
                    {1, "Cria um gasto"},
                    {2, "Ver todos os gotos"},
                    {3, "Ver todos os gastos de um mês"},
                    {4, "Editar um gasto"},
                    {5, "Excluir gasto"},
                    {6, "Voltar"},
                }, 
                new List<int>(){1, 2, 3, 4, 5, 6}
            );
            
            return res;
        }
        public int MenuOpen() {
            int res = this.createList(
                "MENU DE ENTRADAS",
                new Dictionary<int, string>(){
                    {1, "Cria um entrada"},
                    {2, "Ver todas as entrada"},
                    {3, "Ver todas as entrada de um mês"},
                    {4, "Editar um entrada"},
                    {5, "Excluir entrada"},
                    {6, "Voltar"},
                }, 
                new List<int>(){1, 2, 3, 4, 5, 6}
            );
            
            return res;
        }
        public int MenuCategories() {
            int res = this.createList(
                "MENU DE CATEGORIAS",
                new Dictionary<int, string>(){
                    {1, "Cria um categoria"},
                    {2, "Ver todas as categorias"},
                    {3, "Editar um categoria"},
                    {4, "Excluir categoria"},
                    {5, "Voltar"},
                }, 
                new List<int>(){1, 2, 3, 4, 5}
            );
            
            return res;
        }
    }
}