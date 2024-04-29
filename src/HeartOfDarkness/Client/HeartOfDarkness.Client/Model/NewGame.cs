using System.ComponentModel.DataAnnotations;

namespace HeartOfDarkness.Client.Model;

public class NewGame {

	[Required( ErrorMessage = "You must select a port of entry." )]
	public string? PortOfEntry { get; set; }

	[Required( ErrorMessage = "You must select a patron." )]
	public string? Patron { get; set; }
}
