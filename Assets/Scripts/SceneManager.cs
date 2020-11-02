using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SceneManager : MonoBehaviour {
   
    private List<string> u_ids;
    public List<GameObject> objects_;

    void Awake() {
        u_ids = new List<string>();
        objects_ = new List<GameObject>();

        for(int i = 0; i < objects_.Count; i++) {
            string id = objects_[i].GetComponent<ObjectReference>().obj_ID;
            u_ids.Add(id);
        }

        for(int i = 0; i < u_ids.Count;i++) {
            Debug.Log("SCENE OBJECT " + i + " : " + u_ids[i]);
        }
    }
    
    void  CheckForObjectChange() {

    }

    private void Update()
    {
        CheckForObjectChange();
    }


}
