using UnityEngine;
using UnityEngine.UI;

public class UI_Vidas : MonoBehaviour
{
    Text textComp;
    GameManager gm;
    void Start()
    {
        gm = GameManager.GetInstance();
        textComp = GetComponent<Text>();
    }

    void Update()
    {
        textComp.text = $"Vidas: {gm.vidas}";
    }
}