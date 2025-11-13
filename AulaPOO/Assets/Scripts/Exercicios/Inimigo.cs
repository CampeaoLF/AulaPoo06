using UnityEditor;
using UnityEngine;

public class Inimigo1
{
    private string nome;
    private int vida;

    public Inimigo1(string nome, int vida)
    {
        this.nome = nome;
        this.vida = vida;
    }

    public Inimigo1( int vida)
    {
        this.vida = 50;
    }

    public string Getnome()
    {
        return nome;
    }

    public void Setnome(string nome)
    {
      this.nome = nome;
    }

    public int Getvida()
    {
        return vida;
    }
    public void Setvida(int vida)
    {
        this.vida = vida;
    }
}
