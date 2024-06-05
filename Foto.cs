using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foto : MonoBehaviour
{

    public GameObject imageObject;  // Image'i i�eren GameObject, Inspector �zerinden atanacak.

    private void Start()
    {
        if (imageObject == null)
        {
            Debug.LogError("Image Object is not assigned in the inspector!");
            return;
        }

        imageObject.SetActive(true);  // Oyunun ba��nda Image objesini aktif hale getir.
        StartCoroutine(DestroyImageAfter3Seconds());
    }

    private IEnumerator DestroyImageAfter3Seconds()
    {
        yield return new WaitForSeconds(1f);  // 3 saniye bekle.
        Destroy(imageObject);  // 3 saniye sonra Image objesini yok et.
    }
}
