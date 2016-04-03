﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Booma.Stats.Common
{
	/// <summary>
	/// Enumeration of all potential stat types.
	/// </summary>
	public enum StatType : int //int prevents boxing in dictionaries and such but increased bandwidth usage
	{
		/// <summary>
		/// ATP - Attack Power
		/// </summary>
		AttackPower,

		/// <summary>
		/// DFP - Defensive Power
		/// </summary>
		DefensivePower,

		/// <summary>
		/// MST - Mental Strength
		/// </summary>
		MentalStrength,

		/// <summary>
		/// ATA - Attack Accuracy
		/// </summary>
		AttackAccuracy,

		/// <summary>
		/// EVP - Evasive Power
		/// </summary>
		EvasivePower,

		/// <summary>
		/// LCK - Luck
		/// </summary>
		Luck,

		/// <summary>
		/// HP - Hit Points
		/// </summary>
		HitPoints,

		/// <summary>
		/// TP - Technique Points
		/// </summary>
		TechniquePoints
	}
}
