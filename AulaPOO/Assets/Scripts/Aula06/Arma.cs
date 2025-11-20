
using UnityEngine;

public abstract class Arma02
{
    private string nome;
    private int dano;

    public Arma02(string nome, int dano)
    {
        this.nome = nome;
        this.dano = dano;
    }

    public int GetDano()
    {
        return dano;
    }

    public string GetNome()
    {
        return nome;
    }

    public abstract void Usar();
}
