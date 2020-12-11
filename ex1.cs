using System;

public struct Data
{
  public int dia,mes,ano;
   
}
static bool bissexto(int ano, int ano_valido)
{
    if (ano % 400 == 0) {
    bissexto = true;    
    }
    else if ((ano % 4 == 0) && (ano % 100 != 0)) {
    bissexto = true;   
    ano_valido = bissexto; 
    }
    else {
    bissexto = false;
    }
}

class MainClass {
  public static void Main (string[] args) {
    int validacao=0;
    bool bissexto();
    Console.WriteLine ("Digite Uma Data, seguindo o padrão dd/mm/aa ! \n");
    Console.WriteLine("Dia: ");
    Data.dia = int.Parse(Console.ReadLine());
    Console.WriteLine("Mês: ");
    Data.mes = int.Parse(Console.ReadLine());
    Console.WriteLine("Ano: ");
    Data.ano = int.Parse(Console.ReadLine());
    
    if(Data.dia == 1 && <= 31 && Data.mes == 1 && <=12 && Data.ano == ano_valido (Data.ano == 1 && <=366) || Data.ano == ano_valido (Data.ano == 1 && <= 365){
      Console.WriteLine("A data inserida é válida!");
    }else{
      Console.WriteLine("A data inserida é inválida!");
    }
   }
}
// cheguei nessa parte, mas a partir daí não consegui alterar mais... não consegui identificar o erro.
// mas acho que a lógica do programa esteja correta