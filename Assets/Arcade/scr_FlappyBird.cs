using UnityEngine;

public class scr_FlappyBird : MonoBehaviour
{
    public Canvas flappyCanvas;
    void Start()
    {
       flappyCanvas.gameObject.SetActive(false);
    }
    void OnTriggerEnter(){
        flappyCanvas.gameObject.SetActive(true);
    }
    void OnTriggerExit(){
        flappyCanvas.gameObject.SetActive(false);
    }
}
