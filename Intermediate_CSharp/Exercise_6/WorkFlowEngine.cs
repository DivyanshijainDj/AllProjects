// See https://aka.ms/new-console-template for more information



public class WorkFlowEngine
{
	public IWorkFlow _workFlow;

	public WorkFlowEngine(IWorkFlow workflow)
	{
		_workFlow = workflow;
	}

	public void Run()
	{
		foreach (var activity in _workFlow.GetActivities())
		{
			activity.Execute();
		}
	}
}

		
	
