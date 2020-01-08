
using UnityEngine;

public class player : MonoBehaviour
{
    public string parRUN = "跑步開關";
    public int countNeed = 10;
    public int countCurrent;

    public Animator ani;

    private void Run()
    {
        print("水平" + Input.GetAxis("Horizontal"));
        print("垂直" + Input.GetAxis("Vertical"));
        
        float h= Input.GetAxis("Horizontal");
        float v= Input.GetAxis("Vertical");
        ani.SetBool("跑步開關", h != 0 || v != 0);
    }
    private void Update()
    {
        Run();
    }
}
