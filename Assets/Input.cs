using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    public InputActionProperty primaryButton;
    public InputActionProperty secondaryButton;
    public InputActionProperty RightTrigger;
    public InputActionProperty LeftGrip;
    public TMP_Text counterView;
    int counter = 0;



    public GameObject Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*  if (primaryButton.action.WasPressedThisDynamicUpdate())
          {
              Player.transform.Translate(0,1,0);
          }

          if (secondaryButton.action.WasPressedThisDynamicUpdate())
          {
              Player.transform.Translate(0, -1, 0);
          }

          if (RightTrigger.action.WasPressedThisDynamicUpdate())
          {
              Player.transform.Translate(0, 0, 1);
          }

          if (LeftGrip.action.WasPressedThisDynamicUpdate())
          {
              Player.transform.Translate(0, 0, -1);
          }

          */

        if (RightTrigger.action.WasPressedThisFrame())
        {
            counter++;
            counterView.text = "subhan Allah: " + counter;
        }
    }
}
