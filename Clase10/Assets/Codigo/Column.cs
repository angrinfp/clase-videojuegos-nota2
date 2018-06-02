using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Column : MonoBehaviour {

    public Text TextoPuntajes;

    private int contadorPuntajes;

	// Use this for initialization
	void Start () {
        contadorPuntajes = 0;		
	}

    public void AumentarPuntajes()
    {
        contadorPuntajes++;
        TextoPuntajes.text = "Puntaje: " + contadorPuntajes;
    }

    public void RestarPuntajes()
    {
        contadorPuntajes--;
        TextoPuntajes.text = "Puntaje: " + contadorPuntajes;
    }
}
