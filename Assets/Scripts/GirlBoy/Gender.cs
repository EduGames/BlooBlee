using UnityEngine;
using System.Collections;

public static class Gender {
	public enum Type
	{
		Male,
		Female
	};

	static string GenderPrefs = "Player Gender";

	static public Gender.Type GetCurrent(){
		switch (PlayerPrefs.GetString(GenderPrefs)) {
		case "Male":
			return Type.Male;
		case "Female":
			return Type.Female;
		default:
			return Type.Female;
		}
	}

	static public void SetCurrent(Gender.Type type){
		PlayerPrefs.SetString(GenderPrefs, type.ToString());
	}
}
