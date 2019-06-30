# NBA-Stars

Create a .NET console application that returns the upcoming super stars of the NBA. The
application should receive a list of NBA players and filter criteria. The application should
generate a file that contains only the players that satisfy the provided filters.
The application should receive the following command-line arguments:
● The path to the JSON file that contains the list of basketball players. The format of the
data should be:
[
	{
		"Name" : "Luka Doncic" ,
		"PlayingSince" : 2018,
		"Position" : "SG" ,
		"Rating" : 87
	},
	{
		"Name" : "Thomas Welsh" ,
		"PlayingSince" : 2018,
		"Position" : "C" ,
		"Rating" : 67
	},
	{
		"Name" : "Trae Young" ,
		"PlayingSince" : 2018,
		"Position" : "PG" ,
		"Rating" : 84
	},
	{
		"Name" : "Stephen Curry" ,
		"PlayingSince" : 2009,
		"Position" : "PG" ,
		"Rating" : 95
	},
	{
		"Name" : "Giannis Antetokounmpo" ,
		"PlayingSince" : 2012,
		"Position" : "SF" ,
		"Rating" : 96
	},
	{
		"Name" : "Jayson Tatum" ,
		"PlayingSince" : 2017,
		"Position" : "SF" ,
		"Rating" : 84
	},
	{
		"Name" : "LeBron James" ,
		"PlayingSince" : 2003,
		"Position" : "SF" ,
		"Rating" : 96
	}
]

● The maximum number of years the player has played in the league to qualify.
● The minimum rating the player should have to qualify.
● The path to the CSV (comma separated value) file that will be generated.

The generated report should contain only players that:
● have a rating that is equal to or greater than the provided minimum rating;
● have played in the NBA less or equal to the provided maximum years.

The generated report should contain the name and the rating of the players. Players should be
ordered by their rating in descending order. The data should be saved in a CSV (comma
separated value) file with the following structure:
	Name,Rating
	Joel Embiid, 93
	Ben Simmons, 88