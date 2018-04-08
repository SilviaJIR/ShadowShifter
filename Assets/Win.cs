using UnityEngine;
using UnityEditor;

public class Win : MonoBehaviour
{
    public GameObject outline;
    private ShadowDetect.ShadowDetect shadowScript;


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
            
        }
    }

}