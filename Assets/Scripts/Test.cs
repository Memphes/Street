using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float speedCar = 15f;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        name = "Lamborghini";
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update ()
    {
        var speed = Vector3.zero;

        speed.x = Input.GetAxis("Horizontal");
        speed.z = Input.GetAxis("Vertical");
        
        //transform.Translate(speed * Time.deltaTime * speedCar);
        _rigidbody.AddForce (speed);
    }


}
