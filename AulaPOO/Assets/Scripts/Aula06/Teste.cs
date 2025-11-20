using UnityEngine;

public class Teste : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Paladino p = new Paladino("Luis", 100);
        Revolver r = new Revolver("Coult", 10);
        Espada e = new Espada("Espada", 20);
        Player g = new Player("Campeao", 100, 0);

        g.setArma(r);
        g.setArma(e);
        g.conversar("oi");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
