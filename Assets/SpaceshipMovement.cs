using UnityEngine;

public class TesteMovimento : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * 5f * Time.deltaTime);
            Debug.Log("W funcionando");
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * 5f * Time.deltaTime);
            Debug.Log("S funcionando");
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 5f * Time.deltaTime);
            Debug.Log("A funcionando");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 5f * Time.deltaTime);
            Debug.Log("D funcionando");
        }
    }
}