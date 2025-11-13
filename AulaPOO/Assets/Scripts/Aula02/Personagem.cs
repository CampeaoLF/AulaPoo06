using UnityEngine;

public enum tipopersonagem
{
    guerreiro,
    mago,
    arqueiro
}
public abstract class Personagem : IPersonagem
{
    //private TipoPersonagem tipo;
    protected string nome;
    protected int vida;
    protected int flechas;
    //private TipoPersonagem tipo;

    public Personagem(string nome, int vida, int flechas)
    {
        this.nome = nome;
        //if (vida > 100)
        //{
        //    this.vida = 100;
        //}
        this.vida = vida;
        this.flechas = flechas;
    }

    public virtual void gritar()
    {
        Debug.Log("AAAAAAAH!");
    }

    public void atirarFlechas()
    {
        flechas -= 1;
        if (flechas >= 0) Debug.Log(flechas + " Restantes");
        if (flechas <= 0)
        {
            Debug.Log("Sem Flechas!");
        }
    }

    //public TipoPersonagem GetTipoPersonagem() 
    //{ 
    //    return tipo; 
    //}
    //public void SetTipoPersonagem(TipoPersonagem tipo)
    //{
    //    this.tipo = tipo;
    //}

    public abstract void ReceberDano(int dano);
   
    public string GetNome()
    {
        return nome;
    }
    public void SetNome(string nome)
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
    public int GetFlechas()
    {
        return flechas;
    }
    public void SetFlechas(int flechas)
    {
        this.flechas = flechas;
    }

    public void conversar(string mensagem)
    {
        Debug.Log($"{nome} diz : {mensagem}");
    }
}