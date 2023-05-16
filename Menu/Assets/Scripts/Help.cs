using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour
{
    [SerializeField] GameObject Image;

    void Start()
    {
        Image.SetActive(false);
    }
    public void OnMouseOver()
    {
        Image.SetActive(true);
    }
    public void OnMouseExit()
    {
        Image.SetActive(false);
    }
}
