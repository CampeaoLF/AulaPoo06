
using UnityEngine;

public class PersonagemRPG2 
{
    private string nome;
    private int mana;
    private int vida;
    
    public void Personagem(string nome, int mana, int vida)
    {
        this.nome = nome;
        this.vida = vida;
        this.mana = mana;
    }
    public string GetNome()
    {
        return nome;
    }
    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public int GetMana()
    {
        return mana;
    }

    public void SetMana(int mana)
    {
        this.mana = mana;
    }

    public int GetVida()
    {
        return vida;
    }
    public void SetVida(int vida)
    {
        this.vida = vida;
    }

}
