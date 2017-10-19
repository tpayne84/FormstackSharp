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
		/// Should the label be hidden?
		/// </summary>
		[JsonProperty("hide_label")]
		public bool HideLabel { get; set; }

		/// <summary>
		/// Description.
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// Attribute name.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Field element type.
		/// </summary>
		[JsonProperty("type")]
		public string Type{ get; set; }

		/// <summary>
		/// Additional field options.
		/// </summary>
		[JsonProperty("options")]
		public string Options { get; set; }

		/// <summary>
		/// Default field value.
		/// </summary>
		[JsonProperty("default")]
		public string Default { get; set; }

		/// <summary>
		/// Should the field be required?
		/// </summary>
		[JsonProperty("required")]
		public bool IsRequired { get; set; }

		/// <summary>
		/// Should the field be required?
		/// </summary>
		[JsonProperty("uniq")]
		public bool IsUnique { get; set; }

		/// <summary>
		/// Should the field hidden?
		/// </summary>
		[JsonProperty("hidden")]
		public bool IsHidden { get; set; }

		/// <summary>
		/// Denotes if the field is read-only.
		/// </summary>
		[JsonProperty("readonly")]
		public bool IsReadonly { get; set; }

		/// <summary>
		/// Show initial flag.
		/// </summary>
		[JsonProperty("show_initial")]
		public bool ShowInitial { get; set; }

		/// <summary>
		/// Show middle flag.
		/// </summary>
		[JsonProperty("show_middle")]
		public bool ShowMiddle { get; set; }

		/// <summary>
		/// Show prefix flag.
		/// </summary>
		[JsonProperty("show_prefix")]
		public bool ShowPrefix { get; set; }

		/// <summary>
		/// Show suffux flag.
		/// </summary>
		[JsonProperty("show_suffix")]
		public bool ShowSuffix { get; set; }

		/// <summary>
		/// Text size.
		/// </summary>
		[JsonProperty("text_size")]
		public int TextSize{ get; set; }

	}
}