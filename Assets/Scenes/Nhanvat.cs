using UnityEngine;

public class Nhanvat : MonoBehaviour
{
    [SerializeField]float diChuyen = 0.1f;
    [SerializeField]float xoayTron = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float changeSteer = Input.GetAxis("Horizontal") * xoayTron * Time.deltaTime;
        float changeTocDo = Input.GetAxis("Vertical") * diChuyen;
        transform.Translate(0, changeTocDo , 0);
        transform.Rotate(0,0, -changeSteer);
    }
}