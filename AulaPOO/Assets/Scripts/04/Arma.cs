using UnityEngine;

public class Arma
{
    private string nome;
    private int dano;

    public Arma(string nome, int dano)
    {
        this.nome = nome;
        this.dano = dano;
    }

    public void setDano(int dano)
    {
        this.dano = dano;
    }

    public int getDano()
    {
        return this.dano;
    }

    public string getNome()
    { return this.nome; }
}
