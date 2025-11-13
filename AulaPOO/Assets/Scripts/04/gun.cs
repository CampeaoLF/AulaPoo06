using UnityEngine;

public class arma
{
    private string nome;
    private int dano;

    public arma (string nome, int dano)
    {
        this.nome = nome;
        this.dano = dano;
    }

    public void setDano(int dano)
    {
        this.dano=dano;
    }

    public int getDano() 
    { 
      return this.dano;
    }
}
