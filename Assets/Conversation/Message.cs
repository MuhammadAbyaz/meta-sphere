using UnityEngine;
using TMPro;

public class Message : MonoBehaviour
{
    public TextMeshProUGUI MyMessage;
    void Start()
    {
        GetComponent<RectTransform>().SetAsLastSibling();
    }
}
