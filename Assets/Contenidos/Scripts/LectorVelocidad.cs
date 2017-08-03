using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class LectorVelocidad : MonoBehaviour {


	public Rigidbody cuerpo;
	public Slider barraVel;
	public Image fill;
	public Text texto;

	// Use this for initialization
	void Start () {
		texto.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		double velocidad = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().velocity.magnitude * 3.6;
		barraVel.value = (int) velocidad;
		if (velocidad < 40) {
			fill.color = Color.green;
		} else if (velocidad > 40 && velocidad < 60) {
			fill.color = Color.yellow;
		} else if (velocidad > 60 && velocidad < 80) {
			fill.color = new Color32 (240, 130, 40, 255);
		} else if (velocidad > 80) {
			fill.color = Color.red;
		}
		texto.text = string.Format ("{0:000}",velocidad);

		
	}
}
