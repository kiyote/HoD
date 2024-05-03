using System.ComponentModel.DataAnnotations;

namespace HeartOfDarkness.Client.Model;

public class NewGame {

	public NewGame() {
		PlayerCount = 1;
		Resources = new Dictionary<string, int>();
		Colour = "";
	}

	[Required( ErrorMessage = "You must select a port of entry." )]
	public string? PortOfEntry { get; set; }

	[Required( ErrorMessage = "You must select a patron." )]
	public string? Patron { get; set; }

	public IDictionary<string, int> Resources { get; }

	public int PlayerCount { get; set; }

	[Required( ErrorMessage = "You must select a colour." )]
	public string Colour { get; set; }
}
