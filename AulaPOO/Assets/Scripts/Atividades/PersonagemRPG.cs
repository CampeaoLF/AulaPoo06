using UnityEngine;


public class PersonagemRPG
{
    private string nome;
    private int vida;
    private int mana;

    public void Personagem(string nome, int vida, int mana)
    {
        this.nome = nome;
        this.vida = vida;
        this.mana = mana;
    }
    public string GetNome()
    {
        return nome;
    }
    public void setNome(string nome)
    {
        this.nome = nome;
    }
    public int GetVida()
    {
        return vida;
    }
    public void SetVida(int vida)
    {
        this.vida = vida;
    }
    public int GetMana()
    {
        return mana;
    }
    public void SetMana(int mana)
    {
        this.mana = mana;
    }

}
