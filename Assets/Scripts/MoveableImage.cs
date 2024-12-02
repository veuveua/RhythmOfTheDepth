using UnityEngine;

public class MoveableImage : MonoBehaviour
{
    // GameObject türünü belirlemek için
    public string arrowType;
     private ScoreManager scoreManager;

     void Start(){
        GameObject scoreManagerObject = GameObject.FindWithTag("ScoreManager");
     }

    void Update()
    {
        // Ok tuşlarına basıldığında, yalnızca uygun arrowType'a sahip GameObject'i yok et
        if (Input.GetKeyDown(KeyCode.UpArrow) && arrowType == "UpArrow")
        {
            DestroyImage();

            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && arrowType == "DownArrow")
        {
            DestroyImage();

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && arrowType == "LeftArrow")
        {
            DestroyImage();

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && arrowType == "RightArrow")
        {
            DestroyImage();

        }
    }

    // Bu fonksiyon, objeyi yok eder
    private void DestroyImage()
    {
        Destroy(gameObject);
    }
}