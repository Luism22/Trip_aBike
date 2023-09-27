using UnityEngine;

public class Coin : MonoBehaviour
{
    // Restringe la recolección de monedas para evitar duplicados.
    private bool collected = false;

    void Update()
    {
        transform.Rotate(50 * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !collected) // Verifica que la moneda no haya sido recolectada.
        {
            FindAnyObjectByType<AudioManager>().PlaySound("PickUpCoins");
            PlayerManager.numberOfCoins += 1;
            collected = true; // Marca la moneda como recolectada para evitar duplicados.
            Destroy(gameObject);
        }
    }
}
