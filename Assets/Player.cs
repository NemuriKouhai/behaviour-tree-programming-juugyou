using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int HP;
    public float Speed = 10f;

    public Transform enemy;
    public float score;

    public Text txt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0) { txt.text = "score:" + score.ToString("F1") + "\n" + "u die";  Destroy(gameObject); return; }
        if (Vector3.Distance(transform.position, enemy.position) <= 3f) score += Time.deltaTime * 10;

        txt.text = "score:"+score.ToString("F1")+"\n" + "life:"+HP;
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(x, 0, y).normalized * Speed * Time.deltaTime);
    }
}
