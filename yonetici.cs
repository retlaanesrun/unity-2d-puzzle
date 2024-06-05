using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonetici : MonoBehaviour
{
    public static yonetici Instance;

    int yerlestirilen_parca = 0;
    int toplam_puzzle = 9;
    public bool GameOver { get; private set; }  // GameOver �zelli�i eklendi

    void Awake()
    {
        // Singleton pattern to ensure only one instance of yonetici exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void sayi_arttir()
    {
        yerlestirilen_parca++;

        if (yerlestirilen_parca == toplam_puzzle)
        {
            Debug.Log("sonraki b�l�me ge�");
            GameOver = true;  // Oyun bitti�inde GameOver �zelli�ini true yap
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
