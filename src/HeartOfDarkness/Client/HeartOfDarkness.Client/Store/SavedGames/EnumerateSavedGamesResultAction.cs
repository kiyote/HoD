﻿namespace HeartOfDarkness.Client.Store.SavedGames;

public record EnumerateSavedGamesResultAction(
	IEnumerable<SavedGame> Games
) {
}
