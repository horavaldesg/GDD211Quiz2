using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RotateMoose : MonoBehaviour
{
    public Slider rotSlider;
    public Slider colorSlider;
    public Slider sizeSlider;
    //public GameObject moose;
    Image img;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Rotate()
    {
        gameObject.transform.eulerAngles = new Vector3(0, 0, rotSlider.value);
    }

    public void ColorChange()
    {
        Color32[] Colors;


        Colors = new Color32[4];
        Colors[0] = new Color32(185, 0, 185, 255);
        Colors[1] = new Color32(0, 127, 255, 255);
        Colors[2] = new Color32(0, 0, 255, 255);
        Colors[3] = new Color32(0, 255, 255, 255);
        img.color = Colors[(int)colorSlider.value];

    }

    public void SizeChange()
    {
        gameObject.transform.localScale = new Vector2(sizeSlider.value, sizeSlider.value);
    }
}
