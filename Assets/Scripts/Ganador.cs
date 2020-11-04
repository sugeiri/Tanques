using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ganador : MonoBehaviour
{
    public Text tGanador;
    // Start is called before the first frame update
    void Start()
    {
        tGanador.text = GameManager.mensaje_Final;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
