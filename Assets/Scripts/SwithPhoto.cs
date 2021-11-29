using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwithPhoto : MonoBehaviour
{
    [SerializeField] private Dropdown _dropdown;
    [SerializeField] private GameObject _image;
    [SerializeField] private GameObject _date;


    public void DropdownToPhoto(int num)
    {
        if (num == 0)
        {
            _image.SetActive(true);
            _date.SetActive(false);
        }else if (num == 1)
        {
            _image.SetActive(false);
            _date.SetActive(true);
        }
    }
}
