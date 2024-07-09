using UnityEngine;

public class scr_BallGame : MonoBehaviour
{
    public Canvas ballCanvas;
    void Start(){
        ballCanvas.gameObject.SetActive(false);
    }
    void OnTriggerEnter(){
        ballCanvas.gameObject.SetActive(true);
    }
    void OnTriggerExit(){
        ballCanvas.gameObject.SetActive(false);
    }
}
