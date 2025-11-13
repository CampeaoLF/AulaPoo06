using UnityEngine;

public class Magia
{
    private string nome;
    private int power;
    private string descricao;
    private static int contarMagias = 0;
    

    public Magia (string nome, int poder, string descricao)
    {
        this.nome = nome;
        this.power = poder;
        this.descricao = descricao;
        contarMagias++;
       
    }
    public Magia()
    {
        contarMagias++;
    }
    public static int getContarMagias()
    {
        return contarMagias;
    }

    public string Getnome()
    {
        return nome;
    }

    public void Setnome(string nome)
    {
        this.nome = nome;
    }

    public int Getpoder()
    {
        return power;
    }

    public void Setpoder(int poder)
    {
        this.power = poder;
    }

    public string Getdescricao()
    {
        return descricao;
    }

    public void Setdescricao(string descricao)
    {
        this.descricao = descricao;
    }

   
    public string lancarMagia(string alvo)
    {
        return "Lançando magia: " + nome + " com poder de: " + power + " no alvo " + alvo + ". descrição" + descricao;
    }
}
