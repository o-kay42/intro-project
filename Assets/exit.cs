using UnityEngine;

public class exit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("escape"))
        {
            Application.Quit();
            
#if UNITY_EDITOR
    UnityEditor.EditorApplication.ExitPlaymode();
#endif
        }
    }

}
