using System;
using System.Collections.Generic;
interface CategoryModel {
    void ViewAll();
    void Create();
}

class CategoryObject {
    public int id;
    public string title;
    CategoryObject(int id, string title) {
        this.id = id;
        this.title = title;
    }
}

namespace Categories : CategoryModel {
    private List<CategoryObject> list = new List<CategoryObject>();
    class Category {
        public void ViewAll(){
            foreach(CategoryObject item in list) {
                Console.WriteLine("{0} - {1}", item.id, item.title);
            }
        }
        public void Create(){
            Console.Write("Título da categoria: ");
            string title = Console.ReadLine();
            this.list.Add(new CategoryObject(this.list.Count, title));
        }
    }
}