using UnityEngine;

public class Aula03 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Magia m = new Magia("Raio", 50,"Raios Eletrizantes");

        Magia chamas = new Magia();
        chamas.Setnome("Chamas escaldantes");
        chamas.Setpoder(70);
        chamas.Setdescricao("Chamas que derretem");
        
        Debug.Log(chamas.lancarMagia("Chamas"));

        Debug.Log("total de magias criadas: " + Magia.getContarMagias());
        //float tempo = Time.deltaTime;
        //Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
