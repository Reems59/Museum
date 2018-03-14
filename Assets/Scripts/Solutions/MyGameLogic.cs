using UnityEngine;
using System.Collections;

public class MyGameLogic : MonoBehaviour
{
    public GameObject player;
    public GameObject eventSystem;
    public GameObject UI;
    public GameObject currentPoint;
    public GameObject startPos;


    void Start()
    {
        // Update 'player' to be the camera's parent gameobject, i.e. 'GvrEditorEmulator' instead of the camera itself.
        // Required because GVR resets camera position to 0, 0, 0.
        player = player.transform.parent.gameObject;

        // Move the 'player' to the 'startPoint' position.
        player.transform.position = currentPoint.transform.position;

    }

    public void MoveTo()
    {
        // Disable the UI.
        UI.SetActive(false);

        // Move the player to the play position.
        iTween.MoveTo(player,
            iTween.Hash(
                "position", currentPoint.transform.position,
                "time", 2.5,
                "easetype", "linear"
            )
        );
    }
    public void resetGame()
    {
        player.transform.position = startPos.transform.position;
        player.transform.rotation = Quaternion.Euler(Vector3.zero);
    }
    public void SetCurrentPoint(GameObject g)
    {
        currentPoint = g;
    }
    public void SetUIGameOjbect(GameObject UI)
    {
        this.UI = UI;
    }
}