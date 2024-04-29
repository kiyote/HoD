﻿namespace HeartOfDarkness.Client.Data;

internal sealed class SavedGameFactory : ISavedGameFactory {
	SavedGame ISavedGameFactory.CreateFromGame(
		Game game
	) {
		return new SavedGame(
			game.Id,
			game.Player
		);
	}
}