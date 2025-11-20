
using UnityEngine;

public class Espada : Arma02, IArmaDeCorte
{
    public Espada(string nome, int dano) : base(nome, dano)
    {
    }
    public void Cortar()
    {
        Debug.Log("Coletou a espada!");
    }

    public override void Usar()
    {
        Debug.Log("Atacando com a espada!");
    }
}
