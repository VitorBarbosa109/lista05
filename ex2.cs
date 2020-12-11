using System;

public struct Aluno{
  public string nome;
  public double nota1, nota2;
  public double media;
  public string situacao;
  
}



class MainClass {
  public static void Main (string[] args) {
   Aluno[] alunos = new Alunos[15];

   for (int x=0;x<=15;x++){
     Console.WriteLine("\nNome do Aluno[0]º: ",x+1);
     alunos[x].nome = Console.ReadLine();
     Console.WriteLine("\nNota 1 do Aluno[0]º ",x+1);
     alunos[x].nota1 = Console.ReadLine();
     Console.WriteLine("\nNota 2 do Aluno[0]º ",x+1);
     alunos[x].nota2 = Console.ReadLine();
     alunos[x].media = ((alunos[x].nota1 + alunos[x].nota2) / 2);
     Console.Clear();
   }
   for (int x=0;x<=15;x++){
    if (alunos[x].media>=7){
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("Aluno {0},teve as notas {1} e notas {2}, obtendo a média de {3}.\n O aluno(a) foi aprovado!",alunos[x].nome,alunos[x].nota1,alunos[x].nota2,alunos[x].media);
    }else{
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Aluno {0},teve as notas {1} e notas {2}, obtendo a média de {3}.\n O aluno(a) foi reprovado!",alunos[x].nome,alunos[x].nota1,alunos[x].nota2,alunos[x].media);
    }




   }
   
   }
  }
}
// não consegui fazer o programa funcionar de fato, porém, ao meu ver, a lógica do programa está correta...
// pelo menos de acordo com os pdf's e tal, acho que quase cheguei no programa funcional