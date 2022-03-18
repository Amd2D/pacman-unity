using UnityEngine;

public class Pacman : Mouvement
{
    void FixedUpdate()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(speed * x, speed * y);
        transform.Translate(movement);
    }
}
