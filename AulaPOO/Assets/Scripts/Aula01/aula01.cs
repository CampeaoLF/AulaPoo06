using Assets;
using UnityEngine;

public class aula01 : MonoBehaviour
{
    
    void Start()
    {
        Pessoa p1 = new Pessoa();
        //p1.nome = "campeao";
        //p1.email = "campeao@gmail.com";
        p1.receberUmNome("Campeao");


        Debug.Log(p1.falarMeuNome());

        Pessoa p2 = new Pessoa(); // açoes//
        p2.receberUmNome("Luis");

        Debug.Log(p2.perguntarONome(p1));



        //p2.nome = "luis";
        //p2.email = "luis@gmail.com";
        //Debug.Log("Nome: " + p1.nome);
        //Debug.Log("Email: " + p1.nome);

        

    }


    void Update()
    {
        
    }
}
