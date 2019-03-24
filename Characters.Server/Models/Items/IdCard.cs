using IgiCore.Inventories.Server.Models;
using NFive.SDK.Core.Helpers;
using NFive.SDK.Core.Models.Player;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IgiCore.Characters.Server.Models.Items
{
	[Table("IdCards")]
	public class IdCard : Storable
	{
		[ForeignKey("User")]
		public Guid UserId { get; set; }

		public virtual User User { get; set; }

		public IdCard()
		{
			this.Id = GuidGenerator.GenerateTimeBasedGuid();
			this.StorageWeight = 1;
			this.StorageSlots = 1;
		}
	}
}
