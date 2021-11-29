using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour
{
    [SerializeField] private InputField _inputText;
    [SerializeField] private Text _viewText;
 

    
    private void Update()
    {
        _viewText.text = _inputText.text;
    }
}
