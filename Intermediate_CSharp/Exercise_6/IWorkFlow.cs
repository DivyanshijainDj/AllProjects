// See https://aka.ms/new-console-template for more information



public interface IWorkFlow
{
	void AddActivity(IActivity activity);
	void RemoveActivity(IActivity activity);
	IEnumerable<IActivity> GetActivities();
}

		
	
