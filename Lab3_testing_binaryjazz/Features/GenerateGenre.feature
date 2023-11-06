Feature: GenerateGenre

@mytag
Scenario: Generate genre of binaryjazz music
	When send Generate genre request
	Then genre is succussfully generated