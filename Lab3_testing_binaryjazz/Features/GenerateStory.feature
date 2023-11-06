Feature: GenerateStory

@mytag
Scenario: Generate story about binaryjazz music
	When send Generate story request
	Then story is succussfully generated