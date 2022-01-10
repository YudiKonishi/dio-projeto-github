using System;
namespace Revisão{
    class Program{
        static void Main(string[] args){
            var indice_alunos = 0;
            string resposta = RespostaUsuario();
            Aluno[] alunos = new Aluno[5];

            while (resposta.ToUpper() != "X")
            {
                switch(resposta){
                    case "1": 
                        Console.WriteLine("Informe o nome do aluno:");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Informe a nota do aluno:");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.Nota = nota;
                        }else{
                            throw new ArgumentException("Valor da nota precisa ser decimal");
                        }
                        alunos[indice_alunos] = aluno;
                        indice_alunos++;
                        break;
                    case "2":
                        for(int i = 0; i < indice_alunos; i++){
                            Console.WriteLine($"Aluno: {alunos[i].Nome}  Nota: {alunos[i].Nota}");
                        }
                        break;
                    case "3":
                        var soma = 0;
                        for(int i = 0; i < indice_alunos; i++){
                            soma = soma + Convert.ToInt16(alunos[i].Nota);
                        }
                        var media = soma/indice_alunos;
                        Conceito conce;
                        if(media<4){
                            conce = Conceito.F;
                        }else if(media < 5){
                            conce = Conceito.D;
                        }else if(media < 6.5){
                            conce = Conceito.C;
                        }else if(media < 7.5){
                            conce = Conceito.B;
                        }else{
                            conce = Conceito.A;
                        }
                        Console.WriteLine($"Média geral: {media} Conceito: {conce}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Informe um valor válido");
                }
                resposta = RespostaUsuario();
            }
            string RespostaUsuario()
            {
                Console.WriteLine("");
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1- Inserir novo aluno");
                Console.WriteLine("2- Listar alunos");
                Console.WriteLine("3- Calcular média geral");
                Console.WriteLine("X- Sair");
                Console.WriteLine("");

                resposta = Console.ReadLine();
                if(resposta != null)
                    return resposta;
                return "nulo";
                
            }
        }
        
    }

}
    