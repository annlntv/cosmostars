using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость движения персонажа
    public float screenLimitX = 4f; // Границы по оси X
    private Rigidbody2D rb;
    public int points;

    [SerializeField] Projectile _projectile;
    [SerializeField] float shootTimer;
    [SerializeField] float shootInterval;
    [SerializeField] Transform shootPoint;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        shootTimer -= Time.deltaTime;
        Shoot();
    }
    void Shoot()
    {
        if (_projectile != null & shootTimer <= 0)
        {
            Instantiate(_projectile, shootPoint.position, Quaternion.identity);
            shootTimer = shootInterval;

        }
    }
    void Move()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        // Движение влево или вправо
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

        // Ограничение движения персонажа по горизонтали
        Vector2 position = transform.position;
        position.x = Mathf.Clamp(position.x, -screenLimitX, screenLimitX);
        transform.position = position;

        // Проверка, нажата ли клавиша "A" или "D"
        if (horizontalInput < 0)
        {
            // Движение влево
            transform.localScale = new Vector3(-1f, 1f, 1f); // Поворот спрайта персонажа влево
        }
        else if (horizontalInput > 0)
        {
            // Движение вправо
            transform.localScale = new Vector3(1f, 1f, 1f); // Поворот спрайта персонажа вправо
        }
    } 
}