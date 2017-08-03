using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

//Script para hacer un cambio de escena cuando el boton o texto sea seleccionado


public class CambioEscena : MonoBehaviour {

	public bool siPersonaje = false;
	public int indiceJugador;

    public string nivel;//Nombre del nivel a cambiar
    public Renderer rend;//Para modificar el color del boton 
    private Color original;
	public List <float> rgbPass =  new List<float>(3);//Tono de color cuando se pasa el cursor por encima
	public List <float> rgbClick= new List<float> (3);//Tono de color cuando se le da click

    // Inicializar el boton
    void Start () {
        rend = GetComponent<Renderer>();
        original = rend.material.color;
        rend.enabled = true;
        
    }
	
	void Update () {
	
	}

	//Si el cursor esta en la region del colisionador
    void OnMouseEnter()
    {
		Color seleccionado = new Color (rgbPass[0],rgbPass[1],rgbPass[2]);
        rend.material.color = seleccionado;
    }

	//si el mouse sale de la region
    void OnMouseExit()
    {

        rend.material.color = original;
    }

	//Si se da click en la region, simulado con el kinect y su cursor
    void OnMouseDown()
    {
		Color seleccionado = new Color (rgbClick[0],rgbClick[1],rgbClick[2]);
		rend.material.color = seleccionado;
		if (siPersonaje) {
			PlayerPrefs.SetInt ("Personaje", indiceJugador);
		}
        SceneManager.LoadScene(nivel);
        //Application.LoadLevel(nivel);

    }


}
