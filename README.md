# Project

A card game that implements a card counting AI. 

![My App](./app.png)

## WALKTHROUGH

The computer plays itself in a card game. PlayerOne is programmed with the ability to count cards and uses it to determine whether to bet, fold, or double-down. Game stats will be saved over time to test the effectiveness of the card counting algorithm. 

A database stores the results of each game over time: game, winner, how many rounds were played. 

## OPEN REQUIREMENTS

Create Deck
Shuffle Deck
Deal Cards
Play
PlayerOne decides whether to double-down or fold during a tie.
PlayerTwo always doubles-down. 


## USER INTERFACE

User selects which game to play and how many rounds. Results of the game are shown and the aggregated result of all previous game stats are shown. 

Add multiple deck option.

## LOGIC DESIGN

- Deck
- Shuffle
- Deal
- Draw
- RequestCard
- Discard

## DATA DESIGN

Playing Card
	suit - int

	value - int

Records
	Game - str

	Winner - str

	Date - datetime
