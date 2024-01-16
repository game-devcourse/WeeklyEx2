using UnityEngine;
using UnityEngine.InputSystem;

public class HideObject : MonoBehaviour
{
    [Tooltip("hide the object")]
    [SerializeField] InputAction hide = new InputAction(type: InputActionType.Button);

    private Vector3 initialScale;
    private int countClicks = 0;
    void OnEnable()  
    {
        hide.Enable();
    }

    void OnDisable()  
    {
        hide.Disable();
    }

    void Start()
    {
        initialScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (hide.WasPressedThisFrame()) 
        {
            countClicks++;
            if(countClicks % 2 == 0)
                transform.localScale = initialScale;
            else
                transform.localScale = new Vector3(0,0,0);
    }
    }
}