using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Aula06 : MonoBehaviour
{
     void Start()
     {
        List<IPersonagem> lista = new List<IPersonagem>();
        lista.Add(new Player("Heroi", 100, 10));
        lista.Add(new Inimigo("Bandido", 80, 15,10));
        lista.Add(new Paladino("Cavaleiro",120 , 0));
        foreach (IPersonagem p in lista)
        {
            p.ReceberDano(10);
        }
     }
}
