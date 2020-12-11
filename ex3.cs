using System;

class MainClass {

  public struct Carro{
  public int ano;
  public string modelo, cor;
}

  public static void Main (string[] args) {
    Carro[] carros =new Carro[500]

    int opcao;

    Console.Write("Menu Estacionamento, o que deseja realizar:");
    Console.Clear();
    Console.WriteLine("1) Cadastrar carro\n2) Consultar carro por ano de fabricação\n3) Consultar carro por modelo\n4) Consultar carro por cor\n5) Exibir todos os carros cadastrados\n6) Alterar algum dado de um carro\n7) Excluir um carro\n0) Sair");
    opcao = int.Parse(Console.ReadLine());
    switch(opcao){
      case 1:
        cadastro();
        break;
      case 2: 
        consultarAno();
        break;
      case 3:
        consultarModelo();
        break;

      case 4:
        consultarCor();
        break;

      case 5:
        exibirTudo();
        break;

      case 6:
        editarCarro();
        break;

      case 7:
        excluirCarro();
        break;

      case 0:
        sair();

      default:
      Console.WriteLine("Opção inválida");
    }
    }
  }

  static string cadastro(){
    Carro cadastro;
    Console.WriteLine("Insira o ano do carro: ");
    Carro.ano = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o modelo do carro: ");
    Carro.modelo =Console.ReadLine();
    Console.WriteLine("Insira a cor do carro: ");
    Carro.cor = Console.ReadLine();
  }
  static string consultarAno(){
    Console.WriteLine("Todos os carros fabricados neste ano são {0}",Carro.ano);

  }
  static string consultarModelo(){
    Console.WriteLine("Todos os Carros Cadastrados são {0}",Carro.modelo);
  }
  static string consultarCor(){
    Console.WriteLine("Todas as cores dos carros cadastrados são {0}",Carro.cor);
  }
  static string  exibirTudo(){
    Console.WriteLine("Todos os carros cadastrados são {0}", Carro[]);
  }
  static string editarCarro(){

  }
  static string excluirCarro(){

  }
  static string sair(){
    Console.Clear();
    Console.WriteLine("Reinicie o Programa.")
  }
}