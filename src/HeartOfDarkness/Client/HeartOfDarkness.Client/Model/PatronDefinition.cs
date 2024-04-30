namespace HeartOfDarkness.Client.Model;

public record PatronDefinition(
	PatronImageDefinition Image,
	string PatronId,
	string Institution
);
