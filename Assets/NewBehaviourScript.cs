using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.text="Ingresa tu respuesta";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            texto.text="¡Bien pensado Woody! ¡Me gusta tu ingenio!";
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            texto.text="¡Volar cual cohete!¡Atacar como bólido!";
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            texto.text="¡Robaré los necesarios para salvar esta compañia!";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            texto.text="¡Nena! ¿Donde esta mi super traje?";
        }
    }
}
