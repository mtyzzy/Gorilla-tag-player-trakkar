private void checkIds()
{
	foreach (Player plr in PhotonNetwork.PlayerList)
	{
		this.checkSpecificPlayer(plr);
	}
}
