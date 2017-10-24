namespace FormstackSharp
{
	/// <summary>
	/// Formstack API Resources.
	/// </summary>
    public class API
    {
		/// <summary>
		/// API Version.
		/// </summary>
		public const string Version = "v2.0";

		/// <summary>
		/// Forms API Resource.
		/// </summary>
		public Forms Forms { get; set; }

		/// <summary>
		/// Fields API Resource.
		/// </summary>
		public Fields Fields { get; set; }
	}
}