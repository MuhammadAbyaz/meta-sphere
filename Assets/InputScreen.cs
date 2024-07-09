using Photon.Pun;
using TMPro;
using UnityEngine;
using UnityEngine.Video;

public class InputScreen : MonoBehaviour
{
    [SerializeField] GameObject m_inputField;
    private TMP_InputField input;
    [SerializeField] GameObject m_button;
    [SerializeField] VideoPlayer m_player;
    void Start(){
        m_inputField.SetActive(false);
        m_button.SetActive(false);
    }
    
    void OnTriggerEnter(Collider other){
        PhotonView photonView = other.GetComponent<PhotonView>();
        if (photonView.IsMine){
            m_inputField.SetActive(true);
            m_button.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        PhotonView photonView = other.GetComponent<PhotonView>();
        if (photonView.IsMine){
            m_inputField.SetActive(false);
            m_button.SetActive(false);
        }
    }
    private void PlayVideo(string url){
        string baseUrl = "https://drive.google.com/uc?export=download&id=";
        baseUrl+= url.Split("/").GetValue(5); 
        m_player.url = baseUrl;
        m_player.Play();
    }
    public void OnClick(){
        input = m_inputField.GetComponent<TMP_InputField>();
        string url = input.text;
        input.text = string.Empty;
        PlayVideo(url);
    }
}
