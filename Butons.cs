using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;  // TextMeshPro kullanýyorsanýz bunu ekleyin.

public class Butons : MonoBehaviour
{
    public GameObject correctText;  // Doðru butonuna basýldýðýnda aktif olacak metin.
    public GameObject incorrectText;  // Yanlýþ butonuna basýldýðýnda aktif olacak metin.

    public Button correctButton;  // Doðru butonu.
    public Button incorrectButton;  // Yanlýþ butonu.

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
