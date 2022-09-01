using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float speedCar = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        name = "Lamborghini";
    }

    void Update ()
    {
        var speed = Vector3.zero;

        speed.x = Input.GetAxis("Horizontal");
        speed.z = Input.GetAxis("Vertical");
        
        transform.Translate(speed * Time.deltaTime * speedCar);
    }


}
