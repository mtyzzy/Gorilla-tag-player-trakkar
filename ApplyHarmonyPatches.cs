internal static void ApplyHarmonyPatches()
{
	bool flag = !HarmonyPatches.IsPatched;
	if (flag)
	{
		bool flag2 = HarmonyPatches.instance == null;
		if (flag2)
		{
			HarmonyPatches.instance = new Harmony("com.goldentrophy.gorillatag.playertrakkar");
		}
		HarmonyPatches.instance.PatchAll(Assembly.GetExecutingAssembly());
		HarmonyPatches.IsPatched = true;
	}
}
