using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;

    public void stopChasing()
    {
        gameObject.SetActive(false);
    }

    public void startChasing()
    {
        gameObject.SetActive(true);
    }
}
