namespace Planlegger.model
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public string description { get; set; }
        public string time { get; set; }

        public TaskItem (string description, string time) : this ()
        {
            this.description = description;
            this.time = time;
        }
        public TaskItem() 
        {
            Id = Guid.NewGuid();
        }
    }
}
