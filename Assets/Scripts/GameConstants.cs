using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConstants {
	#if UNITY_ANDROID 
	public static string FB_LINK_SHARE_URL = "market://details?id=com.dtlabs.roundrush";
	#elif UNITY_IPHONE
	public static string FB_LINK_SHARE_URL = "itms-apps://itunes.apple.com/app/idcom.dtlabs.roundrush";
	#endif
}
