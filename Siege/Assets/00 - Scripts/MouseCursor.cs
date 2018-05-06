using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseCursor : MonoBehaviour {

    private SpriteRenderer rend;
    public Sprite reloadSprite;
    public Sprite normalCursor;
    //private bool isReloading = false;
    public Image cursorImage;
    public Image reloadCircleImage;

    void Start()
    {
        Cursor.visible = false;
       // rend = GetComponent<SpriteRenderer>();
        cursorImage.sprite = normalCursor;

    }

    // Update is called once per frame
    void LateUpdate() {
        Vector3 cursorPos = Input.mousePosition;
        transform.position = cursorPos;
      

       //  if (isReloading == true)
         //{
       //      rend.sprite = reloadSprite;
        // } else rend.sprite = normalCursor;
  
    }
    public void Reload(float time)
    {
        StartCoroutine(ReloadRoutine(time));
    }
    IEnumerator ReloadRoutine(float time)
    {
        reloadCircleImage.enabled = true;
        cursorImage.sprite = reloadSprite;
        while (time > 0)
        {
            time -= Time.deltaTime;
            //this is where the radial thing will come alive 

        yield return null;
        }
        cursorImage.sprite = normalCursor;
    }




}
