using UnityEngine;

public class CoinMovement : MonoBehaviour,IMovable
{
    private MoveController<IMovable> _moveController;
    private Vector2 _dir;
    private Rigidbody2D _rgb;
    [SerializeField] private float speed;
    
    private void Awake()
    {
        _moveController = new MoveController<IMovable>();
        _rgb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _moveController.MoveObject(this);
    }
    public void Move()
    {
        _dir = Vector2.down*speed;
        _rgb.MovePosition(_rgb.position+_dir*Time.fixedDeltaTime);
    }
}
