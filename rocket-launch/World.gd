extends Node

onready var animationPlayer = get_node("AnimationPlayer") #$AnimationPlayer

func _ready():
	pass #animationPlayer.play("Launch")


func _on_LaunchButton_pressed():
	animationPlayer.play("Launch")
