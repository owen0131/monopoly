Feature: Setup the game

Background: 
	Given Application is started

Scenario Outline: Start the app
	When I start the game
	And Player is prompted for how many players
	And They enter <Players>
	Then User receieves <Response>
	
	Examples: 
	| Players | Response |
	| 1       | "Fail"     |
	| 2       | "Success"  |
	| 6       | "Success"  |
	| 7       | "Fail"     |
	| 0       | "Fail"     |

Scenario: Give Player money 
	When Player is created 
	Then Their balance is $1500

Scenario: Verify Buildings
	When All players are created and they receive money
	Then The bank contains 32 houses and 12 hotels

Scenario: Assign Order
	When Number of players is selected
	Then Order is randomly assigned


Scenario: Display Image of Board
	When Game is started
	Then A monopoly board is shown

Scenario Outline: Display Board
	When the board is displayed
	Then <Location> is <Name>

	Examples:
	| Location | Name                    |
	| 1        | "GO"                    |
	| 2        | "Mediterranean Avenue"  |
	| 3        | "Community Chest"       |
	| 4        | "Baltic Avenue"         |
	| 5        | "Income Tax"            |
	| 6        | "Reading Railroad"      |
	| 7        | "Oriental Avenue"       |
	| 8        | "Chance"                |
	| 9        | "Vermont Avenue"        |
	| 10       | "Conneticut Avenue"     |
	| 11       | "Jail"                  |
	| 12       | "St. Charles Place"     |
	| 13       | "Electric Company"      |
	| 14       | "States Avenue"         |
	| 15       | "Virginia Avenue"       |
	| 16       | "Pennsyvania Railroad"  |
	| 17       | "St. James Place"       |
	| 18       | "Community Chest"       |
	| 19       | "Tennessee Avenue"      |
	| 20       | "New York Avenue"       |
	| 21       | "Free Parking"          |
	| 22       | "Kentucky Avenue"       |
	| 23       | "Chance"                |
	| 24       | "Indiana Avenue"        |
	| 25       | "Illinois Avenue"       |
	| 26       | "B & O Railroad"        |
	| 27       | "Atlantic Avenue"       |
	| 28       | "Ventnor Avenue"        |
	| 29       | "Water Works"           |
	| 30       | "Marvin Gardens"        |
	| 31       | "Go To Jail"            |
	| 32       | "Pacific Avenue"        |
	| 33       | "North Carolina Avenue" |
	| 34       | "Community Chest"       |
	| 35       | "Pennsylvania Avenue"   |
	| 36       | "Short Line"            |
	| 37       | "Chance"                |
	| 38       | "Park Place"            |
	| 39       | "Luxury Tax"            |
	| 40       | "Boardwalk"             |

Scenario Outline: Player Picks a Token
	When Order is assigned
	And Player is prompted to pick a token
	And Player enters <Token>
	Then User recieves <Event>

	Examples:
	| Token        | Event   |
	| "Battleship" | Success |
	| "Hat"        | Success |
	| "T-Rex"      | Success |
	| "Cat"        | Success |
	| "Car"        | Success |
	| "Duck"       | Success |
	| "Penguin"    | Success |
	| "Dog"        | Success |
	| "NotDog"     | Fail    |
	| ""           | Fail    |

Scenario Outline: Player selects Token
	When Player selects Token <Token>
	Then Available Tokens left are <TokensLeft>

	Examples:
	| Token        | TokensLeft                                 |
	| "Battleship" | "Hat, T-Rex, Cat, Car, Duck, Penguin, Dog" |


Scenario: Place tokens on board
	When the game is setup
	Then the board is displayed
	And All pieces are on "go"