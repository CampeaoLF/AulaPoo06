using UnityEngine;

public  class Paladino : Personagem
{
    public Paladino(string nome, int vida, int flechas) : base(nome, vida, flechas)
    {
       
    }

    public override void ReceberDano(int dano)
    {
        this.vida -= dano;
    }
}
