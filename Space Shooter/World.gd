extends Node

var score = 0 setget set_score
onready var scoreLabel = $Score

func set_score(value):
	score = value
	scoreLabel.text = "score = " + str(score)


	
