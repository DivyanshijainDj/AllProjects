// See https://aka.ms/new-console-template for more information
Console.WriteLine("Interface Exercise");
Console.WriteLine();


WorkFlow workflow = new WorkFlow();
workflow.AddActivity(new Upload());
workflow.AddActivity(new Video());
workflow.AddActivity(new Email());


WorkFlowEngine engine = new WorkFlowEngine(workflow);
engine.Run();



public interface IActivity
{
	void Execute();
}

		
	
