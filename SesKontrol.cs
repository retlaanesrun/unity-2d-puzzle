using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    AudioSource aSource;
    bool musicPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        // AudioSource bile�enini al
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // yonetici.Instance'�n null olup olmad���n� kontrol et
        if (yonetici.Instance != null && yonetici.Instance.GameOver)
        {
            aSource.Stop();
            return;
        }

        // Her frame'de 'A' tu�una bas�ld���n� kontrol et
        if (Input.GetKeyDown(KeyCode.A))
        {
            // AudioSource'un durumunu de�i�tir (Pause/Unpause)
            if (musicPaused)
            {
                aSource.UnPause();
                musicPaused = false;
            }
            else
            {
                aSource.Pause();
                musicPaused = true;
            }
        }
    }
}
