using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public int number;
    public GameObject player;
    bool yes = true;
    bool no = false;
    void Start()
    {
        string naam = gameObject.name;
        Debug.Log(naam);
        Debug.Log(gameObject.transform.position);
        Debug.LogError("Silvan");
    }

    void Update()
    {

        if (no == true)
        {
            transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;
            Debug.Log("kank");
        }
        if (yes == true)
        {
            transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
            Debug.Log("kank2");
        }
        if (player.transform.position.x <= -5)
        {
            yes = true;
            no = false;
        }
        if (player.transform.position.x >= 5)
        {
            yes = false;
            no = true;
        }

    }
}
