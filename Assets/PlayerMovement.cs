using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float m_speed = 4f;
    private float m_maxVelocityChange = 10f;
    private Vector2 m_input;
    private Rigidbody m_rigidBody;
    void Start()
    {
        m_rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        m_input = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        m_input.Normalize();
    }
    void FixedUpdate(){
        m_rigidBody.AddForce(CalculateMovement(m_speed),ForceMode.VelocityChange);
    }
    Vector3 CalculateMovement(float _speed){
        Vector3 targetVelocity = new Vector3(m_input.x,0,m_input.y);
        targetVelocity = transform.TransformDirection(targetVelocity);
        targetVelocity *= _speed;

        Vector3 velocity = m_rigidBody.velocity;

        if (m_input.magnitude > 0.5f){
            Vector3 velocityChange = targetVelocity - velocity;
            velocityChange.x = Mathf.Clamp(velocityChange.x,-m_maxVelocityChange,m_maxVelocityChange);

            velocityChange.z = Mathf.Clamp(velocityChange.z,-m_maxVelocityChange,m_maxVelocityChange);
            velocityChange.y = 0;
            
            return velocityChange;
        }
        else{
            return new Vector3();
        }
    }
}
