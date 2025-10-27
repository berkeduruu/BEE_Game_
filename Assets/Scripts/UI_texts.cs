using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class UI_texts : MonoBehaviour
{
    public TextMeshProUGUI score;
    public Transform player;

    float first_pos;

    private void Start()
    {
        first_pos = player.position.x;
    }

    void Update()
    {
        score.text = Mathf.Abs(player.position.x - first_pos).ToString("0");         
    }
}
