using IgiCore.Characters.Server.Models;
using IgiCore.Characters.Server.Models.Items;
using NFive.SDK.Server.Storage;
using System.Data.Entity;

namespace IgiCore.Characters.Server.Storage
{
	public class StorageContext : EFContext<StorageContext>
	{
		public DbSet<Character> Characters { get; set; }

		public DbSet<CharacterSession> CharacterSessions { get; set; }

		public DbSet<IdCard> IdCards { get; set; }

		public DbSet<Phone> Phones { get; set; }
	}
}
