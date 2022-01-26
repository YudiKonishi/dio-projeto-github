using ExemploPOO.Helper;
using ExemploPOO.Models;

namespace ExemploPOO{
    class Program{
        static void Main(string[] args){
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");
            FileHelper helper = new FileHelper();
            var ListaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            var ListaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};
            //helper.CriarArquivoTextoStream(caminhoArquivo, ListaString);
            //helper.AdicionarTexto(caminhoArquivo, "ListaStringContinuacao");
            //System.Console.WriteLine("Criando diretório:" + caminhoPathCombine);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
           // helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.ListarDiretorios(caminho);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);
        }
    }
}
            // ICalculadora calc = new Calculador();
            // System.Console.WriteLine(calc.Multiplicar(10, 10));
            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());
            // Corrente c = new Corrente();
            // c.Creditar(1000);
            // c.ExibirSaldo();
            // Calculador calc = new Calculador();
            // System.Console.WriteLine("Resultado da primeira soma: "+ calc.Somar(10, 10));
            // System.Console.WriteLine("Resultado da segunda soma: "+ calc.Somar(10, 10, 10));

            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Nota = 12;
            // p1.Idade = 12;
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Roberto";
            // p2.Salario = 1200;
            // p2.Idade =  40;
            // p2.Apresentar();

            // Pessoa P1 = new Pessoa();
            // P1.Nome = "Yudi";
            // P1.Idade = 20;
            // P1.Apresentas();
            // Retangulo r1 = new Retangulo();
            // r1.DefinirMedidas(30,30);
            // System.Console.WriteLine($"A área é = {r1.ObterArea()}");
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0,0);
            // System.Console.WriteLine($"A área é = {r2.ObterArea()}");