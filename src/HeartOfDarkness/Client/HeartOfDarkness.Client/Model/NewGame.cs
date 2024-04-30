using System.ComponentModel.DataAnnotations;

namespace HeartOfDarkness.Client.Model;

public class NewGame {

	public NewGame() {
		Resources = new Dictionary<string, int>();
	}

	[Required( ErrorMessage = "You must select a port of entry." )]
	public string? PortOfEntry { get; set; }

	[Required( ErrorMessage = "You must select a patron." )]
	public string? Patron { get; set; }

	public IDictionary<string, int> Resources { get; }
}
