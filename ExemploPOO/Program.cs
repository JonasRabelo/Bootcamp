// Classe base (superclasse)
public class Animal
{
    public string Nome { get; set; }
    
    public void EmitirSom()
    {
        Console.WriteLine("Som do animal.");
    }
}

// Classe derivada (subclasse)
public class Cachorro : Animal
{
    public void Latir()
    {
        Console.WriteLine("Woof!");
    }
}





























using ExemploPOO.Models;

ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();

c1.Sacar(500);

c1.ExibirSaldo();









/*Pessoa p1 = new Pessoa();
p1.Nome = "Jonas";
p1.Idade = 25;

p1.Apresentar();
*/