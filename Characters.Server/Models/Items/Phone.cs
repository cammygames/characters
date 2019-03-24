using IgiCore.Inventories.Server.Models;
using NFive.SDK.Core.Helpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace IgiCore.Characters.Server.Models.Items
{
	[Table("Phones")]
	public class Phone : Storable
	{
		public string Number { get; set; }

		public Phone()
		{
			this.Id = GuidGenerator.GenerateTimeBasedGuid();
			this.StorageWeight = 1;
			this.StorageSlots = 1;
		}
	}
}
