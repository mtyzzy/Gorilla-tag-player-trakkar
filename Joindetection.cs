private static void Prefix(Player newPlayer)
{
	bool flag = newPlayer != JoinPatch.oldnewplayer;
	if (flag)
	{
		bool isTracking = Plugin.isTracking;
		if (isTracking)
		{
			JoinPatch.help.checkSpecificPlayer(newPlayer);
		}
		JoinPatch.oldnewplayer = newPlayer;
	}
}
