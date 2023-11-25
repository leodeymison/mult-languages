# 0001 - CONSOLE (HELLO WORLD)

## Opções de comandos no console

### Console.Write(...): 
O Console.write ele executa algo na tela, seja um texto usando "...", uma variábel ou um método de classe com retorno.

exemplo:
```csharp
class Program {
    static void Main(){
        Console.Write("Hello World!");
    }
}

//> Hello World!
``````

O `Console.Write` ele não quebra a linha quando termina de executar o texto, podendo ser resolvido adicionando um `\n`

```csharp
class Program {
    static void Main(){
        Console.Write("Hello World!\n");
    }
}

//> Hello World!

``````

Podemos também passar texto com variável. informando apenas o index que será substitudo.

exemplo:
```csharp
class Program {
    static void Main(){
        string name = "Leodeymison";
        int age = 20;
        Console.Write("Nome: {0}; Idade: {1}", name, age)]
    }
}

//> Nome: Leodeymison; Idade: 20
```

### Console.WriteLine(...): 
A diferença do `Console.Write` para o `Console.WriteLine` é que o `Console.WriteLine` quebra a linha, assim não sendo mais necessário o uso do `\n`.

### Console.Read(): 
O `Console.Read` serve para capturar valores digitados no teclado e armazenar em uma variável do tipo `string`, caso deseje que pegar valores de outros tipos, pode ser usados as conversões de tipos.

```csharp
Console.Write("Digite seu nome: ");
string name = Console.Read();
Console.WriteLine("\nSeja bem-vindo {0}", name);

//> Digite seu nome: [Leodeymison]
//> Seja bem-vindo Leodeymison


// Obs: O [] significa o que foi digitado pelo o usuário
```

O `Console.Read` ele não quebra a linha quando termina de executar o texto

### Console.ReadLine(): 
A diferença do `Console.Read` para o `Console.ReadLine` é que o `Console.ReadLine` quebra a linha, assim não sendo mais necessário o uso do `\n` no `Console.WriteLine`.

```csharp
Console.Write("Digite seu nome: ");
string name = Console.ReadLine();
Console.WriteLine("Seja bem-vindo {0}", name);

//> Digite seu nome: [Leodeymison]
//> Seja bem-vindo Leodeymison


// Obs: O [] significa o que foi digitado pelo o usuário
```

Vale destacar que o `Console.Read` e `Console.ReadLine` não recebem parâmetros.