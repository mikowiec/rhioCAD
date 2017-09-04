import NaroPipes.Actions from NaroPipes
import NaroPipes.Constants
import Naro.Infrastructure.Interface.Constants from Infrastructure.Interface

class Test:
	_actionsGraph as ActionsGraph
	
	def SendCommandLineText(message as string):
		commandLineInput = _actionsGraph.InputContainer.Inputs[InputNames.CommandLineView]
		commandLineInput.AddData(message)

	def Do(actionsGraph as ActionsGraph):
		_actionsGraph = actionsGraph
		_actionsGraph.SwitchAction(ModifierNames.Line3D)
		SendCommandLineText("100, 100, 0")
		SendCommandLineText("100, 200, 0")
