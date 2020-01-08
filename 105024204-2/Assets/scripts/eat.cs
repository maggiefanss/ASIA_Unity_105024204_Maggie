using UnityEngine;
using UnityEngine.UI;

public class eat : MonoBehaviour
{

    public Text textCount;
    public GameObject objTip;

    public int propCount;
    public int propTotal = 10;

    public bool finish;
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject);
        if(collision.gameObject.tag=="壽司")
        {
            Destroy(collision.gameObject);

            propCount++;
            textCount.text = "sushi" + propCount + "/10";
            if(propCount==propTotal)
            {
                finish = true;
                objTip.SetActive(true);
            }
        }
    }
    private void Update()
    {
        GameOver();
    }
    private void GameOver()
    {
        if(finish)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
}
