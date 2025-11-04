using UnityEngine;


// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;

    public Vector3 _playerLocation;

    private bool _chasing;

    private void Start()
    {
        _chasing = true;
    }

    private void Update()
    {
        if (_chasing)
        {
            transform.position = Vector3.MoveTowards(GetComponent<Transform>().position, _playerLocation, _speed * Time.deltaTime);
        }
    }
    public void StopChase()
    {
        _chasing = false;
    }
    
    public void StartChase()
    {
        _chasing = true;
    }
}
