using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TestMain : MonoBehaviour {
	string[] names = { "Marta", "John", "Lexys", "Nancy" };
	List<string> resultList = new List<string>();

	void Start () {
		Root ();
	}
	void Root(){
//		List<string> query = names.Where (x => x.Contains ("a")).Select(x => x.ToUpper()).ToList ();


		List<string> query = 
			(
				from n in names
	          	where n.Contains ("a")
	         	select n.ToUpper ()
			).ToList ();

		foreach (string element in query) {
			Debug.Log (element);
		}
	}

	void Technic(){
		foreach (string element in names) {
			if (element.Contains ("a")) {
				resultList.Add (element.ToUpper ());
			}
		}
		
		foreach (string element in resultList) {
			Debug.Log (element);
		}
	
	}
}