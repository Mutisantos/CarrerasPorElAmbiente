using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultadorFinal : MonoBehaviour {


	public Text Primero, PrimeroT;
	public Text Segundo, SegundoT;
	public Text Tercero, TerceroT;
	public Text  Cuarto,  CuartoT;
	public Text ganador;



	// Use this for initialization
	void Start () {
		Primero.text = PlayerPrefs.GetString ("Primero");
		PrimeroT.text = PlayerPrefs.GetString ("PrimeroT");
		Segundo.text = PlayerPrefs.GetString ("Segundo");
		SegundoT.text = PlayerPrefs.GetString ("SegundoT");
		Tercero.text = PlayerPrefs.GetString ("Tercero");
		TerceroT.text = PlayerPrefs.GetString ("TerceroT");
		Cuarto.text = PlayerPrefs.GetString ("Cuarto");
		CuartoT.text = PlayerPrefs.GetString ("CuartoT");
		ganador.text = PlayerPrefs.GetString ("Victoria");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
