// See https://aka.ms/new-console-template for more information



public class WorkFlow : IWorkFlow
{
	internal IList<IActivity> _activities;

	public WorkFlow()
	{
		_activities = new List<IActivity>();
	}

	public void AddActivity(IActivity activity)
	{
		_activities.Add(activity);
	}

	public void RemoveActivity(IActivity activity)
	{
		_activities.Remove(activity);
	}

	public IEnumerable<IActivity> GetActivities()
	{
		return _activities;
	}
}

		
	
