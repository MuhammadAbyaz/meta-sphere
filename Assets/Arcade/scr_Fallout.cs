using Photon.Pun;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr_Fallout : MonoBehaviour
{
    public Canvas falloutCanvas;
    void Start(){
        falloutCanvas.gameObject.SetActive(false);
    }
    void OnTriggerEnter(){
        falloutCanvas.gameObject.SetActive(true);
    }
    void OnTriggerExit(){
        falloutCanvas.gameObject.SetActive(false);
    }
}
