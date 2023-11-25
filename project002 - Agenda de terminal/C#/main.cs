using System;
using System.Collections.Generic;

class DiaryDataModel {
    public int id;
    public string title;
    public string description;
    public bool check;
    public DiaryDataModel(int id, string title, string description, bool check) {
        this.id = id;
        this.title = title;
        this.description = description;
        this.check = check;
    }
}

class Diary {
    private List<DiaryDataModel> datas = new List<DiaryDataModel>();
     
    public void start(){
        int response = 0;

        do{
            Console.WriteLine("============================================================");
            Console.WriteLine("==================== Selecione um opção ====================");
            Console.WriteLine("============================================================");
            Console.WriteLine("1. CRIAR TAREFA");
            Console.WriteLine("2. MOSTAR TODAS AS TAREFAS");
            Console.WriteLine("3. EXCLUIR TAREFA");
            Console.WriteLine("4. FINALIZAR TAREFA");
            Console.WriteLine("5. EDITAR TAREFA");
            Console.Write("> ");
            try {
                response = int.Parse(Console.ReadLine());
            } catch {
                Console.Clear();
                Console.WriteLine("Opção inválida!");
            }
        } while(response >= 5 && response <= 1);
        if(response == 1) {
            this.Add();
        } else if (response == 2) {
            this.ListView();
        } else if (response == 3) {
            this.Delete();
        } else if (response == 4) {
            this.Check();
        } else if (response == 5) {
            this.Update();
        } else {
            Console.Clear();
            Console.WriteLine("Opção inválida!");
        }
    }
    private void viewListWithIndex(string message){
        for(int index = 0; index < this.datas.Count; index++) {
            Console.WriteLine("{0} - [{1}] {2}", index, this.datas[index].check ? "X" : " ", this.datas[index].title);
        }
        Console.Write(message);
    }
    public void ListView(){
        Console.Clear();
        Console.WriteLine("============================================================");
        if(this.datas.Count > 0) {
            foreach (var item in this.datas) {
                Console.WriteLine("[{0}] {1}", item.check ? "X" : " ", item.title);
            }
        } else {
            Console.WriteLine("* Nenhum tarefa na lista");
        }
        Console.WriteLine("============================================================");
    }
    public void Add() {
        Console.Write("Título: ");
        string title = Console.ReadLine();
        Console.Write("Descrição: ");
        string description = Console.ReadLine();
        
        this.datas.Add(new DiaryDataModel(this.datas.Count, title, description, false));
        Console.Clear();
        Console.WriteLine("Adicionado com sucesso!");
    }
    public void Delete() {
        viewListWithIndex("Pelo index, qual você deseja deletar? ");
        int res = int.Parse(Console.ReadLine());
        this.datas.RemoveAt(res);
        Console.Clear();
        Console.WriteLine("Deletado com sucesso!");
    }
    public void Check() {
        viewListWithIndex("Pelo index, qual você deseja marcar/desmarcar com feito? ");
        int res = int.Parse(Console.ReadLine());
        try {
            if(this.datas[res].check == true) {
                this.datas[res].check = false;
                Console.Clear();
                Console.WriteLine("Desmarcado como feito com sucesso!"); 
            } else {
              this.datas[res].check = true;
                Console.Clear();
                Console.WriteLine("Marcado como feito com sucesso!");   
            }
        } catch {
            Console.Clear();
            Console.WriteLine("Opção inválida!");
        }
    }
    public void Update(){
        viewListWithIndex("Pelo index, qual você deseja editar? ");
        try {
            int res = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("titulo: {0} - Descrição: {1}", this.datas[res].title, this.datas[res].description);
            Console.Write("Novo título: ");
            string title = Console.ReadLine();
            Console.Write("Nova descrição: ");
            string description = Console.ReadLine();

            this.datas[res].title = title;
            this.datas[res].description = description;

            Console.Clear();
            Console.WriteLine("Editado com sucesso!"); 
        } catch {
            Console.Clear();
            Console.WriteLine("Opção inválida!");
        }
    }
}
delegate DiaryDataModel OP(DiaryDataModel n1);
class Primary {
    static void Main(){
        Diary methods = new Diary();

        while (true) {
            methods.start();
        }
    }
}