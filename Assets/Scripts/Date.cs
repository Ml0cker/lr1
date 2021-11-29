using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Date : MonoBehaviour
{
    [SerializeField] private Text _date;
    private void Start()
    {
        _date.text = System.DateTime.Now.ToString("dd/MM/yyyy");
    }

    
}
