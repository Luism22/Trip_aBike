using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(50 * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            FindAnyObjectByType<AudioManager>().PlaySound("PickUpCoins");
            PlayerManager.numberOfCoins += 1;
            Destroy(gameObject);

        }
    }
}
