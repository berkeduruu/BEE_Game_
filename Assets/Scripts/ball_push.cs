using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class YonluItme : MonoBehaviour
{
    public float forceMagnitudeZ = 15f;
    public float forceMagnitudeY = 10f;

    public Vector3 pushDirection = new Vector3(0, 1, 1);

    public bool useLocalDirection = true;

    private Rigidbody object_rb;
    private GameManager gamemanager;

    void Start()
    {
        object_rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(0);
        }
    }
}