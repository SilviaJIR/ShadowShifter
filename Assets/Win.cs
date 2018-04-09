using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject outline;
    private ShadowDetect.ShadowDetect shadowScript;
    public GameObject winObject;
    public GameObject winPuzzle;
    public GameObject puzzle1;


    private void Start()
    {
        shadowScript = outline.GetComponent<ShadowDetect.ShadowDetect>();
        Debug.Log("hi!");
    }

    public void CheckWin()
    {
    
        if (shadowScript.IsOnShadow_state == ShadowDetect.ShadowState.ON)
        {
            Debug.Log("Too big!");
        } else
        {
            Debug.Log("win!");
            winObject.SetActive(true);
            winPuzzle.SetActive(true);
            puzzle1.SetActive(false);
            outline.SetActive(false);
            
        }
    }

}