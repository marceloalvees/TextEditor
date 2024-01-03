
Aplicação de Manipulação de Arquivos via Console
Esta simples aplicação de console permite realizar operações básicas com arquivos, como abrir um arquivo existente, criar um novo arquivo e salvar texto em um arquivo. Ela oferece uma interface orientada por menu para interação do usuário.

Uso
Abrir Arquivo

Selecione a opção 1 para abrir um arquivo existente.
Insira o caminho do arquivo quando solicitado.
O conteúdo do arquivo será exibido no console.
Criar Novo Arquivo

Selecione a opção 2 para criar um novo arquivo.
Insira o texto até pressionar ESC para finalizar.
Você será solicitado a inserir o caminho para salvar o novo arquivo.
Sair

Selecione a opção 0 para sair da aplicação.
Como Executar
Basta incorporar a função Menu() fornecida em seu projeto C# e chamá-la para iniciar a manipulação de arquivos orientada por menu.

csharp
Copy code
class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    
    // ... (inclua as funções Menu(), Open(), Closed() e Save() aqui)
}
```bash
What do you want to do?
1- Open File
2- Create new file
0- Closed
