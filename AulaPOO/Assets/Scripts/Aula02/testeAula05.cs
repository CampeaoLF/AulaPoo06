
using Unity.VisualScripting;
using UnityEngine;

public class TesteAula05 : MonoBehaviour
{
    void Start()
    {
        Player player = new Player("Herói", 100, 5);
        Inimigo inimigo = new Inimigo("Monstro", 80, 15, 5);
        //Arqueiro arqueiro = new Arqueiro("Hero",80, 5);

        player.gritar();
        inimigo.gritar();
        inimigo.reclamar();
        player.SetNome("Super Herói");
        //Personagem p = new Personagem("Genérico",10, 5);
        //p.gritar();
        //p.SetVida(70);
        //arqueiro.atirarFlechas();
        //arqueiro.atirarFlechas();
        //arqueiro.atirarFlechas();
        //arqueiro.atirarFlechas();
        //arqueiro.atirarFlechas();

    }

}
