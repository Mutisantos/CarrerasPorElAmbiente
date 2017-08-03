using UnityEngine;
using System.Collections;

public class PrefJugador : MonoBehaviour {


	public int variable;
	public bool si;
	// Use this for initialization
	void Start () {
		/*if (si) {
			PlayerPrefs.SetInt ("Personaje", variable);//Guardar una variable accesible para todo el juego
		}*/
	}
	
	// Update is called once per frame
	void Update () {
		if (si) {
			int a = (PlayerPrefs.GetInt("Personaje"));
			print (a);
			if(a==1){
				print ("Eutimio");
			}
			if(a==2){
				print ("Doc");
			}
			if(a==3){
				print ("Nuon");
			}
			if(a==4){
				print ("Mayu");
			}
		}
	}
}
