using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguntaManager : MonoBehaviour
{
    public GameObject preguntaPanel;
    private bool panelActivo = false;

    private void Start()
    {
        // Llama a la función "MostrarPregunta" cada 60 segundos, comenzando después de 10 segundos de espera.
        InvokeRepeating("MostrarPregunta", 10f, 12f);
    }

    private void MostrarPregunta()
    {
        if (!panelActivo)
        {
            // Activa el panel de la pregunta.
            preguntaPanel.SetActive(true);

            // Después de 5 segundos, desactiva el panel.
            Invoke("OcultarPregunta", 5f);

            panelActivo = true; // Marca el panel como activo.
        }
    }

    private void OcultarPregunta()
    {
        // Desactiva el panel de la pregunta.
        preguntaPanel.SetActive(false);

        panelActivo = false; // Marca el panel como inactivo.
    }
}
