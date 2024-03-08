using System;
abstract class Veiculo
{
    //Cria uma classe base Abstrata (Abstract)
    protected int MaxVel = 135, CurrentVel = 0;
    protected bool IsOn = false, IsMoving = false;
    public void TurnOn()
    {
        //Declara IsOn para True (Liga o Carro)
        IsOn = true;
    }
    public void TurnOff()
    {
        //Desliga o Carro Completamente
        IsOn = false;
        IsMoving = false;
        CurrentVel = 0;
    }
    public void SetMaxVel(int num)
    {
        //Regula (Ou Seta) a Velocidade Máxima que o carro pode atingir
        MaxVel = num;
    }
    public void SetCurrentVel(int num)
    {
        //Testa se o Carro está Ligado e se num é menor ou igual a 
        //Velocidade Máxima
        if (IsOn && num <= MaxVel)
        {
            //Se true, "Seta" (Declara) Velocidade Atual como num
            CurrentVel = num;
            //Testa se a Velocidade Atual é Maior igual à 1
            if (CurrentVel >= 1)
            {
                //Se true, O carro está em Movimento
                IsMoving = true;
            }
        }
    }
    public int GetCurrentVel()
    {
        //Retorna o Valor da Velocidade Atual
        return CurrentVel;
    }
    public int GetMaxVel()
    {
        //Retorna o valor da Velocidade Máxima
        return MaxVel;
    }
    public bool IsItOn()
    {
        //Retorna se o carro está ligado ou não
        return IsOn;
    }
    public bool IsItMoving()
    {
        //Retorna se o carro está em Movimento
        return IsMoving;
    }
    public void Stop()
    {
        //Para o carro Imediatamente
        CurrentVel = 0;
        IsMoving = false;
    }
    public void Info()
    {
        //Imprime no console todas as váriaveis sobre o carro 
        Console.Clear();
        Console.WriteLine("Ligado: {0}", IsOn);
        Console.WriteLine("Em Movimento: {0}", IsMoving);
        Console.WriteLine("Velocidade Atual: {0}", CurrentVel);
        Console.WriteLine("Velocidade Máxima: {0}", MaxVel);
    }
}
class Carro : Veiculo
{
    //Herda todas as Caracteristicas da Classe Veiculo

    //Caso houvesse uma classe instanciada como abstract na classe base,
    //Seria necessário a delcrarar aqui usando override

    public Carro()
    {
        //Cria um construtor para a Classe Carro 
        /*(Ou seja, tudo que estiver aqui vai ser executado 
           quando instanciado como objeto em Main)*/
        //Chama o Método Info da classe Base Veiculo
        Info();
    }
}
class Aula_039
{
    static void Main()
    {
        //Cria um objeto da classe Carro com o nome de carro
        Carro carro = new Carro();
    }
}