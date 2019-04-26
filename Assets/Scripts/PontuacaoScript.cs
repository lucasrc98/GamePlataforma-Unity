using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PontuacaoScript : MonoBehaviour
{
    public Text pontosUI;
    int pontos;
    
    
    // Start is called before the first frame update
    void Start(){
        pontos = 0;
    }

    // Update is called once per frame
    void Update(){
        
    }
    public void incrementaPontos(){
        this.pontos = this.pontos + 1;
//        pontosUI.text = pontos.ToString();
        Debug.Log(pontos);
    }
}
