using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatButtonSctript : MonoBehaviour
{
    private bool opened = false;
    private RectTransform miniChat;
    private Vector3 startPosition;
    private Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        miniChat = transform.parent.GetComponent<RectTransform>();
        startPosition = miniChat.position;
        newPosition = startPosition;
    }

    void Update()
    {
        miniChat.position = Vector3.Lerp(miniChat.position, newPosition, 0.2f);
    }
    

    public void onClick()
    {
        Vector3[] pos = new Vector3[4];
        miniChat.GetWorldCorners(pos);
        if (!opened)
        {
            opened = true;
            newPosition = miniChat.position - new Vector3(pos[0].x, 0, 0);
        }
        else
        {
            opened = false;
            newPosition = startPosition;
        }
        Debug.Log(pos[0] + " " + pos[1] + " " + pos[2] + " " + pos[3]);
    }
}
