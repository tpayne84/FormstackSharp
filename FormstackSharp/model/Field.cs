using Newtonsoft.Json;

namespace FormstackSharp
{
	/// <summary>
	/// Base Field class.
	/// </summary>
	public abstract class Field
	{
		/// <summary>
		/// Unique Field ID.
		/// </summary>
		[JsonProperty("id")]
		public int ID { get; set; }

		/// <summary>
		/// Display label.
		/// </summary>
		[JsonProperty("label")]
		public string Label{ get; set; }

		/// <summary>
		/// Attribute name.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Field element type.
		/// </summary>
		[JsonProperty("type")]
		public string Type{ get; set; }	}
}