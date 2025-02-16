using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 _direction;
    private SpriteRenderer _spriteRenderer;
    private int _spriteIndex;

    public Sprite[] sprites;
    public float gravity = -8.0f;
    public float strength = 5f;


    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateBird),0.15f,0.15f);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            _direction = Vector3.up * strength;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                _direction = Vector3.up * strength;
            }
        }

        _direction.y += gravity * Time.deltaTime;  // Gravity => meter per sec sq

        transform.position += _direction * Time.deltaTime;
    }

    private void AnimateBird() {
        _spriteIndex++;

        if(_spriteIndex >= sprites.Length) {
            _spriteIndex = 0;
        }

        _spriteRenderer.sprite = sprites[_spriteIndex];
    }
}
