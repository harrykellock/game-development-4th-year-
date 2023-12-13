using UnityEngine;

public class PlayerMovemnet : MonoBehaviour
{
[SerializeField] private Transform playerTransform;
[SerializeField] private float limitValue;


  void Start() {
    Time.timeScale = 1;
    
  }

    void Update() 
    {

        if(Input.GetMouseButton(0))
        {
          MovePlayer();
        }
        
    }

    private void MovePlayer()
    {
////shows where x player needs to be  and move him there 
    float halfScreen = Screen.width / 2;
      float xPos = (Input.mousePosition.x - halfScreen) / halfScreen;
      float finalXpos = Mathf.Clamp(xPos * limitValue, -limitValue, limitValue);

      playerTransform.localPosition = new Vector3(finalXpos, 0.2f, 0);

    
    }
}
