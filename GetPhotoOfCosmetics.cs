private string GetPhotoOfCosmetic(string name)
{
	string result;
	if (!(name == "FINGER PAINTER BADGE"))
	{
		if (!(name == "MOD STICK"))
		{
			if (!(name == "COLD MONKE SWEATER"))
			{
				if (!(name == "ADMINISTRATOR BADGE"))
				{
					if (!(name == "ILLUSTRATOR BADGE"))
					{
						result = this.unk;
					}
					else
					{
						result = this.illustrator;
					}
				}
				else
				{
					result = this.admin;
				}
			}
			else
			{
				result = this.sweater;
			}
		}
		else
		{
			result = this.mod;
		}
	}
	else
	{
		result = this.fingerpainter;
	}
	return result;
}
