using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConstants {
	#if UNITY_ANDROID 
	public static string FB_LINK_SHARE_URL = "market://details?id=com.dtlabs.roundrush";
	public static string LEADERBOARD_ID = GPGSIds.leaderboard_comroundrushleaderboard;
	#elif UNITY_IPHONE
	public static string FB_LINK_SHARE_URL = "itms-apps://itunes.apple.com/app/idcom.dtlabs.roundrush";
	public static string LEADERBOARD_ID = "com.roundrush.leaderboard";
	#endif


}
