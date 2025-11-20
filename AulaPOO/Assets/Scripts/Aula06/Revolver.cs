
using UnityEngine;

public class Revolver : Arma02, IArmaFogo
{
    public Revolver(string nome, int dano) : base(nome, dano)
    {
    }

    public void Atirar()
    {
        Debug.Log("Voce atirou com revolver");
    }

    public override void Usar()
    {
        Debug.Log("Atacando com o revolver!");
    }
}
