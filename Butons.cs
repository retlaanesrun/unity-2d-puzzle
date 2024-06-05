using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;  // TextMeshPro kullan�yorsan�z bunu ekleyin.

public class Butons : MonoBehaviour
{
    public GameObject correctText;  // Do�ru butonuna bas�ld���nda aktif olacak metin.
    public GameObject incorrectText;  // Yanl�� butonuna bas�ld���nda aktif olacak metin.

    public Button correctButton;  // Do�ru butonu.
    public Button incorrectButton;  // Yanl�� butonu.

    private void Start()
    {
        correctText.SetActive(false);
        incorrectText.SetActive(false);

        
    }

    public void ShowCorrectText()
    {
        correctText.SetActive(true);
    }

    public void ShowIncorrectText()
    {
        incorrectText.SetActive(true);
    }
}
