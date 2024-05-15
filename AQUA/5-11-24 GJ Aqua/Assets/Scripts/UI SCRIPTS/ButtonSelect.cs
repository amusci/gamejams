using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class ButtonSelect : MonoBehaviour
{
    public Button primaryButton;

    // Start is called before the first frame update
    void Start()
    {
        SelectPrimaryButtonIfNoneSelected();
    }

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.current != null && EventSystem.current.currentSelectedGameObject == null && Input.anyKeyDown && !Input.GetMouseButtonDown(0) && !Input.GetMouseButtonDown(1))
        {
            primaryButton.Select();
        }
    }

    void SelectPrimaryButtonIfNoneSelected()
    {
        if (EventSystem.current != null && EventSystem.current.currentSelectedGameObject == null)
        {
            primaryButton.Select();
        }
    }
}
