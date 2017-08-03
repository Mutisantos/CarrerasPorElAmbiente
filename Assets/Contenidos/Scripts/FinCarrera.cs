using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class FinCarrera : MonoBehaviour {


	public AudioClip fuente;
	public Text labelTiempo; 
	public string escenaSiguiente;
	private float tinicial;
	private int lugares = 1;
	private bool primero = false;


	void Start () {
		tinicial = Time.timeSinceLevelLoad;

	}
	

	void Update () {

		if (primero) {
			PlayerPrefs.SetString ("Segundo", "Roland Trompas");
			PlayerPrefs.SetString ("Tercero", "Astanihad Al Shaawami");
			PlayerPrefs.SetString ("Cuarto", "Agente J");
			Application.LoadLevel(escenaSiguiente);	

		}
		if (lugares == 5) {
			Debug.Log("TODOS LLEGARON");
			Application.LoadLevel(escenaSiguiente);			
		}
		int minutos = (int)Time.timeSinceLevelLoad / 60;
		string tiempis = string.Format ("{0:00}:{1:00}.{2:0}",minutos,Time.timeSinceLevelLoad%60,(Time.timeSinceLevelLoad*1000)%1000);
		labelTiempo.text = tiempis;




		
	}
	//Registrar el orden de llegada
	void OnTriggerEnter(Collider other) {
		int minutos = (int)Time.timeSinceLevelLoad / 60;
		string tiempis = string.Format ("{0:00}:{1:00}.{2:0}",minutos,Time.timeSinceLevelLoad%60,(Time.timeSinceLevelLoad*1000)%1000);
		Debug.Log (tiempis);

		if (other.tag.Contains ("Jugador")) {
			if (lugares == 1) {

				Debug.Log ("Victoria" + other.name + " " + tiempis);
				PlayerPrefs.SetString ("Primero", other.name);
				PlayerPrefs.SetString ("Victoria", "Has ganado: Jugador "+other.name + "¡Felicidades!");
				PlayerPrefs.SetString ("PrimeroT", tiempis);
				//primero = true;

			} else {

				if (lugares == 2){
					PlayerPrefs.SetString ("Segundo", other.name);
					PlayerPrefs.SetString ("SegundoT", tiempis);
				}
				if (lugares == 3){
					PlayerPrefs.SetString ("Tercero", other.name);
					PlayerPrefs.SetString ("TerceroT", tiempis);
				}
				if (lugares == 4){
					PlayerPrefs.SetString ("Cuarto", other.name);
					PlayerPrefs.SetString ("CuartoT", tiempis);
				}
			}
			lugares++;
		} 
		else if (other.tag.Contains("Enemigo")) {
			Debug.Log ("Llego " + other.name);
			if(lugares==1){
				PlayerPrefs.SetString ("Primero", other.name);
				PlayerPrefs.SetString ("Victoria", "Ha ganado la Computadora "+other.name);
				PlayerPrefs.SetString ("PrimeroT", tiempis);
			}
			if(lugares==2) {
				PlayerPrefs.SetString ("Segundo", other.name);
				PlayerPrefs.SetString ("SegundoT", tiempis);
			}
			if(lugares==3){
				PlayerPrefs.SetString ("Tercero", other.name);
				PlayerPrefs.SetString ("TerceroT", tiempis);
			}
			if(lugares==4){
				PlayerPrefs.SetString ("Cuarto", other.name);
				PlayerPrefs.SetString ("CuartoT", tiempis);
			}
			lugares++;
		}


	}
}
