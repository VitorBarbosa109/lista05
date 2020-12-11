using System;

class MainClass {
  public static void Main (string[] args) {
      int total = 2;
  		string[] alunos = new string[total];
  		double[,] notas = new double[total,3];
  		double[] media = new double[total];
  		int l,c;

  		for(l=0; l<total; l++){
  			Console.WriteLine("Nome do {0}º aluno: ", l+1);
  			alunos[l] = Console.ReadLine();
  			for(c=0; c<3; c++){
  				Console.WriteLine("{0}º nota: ", c+1);
  				notas[l,c] = double.Parse(Console.ReadLine());  				
  			}
  			media[l] = (notas[l,0] +notas[l,1]+notas[l,2]) / 3;
  		}

  		Console.WriteLine("\n\nResultados: ");

  		for(l=0; l<total; l++){
  			if(media[l] >= 7){
  				Console.ForegroundColor = ConsoleColor.Blue;
  				Console.WriteLine("{0,20} {1,5:N2} {2,5:N2} {3,5:N2} {4,5:N2} - APROVADO", alunos[l], notas[l,0], notas[l,1], notas[l,2], media[l]);
  			}else{
  				Console.ForegroundColor = ConsoleColor.Red;
  				Console.WriteLine("{0,20} {1,5:N2} {2,5:N2} {3,5:N2} {4,5:N2} - REPROVADO", alunos[l], notas[l,0], notas[l,1], notas[l,2], media[l]);	
  			}
  		}
  }
}