using System.Runtime.CompilerServices;
using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _target;

    public void stopChasing()
    {
        gameObject.SetActive(false);
    }

    public void startChasing()
    {
        gameObject.SetActive(true);
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }

}
