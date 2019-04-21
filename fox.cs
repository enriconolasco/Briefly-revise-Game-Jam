using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fox : Player2DController
{
    public GameObject fartInstance2;
    public GameObject fart2;

    public GameObject shine;
    public GameObject shineInstance;

    bool canShine = true;

    public override void Update()
    {
        Fart2();
        base.Update();
    }

    public override void Jump()
    {
        if ((Input.GetKeyDown(KeyCode.I) && isPlayer1) || (Input.GetKeyDown(KeyCode.W) && !isPlayer1))
        {
            if (numberOfJumps > 0)
            {
                //asrce.PlayOneShot(jumpAudio, 0.7F);
                rb.AddForce(Vector2.up * jumpHeight);
                numberOfJumps--;
            }
        }
    }

    public override void Shield()
    {
        if (numberOfJumps == 2) {
            base.Shield();
        }
    }

    public override void SpecialMove()
    {
        if ((isPlayer1 && Input.GetKeyDown(KeyCode.K) && canShine && !holdingShield)
            || (!isPlayer1 && Input.GetKeyDown(KeyCode.S) && canShine && !holdingShield))
        {
            shineInstance = Instantiate(shine, transform.position, Quaternion.identity);
            shineInstance.transform.parent = gameObject.transform;
            shineInstance.GetComponent<Fart>().player = this.gameObject;
            Physics2D.IgnoreCollision(shineInstance.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            StartCoroutine(ShineDestroy());
            StartCoroutine(ShineCooldown());
        }
        if ((isPlayer1 && Input.GetKeyUp(KeyCode.K)) || (!isPlayer1 && Input.GetKeyUp(KeyCode.S)))
        {
            Destroy(shineInstance.gameObject);
        }
    }

    public IEnumerator ShineCooldown()
    {
        canShine = false;
        yield return new WaitForSeconds(1);
        canShine = true;
    }

    public IEnumerator ShineDestroy()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        Destroy(shineInstance.gameObject);
    }

    public override void Fart()
    {
        //Uair
        if ((isPlayer1 && Input.GetKeyDown(KeyCode.J)) && Input.GetKey(KeyCode.UpArrow) && numberOfJumps != 2 
            || (!isPlayer1 && Input.GetKeyDown(KeyCode.A)) && Input.GetKey(KeyCode.F) && numberOfJumps != 2)
        {
            fartInstance = Instantiate(fart, new Vector3(transform.position.x, transform.position.y + 0.8f, transform.position.z), Quaternion.identity);
            fartInstance.transform.parent = gameObject.transform;
            fartInstance.GetComponent<SpriteRenderer>().flipY = true;
            fartInstance.GetComponent<Fart>().player = this.gameObject;
            Physics2D.IgnoreCollision(fartInstance.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            StartCoroutine(FartCooldown());
        }
        if ((isPlayer1 && Input.GetKeyUp(KeyCode.J)) || (!isPlayer1 && Input.GetKeyUp(KeyCode.A)))
        {
            Destroy(fartInstance.gameObject);
        }
    }

    public void Fart2()
    {
        //nair
        if ((isPlayer1 && Input.GetKeyDown(KeyCode.J)) && !Input.GetKey(KeyCode.UpArrow) && numberOfJumps != 2
            || (!isPlayer1 && Input.GetKeyDown(KeyCode.A)) && !Input.GetKey(KeyCode.F) && numberOfJumps != 2)
        {
            if (facingForward)
            {
                fartInstance2 = Instantiate(fart2, new Vector3(transform.position.x + 0.5f, transform.position.y - 0.5f, transform.position.z), Quaternion.identity);
                fartInstance2.GetComponent<SpriteRenderer>().flipX = true;                
            }
            else {
                fartInstance2 = Instantiate(fart2, new Vector3(transform.position.x - 0.5f, transform.position.y - 0.5f, transform.position.z), Quaternion.identity);
            }
            Physics2D.IgnoreCollision(fartInstance2.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            fartInstance2.transform.parent = gameObject.transform;
            fartInstance2.GetComponent<Fart>().player = this.gameObject;
            StartCoroutine(FartCooldown2());
        }
        if ((isPlayer1 && Input.GetKeyUp(KeyCode.J)) || (!isPlayer1 && Input.GetKeyUp(KeyCode.A)))
        {
            Destroy(fartInstance2.gameObject);
        }
    }

    public IEnumerator FartCooldown2()
    {
        //nair
        yield return new WaitForSecondsRealtime(0.3f);
        Destroy(fartInstance2.gameObject);
    }

    public override IEnumerator FartCooldown()
    {
        //uair
        yield return new WaitForSecondsRealtime(0.3f);
        Destroy(fartInstance.gameObject);
    }

    public override void Shoot()
    {
        if (facingForward)
        {
            //asrce.PlayOneShot(shootAudio, 0.7F);
            GameObject proj = Instantiate(projectile, new Vector3(transform.position.x + 2.3f, transform.position.y, transform.position.z), Quaternion.identity);
            proj.GetComponent<Rigidbody2D>().AddForce(Vector2.right * shootForce);
            StartCoroutine(Cooldown());
        }
        else
        {
            //asrce.PlayOneShot(shootAudio, 0.7F);
            GameObject proj = Instantiate(projectile, new Vector3(transform.position.x - 2.3f, transform.position.y, transform.position.z), Quaternion.identity);
            proj.GetComponent<SpriteRenderer>().flipX = true;
            proj.GetComponent<Rigidbody2D>().AddForce(Vector2.left * shootForce);
            StartCoroutine(Cooldown());
        }
    }
}
