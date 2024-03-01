public class ReflectionActivity : Activity{
    public ReflectionActivity(string activityName, string description) : base(activityName, description) {
        __activityName = activityName;
        __description = description;
    }
}