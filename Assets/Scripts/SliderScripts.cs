using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderScripts : MonoBehaviour
{
    PlayerMovement playerMovement;
    public GameObject player;
    public Slider speedSlider;
    public Slider jumpSlider;
    public TextMeshProUGUI sliderText1;
    public TextMeshProUGUI sliderText2;

    void Start()
    {
        playerMovement = player.GetComponent<PlayerMovement>();
        sliderText1.text = playerMovement.speed.ToString();
        sliderText2.text = playerMovement.jumpAmount.ToString();
    }

    void Update()
    {
        speedSlider.onValueChanged.AddListener((value) =>
        {
            playerMovement.speed = value;
            sliderText1.text = value.ToString();
            PlayerPrefs.SetFloat("playerspeed", value);
        });
        
        jumpSlider.onValueChanged.AddListener((value) =>
        {
            playerMovement.jumpAmount = value;
            sliderText2.text = value.ToString();
            PlayerPrefs.SetFloat("jumpamount", value);
        });
    }
}
