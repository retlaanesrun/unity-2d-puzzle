using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    AudioSource aSource;
    bool musicPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        // AudioSource bileþenini al
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // yonetici.Instance'ýn null olup olmadýðýný kontrol et
        if (yonetici.Instance != null && yonetici.Instance.GameOver)
        {
            aSource.Stop();
            return;
        }

        // Her frame'de 'A' tuþuna basýldýðýný kontrol et
        if (Input.GetKeyDown(KeyCode.A))
        {
            // AudioSource'un durumunu deðiþtir (Pause/Unpause)
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
