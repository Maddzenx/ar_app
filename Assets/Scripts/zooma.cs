using UnityEngine;
using System.Collections;

public class zooma : MonoBehaviour 
{
	private float scale_factor= 0.2f;   
	private float MAXSCALE = 20f, MIN_SCALE = 10f; // zoom-in and zoom-out limits
	private bool isMousePressed;
	private Vector2 prevDist = new Vector2(0,0);
	private Vector2 curDist = new Vector2(0,0);
	private Vector2 midPoint = new Vector2(0,0);
	private Vector2 ScreenSize;
	private Vector3 originalPos;
	private GameObject parentObject;
	
	void Start () 
	{
		// Game Object will be created and make current object as its child (only because we can set virtual anchor point of gameobject and can zoom in and zoom out from particular position)
		parentObject = new GameObject("ParentObject");
		parentObject.transform.parent = transform.parent;
        // Raden nedanfor avgor startpostionen
		parentObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z*3);
		transform.parent = parentObject.transform;

		ScreenSize = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,Screen.height));
		originalPos = transform.position;
		isMousePressed = false;
	}
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
			isMousePressed = true;
		else if(Input.GetMouseButtonUp(0))
			isMousePressed = false;

		// On double tap image will be set at original position and scale
		else if(Input.touchCount==1 && Input.GetTouch(0).phase == TouchPhase.Began && Input.GetTouch(0).tapCount==2)
		{
			parentObject.transform.localScale = Vector3.one;
			parentObject.transform.position = new Vector3(originalPos.x, originalPos.y, originalPos.z);
			transform.position = originalPos;
		}	
		checkForMultiTouch();
	}

	// Following method check multi touch 
	private void checkForMultiTouch()
	{
		// These lines of code will take the distance between two touches and zoom in - zoom out at middle point between them
		if (Input.touchCount == 2 && Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(1).phase == TouchPhase.Moved) 
		{
			midPoint = new Vector2(((Input.GetTouch(0).position.x + Input.GetTouch(1).position.x)/2), ((Input.GetTouch(0).position.y + Input.GetTouch(1).position.y)/2));
			midPoint = Camera.main.ScreenToWorldPoint(midPoint);
			
			curDist = Input.GetTouch(0).position - Input.GetTouch(1).position; //current distance between finger touches
			prevDist = ((Input.GetTouch(0).position - Input.GetTouch(0).deltaPosition) - (Input.GetTouch(1).position - Input.GetTouch(1).deltaPosition)); //difference in previous locations using delta positions
			float touchDelta = curDist.magnitude - prevDist.magnitude;
			// Zoom out
			if(touchDelta>0)
			{
				if(parentObject.transform.localScale.x < MAXSCALE && parentObject.transform.localScale.y < MAXSCALE)
				{
					Vector3 scale = new Vector3(parentObject.transform.localScale.x + scale_factor, parentObject.transform.localScale.y + scale_factor, parentObject.transform.localScale.z + scale_factor);
					scale.x = (scale.x > MAXSCALE) ? MAXSCALE : scale.x;
					scale.y = (scale.y > MAXSCALE) ? MAXSCALE : scale.y;
					scale.z = (scale.z > MAXSCALE) ? MAXSCALE : scale.z;
					scaleFromPosition(scale,midPoint);
				}
			}
			//Zoom in
			else if(touchDelta<0)
			{
				if(parentObject.transform.localScale.x > MIN_SCALE && parentObject.transform.localScale.y > MIN_SCALE)
				{
					Vector3 scale = new Vector3(parentObject.transform.localScale.x + scale_factor*-1, parentObject.transform.localScale.y + scale_factor*-1, parentObject.transform.localScale.z + scale_factor*-1);
					scale.x = (scale.x < MIN_SCALE) ? MIN_SCALE : scale.x;
					scale.y = (scale.y < MIN_SCALE) ? MIN_SCALE : scale.y;
					scale.z = (scale.z < MIN_SCALE) ? MIN_SCALE : scale.z;
					scaleFromPosition(scale,midPoint);
				}
			}
		}
	}
	//Following method scales the gameobject from particular position
	static Vector3 prevPos = Vector3.zero;
	private void scaleFromPosition(Vector3 scale, Vector3 fromPos)
	{
		if(!fromPos.Equals(prevPos))
		{
			Vector3 prevParentPos = parentObject.transform.position;
			parentObject.transform.position = fromPos;	
			Vector3 diff = parentObject.transform.position - prevParentPos;
			Vector3 pos = new Vector3(diff.x/parentObject.transform.localScale.x*-1, diff.y/parentObject.transform.localScale.y*-1, transform.position.z*-1);
			transform.localPosition = new Vector3(transform.localPosition.x + pos.x, transform.localPosition.y+pos.y, pos.z);
		}
		parentObject.transform.localScale = scale;
		prevPos = fromPos;
	}
}