using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CargadorPersonaje : MonoBehaviour {

	public List <float> coords;//Coordenadas para ubicar al personaje
	public List <GameObject> prefabs;//Personajes disponibles a cargar
	public GameObject reff;//Referencia para el seguimiento




	// Iniciar la escena cargando el personaje seleccionado
	void Start () {
		float  m_EscalaTiempo = Time.timeScale;
		Time.timeScale = 0f;//Detener todos los movimientos
		Vector3 vec = new Vector3 (coords [0], coords [1], coords [2]);
		Quaternion cuat = Quaternion.identity;
		if (PlayerPrefs.GetInt ("Personaje") == 1) {//Nanow
			var clone1  = Instantiate (prefabs[0], vec, cuat) as GameObject;
			reff.transform.parent = clone1.transform;
		}
		if (PlayerPrefs.GetInt ("Personaje") == 2) {//Doc
			var clone1  = Instantiate (prefabs[1], vec, cuat) as GameObject;
			reff.transform.parent = clone1.transform;
		}
		if (PlayerPrefs.GetInt ("Personaje") == 3) {//Magnus
			var clone1  = Instantiate (prefabs[2], vec, cuat) as GameObject;
			reff.transform.parent = clone1.transform;
		}

		if (PlayerPrefs.GetInt ("Personaje") == 4) {//Mayu
			var clone1  = Instantiate (prefabs[3], vec, cuat) as GameObject;
			reff.transform.parent = clone1.transform;
		}
		Time.timeScale = m_EscalaTiempo;


	}
	

}
