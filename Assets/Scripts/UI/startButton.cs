using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class startButton : MonoBehaviour
{
    public Button button;
    public GameObject Title;
    public Camera cam;
    public float speed = 3F;
    private Vector3 startPos = new Vector3(5, 8, -18);
     public Vector3 startQuant = new Vector3(10, 0, 0);
    public Vector3 endQuant = new Vector3(75, 0, 0);
    private Vector3 endPos = new Vector3(5, 11.5F, 1);


    private float elapsedTime;
    void Start()
    {
        Title.SetActive(true);
        
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(TaskOnClick); 
    }

    void TaskOnClick()
    {
        Title.SetActive(false);
        elapsedTime += Time.deltaTime;
        float percentage = elapsedTime / speed;
        cam = Camera.main;
        cam.transform.position = Vector3.Lerp(startPos, endPos, speed);
        cam.transform.rotation = Quaternion.Lerp(Quaternion.Euler(startQuant), Quaternion.Euler(endQuant), speed);
    }
}
