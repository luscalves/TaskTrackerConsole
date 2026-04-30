Console.WriteLine("==================================");
Console.WriteLine("       TASK TRACKER CONSOLE       ");
Console.WriteLine("==================================");

Console.WriteLine("Cadastro de nova tarefa\n");

Console.WriteLine("Digite o título da tarefa: ");
string tarefa = Console.ReadLine();
Console.WriteLine("Digite a descrição da tarefa: ");
string descricao = Console.ReadLine();gi
Console.WriteLine("Digite o status da tarefa: ");
string status = Console.ReadLine();

Console.WriteLine("==================================");
Console.WriteLine("         TAREFA CADASTRADA        ");
Console.WriteLine("==================================");
Console.WriteLine($"Título: {tarefa}");
Console.WriteLine($"Descricao: {descricao}");
Console.WriteLine($"Status: {status}");
Console.WriteLine("===================================");