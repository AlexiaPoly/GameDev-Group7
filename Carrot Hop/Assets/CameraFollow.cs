using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    [SerializeField] public float smoothSpeed = 0.125f;
    //public Vector3 offset;

    void Update()
    {
        Vector2 desiredvector = new Vector2(target.position.x, target.position.y);
        transform.position = Vector2.Lerp(transform.position, desiredvector, smoothSpeed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, -10.0f);
        //Vector2 smoothedPosition = Vector2.Lerp(transform.position, desiredvector, smoothSpeed * Time.deltaTime);
        //Vector3 desiredPosition = target.position.x + offset;
        //Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        //transform.position = smoothedPosition;
    }
}
