public void checkCosmetics(Player plr)
{
	try
	{
		bool flag = plr != PhotonNetwork.LocalPlayer;
		if (flag)
		{
			VRRig vrrigFromPlayer = Plugin.GetVRRigFromPlayer(plr);
			bool flag2 = vrrigFromPlayer != null;
			if (flag2)
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				dictionary.Add("LBAAD.", "ADMINISTRATOR BADGE");
				dictionary.Add("LBAAK.", "MOD STICK");
				dictionary.Add("LBADE.", "FINGER PAINTER BADGE");
				dictionary.Add("LBAGS.", "ILLUSTRATOR BADGE");
				dictionary.Add("LBACP.", "COLD MONKE SWEATER");
				Dictionary<string, string> dictionary2 = dictionary;
				foreach (KeyValuePair<string, string> keyValuePair in dictionary2)
				{
					bool flag3 = vrrigFromPlayer.concatStringOfCosmeticsAllowed.Contains(keyValuePair.Key);
					if (flag3)
					{
						string text = plr.NickName;
						text = new string(Array.FindAll<char>(text.ToCharArray(), (char c) => char.IsLetterOrDigit(c)));
						bool flag4 = text.Length > 12;
						if (flag4)
						{
							text = text.Substring(0, 11);
						}
						text = text.ToUpper();
						string text2 = string.Concat(new string[]
						{
							"PC ",
							Math.Round((double)(vrrigFromPlayer.playerColor.r * 255f)).ToString(),
							" ",
							Math.Round((double)(vrrigFromPlayer.playerColor.g * 255f)).ToString(),
							" ",
							Math.Round((double)(vrrigFromPlayer.playerColor.b * 255f)).ToString(),
							" // Quest ",
							Math.Round((double)(vrrigFromPlayer.playerColor.r * 9f)).ToString(),
							" ",
							Math.Round((double)(vrrigFromPlayer.playerColor.g * 9f)).ToString(),
							" ",
							Math.Round((double)(vrrigFromPlayer.playerColor.b * 9f)).ToString(),
							" "
						});
						string concatStringOfCosmeticsAllowed = vrrigFromPlayer.concatStringOfCosmeticsAllowed;
						string text3 = PhotonNetwork.NetworkingClient.CloudRegion;
						text3 = new string(Array.FindAll<char>(text3.ToCharArray(), (char c) => char.IsLetterOrDigit(c)));
						bool flag5 = text3.Length > 12;
						if (flag5)
						{
							text3 = text3.Substring(0, 11);
						}
						text3 = text3.ToUpper();
						string text4 = string.Format(Plugin.webhookMessage, new object[]
						{
							keyValuePair.Value,
							PhotonNetwork.CurrentRoom.Name,
							text,
							plr.UserId,
							text2,
							concatStringOfCosmeticsAllowed,
							text3,
							PhotonNetwork.CurrentRoom.CustomProperties["gameMode"].ToString(),
							PhotonNetwork.PlayerList.Length
						});
						Plugin.shouldPlayTaps = true;
						Debug.Log("Found someone very special\n" + text4);
						this.BetaWebhookEmbed("<@&1189695503399649280>", keyValuePair.Value + " found", text4, "Created by @goldentrophy", this.GetPhotoOfCosmetic(keyValuePair.Value));
					}
				}
				Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
				dictionary3.Add("LFAAZ.", "2022 GLASSES");
				dictionary3.Add("LMAJA.", "GT MONKE PLUSH");
				dictionary3.Add("LBAAE.", "EARLY ACCESS");
				dictionary3.Add("LBAAZ.", "GT1 BADGE");
				dictionary3.Add("HIGH TECH SLINGSHOT", "HIGH TECH SLINGSHOT");
				dictionary3.Add("STICKABLE TARGET", "STICKABLE TARGET");
				Dictionary<string, string> dictionary4 = dictionary3;
				foreach (KeyValuePair<string, string> keyValuePair2 in dictionary4)
				{
					bool flag6 = vrrigFromPlayer.concatStringOfCosmeticsAllowed.Contains(keyValuePair2.Key);
					if (flag6)
					{
						string text5 = plr.NickName;
						text5 = new string(Array.FindAll<char>(text5.ToCharArray(), (char c) => char.IsLetterOrDigit(c)));
						bool flag7 = text5.Length > 12;
						if (flag7)
						{
							text5 = text5.Substring(0, 11);
						}
						text5 = text5.ToUpper();
						string text6 = string.Concat(new string[]
						{
							"PC ",
							Math.Round((double)(vrrigFromPlayer.playerColor.r * 255f)).ToString(),
							" ",
							Math.Round((double)(vrrigFromPlayer.playerColor.g * 255f)).ToString(),
							" ",
							Math.Round((double)(vrrigFromPlayer.playerColor.b * 255f)).ToString(),
							" // Quest ",
							Math.Round((double)(vrrigFromPlayer.playerColor.r * 9f)).ToString(),
							" ",
							Math.Round((double)(vrrigFromPlayer.playerColor.g * 9f)).ToString(),
							" ",
							Math.Round((double)(vrrigFromPlayer.playerColor.b * 9f)).ToString(),
							" "
						});
						string concatStringOfCosmeticsAllowed2 = vrrigFromPlayer.concatStringOfCosmeticsAllowed;
						string text7 = PhotonNetwork.NetworkingClient.CloudRegion;
						text7 = new string(Array.FindAll<char>(text7.ToCharArray(), (char c) => char.IsLetterOrDigit(c)));
						bool flag8 = text7.Length > 12;
						if (flag8)
						{
							text7 = text7.Substring(0, 11);
						}
						text7 = text7.ToUpper();
						string webhookMessagee = string.Format(Plugin.boringWebhookMessage, new object[]
						{
							keyValuePair2.Value,
							PhotonNetwork.CurrentRoom.Name,
							text5,
							plr.UserId,
							text6,
							dictionary2,
							text7,
							PhotonNetwork.CurrentRoom.CustomProperties["gameMode"].ToString(),
							PhotonNetwork.PlayerList.Length
						});
						this.SendWebhookMessage(webhookMessagee);
					}
				}
			}
		}
	}
	catch
	{
	}
}
