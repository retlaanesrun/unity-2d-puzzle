using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ShowImageFor3Seconds : MonoBehaviour
{
    public GameObject imageObject;  // Image'i içeren GameObject, Inspector üzerinden atanacak.

    private void Start()
    {
        if (imageObject == null)
        {
            Debug.LogError("Image Object is not assigned in the inspector!");
            return;
        }

        imageObject.SetActive(true);  // Oyunun baþýnda Image objesini aktif hale getir.
        StartCoroutine(DestroyImageAfter3Seconds());
    }

    private IEnumerator DestroyImageAfter3Seconds()
    {
        yield return new WaitForSeconds(3f);  // 3 saniye bekle.
        Destroy(imageObject);  // 3 saniye sonra Image objesini yok et.
    }
}
