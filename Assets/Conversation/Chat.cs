using UnityEngine;
using Photon.Pun;
using TMPro;

public class Chat : MonoBehaviour
{
    public TMP_InputField Field;
    public GameObject Message;
    public GameObject Content;
    public void SendMessage()
    {
        GetComponent<PhotonView>().RPC("GetMessage", RpcTarget.All, Field.text);
        Field.text = string.Empty;
    }
    [PunRPC]
    public void GetMessage(string RecieveMessage)
    {
        GameObject M = Instantiate(Message, Vector3.zero, Quaternion.identity, Content.transform);
        M.GetComponent<Message>().MyMessage.text = RecieveMessage;
    }
}
