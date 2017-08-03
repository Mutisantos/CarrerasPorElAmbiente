using System;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    //Clase para controlar la pausa en medio de la carrera y desplegar su respectivo menpu
    private Toggle m_MenuToggle;//similar al boolean pero para la activación del menu
	private float m_EscalaTiempo = 1f;//Tiempo normal del juego
    private float m_EscalaVolumen = 1f;//Volumen normal del juego
    private bool m_Pausado;//Si el juego fue pausado o no

    //Cuando se active el menu
    void Awake()
    {
        m_MenuToggle = GetComponent <Toggle> ();
	}

    //Si se despliega el menu, parar toda accion dentro del juego para que al reanudar, nada haya cambiado
    private void MenuOn ()
    {
        m_EscalaTiempo = Time.timeScale;
        Time.timeScale = 0f;//Detener todos los movimientos

        m_EscalaVolumen = AudioListener.volume;
        AudioListener.volume = 0f;//Detener todos los sonidos

        m_Pausado = true;//Pausar
    }

    //Reanudar el juego retornado el flujo de tiempo y volumen al original
    public void MenuOff ()
    {
        Time.timeScale = m_EscalaTiempo;
        AudioListener.volume = m_EscalaVolumen;
        m_Pausado = false;
    }


    public void OnMenuStatusChange ()
    {
        if (m_MenuToggle.isOn && !m_Pausado)
        {
            MenuOn();
        }
        else if (!m_MenuToggle.isOn && m_Pausado)
        {
            MenuOff();
        }
    }


    //Estar pendiente de todos los eventos dentro del juego y detectar si se ha usado la tecla para iniciar o salir del menú
	void Update()
	{
		if(Input.GetKeyUp(KeyCode.Escape))
		{
		    m_MenuToggle.isOn = !m_MenuToggle.isOn;//Cambiar el valor de Toogle
		}
	}


}
