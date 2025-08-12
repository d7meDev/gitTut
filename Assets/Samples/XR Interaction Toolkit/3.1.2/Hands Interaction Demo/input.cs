using UnityEngine;
using UnityEngine.InputSystem;
    
public class input : MonoBehaviour
{
   public InputActionProperty action1;
    public GameObject a1;
    public AudioSource a2;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (action1.action.WasPressedThisFrame())
        {   
            a1.SetActive(false);
            a2.Play();
        }
        
    }
}
