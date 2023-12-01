using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_activation : MonoBehaviour
{
    public GameObject button;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        button.gameObject.SetActive(true);
    }
}
