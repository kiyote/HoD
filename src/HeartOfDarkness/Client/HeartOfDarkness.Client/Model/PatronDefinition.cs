namespace HeartOfDarkness.Client.Model;

public record PatronDefinition(
	ImageDefinition Image,
	string PatronId,
	string Institution,
	string Description
);
