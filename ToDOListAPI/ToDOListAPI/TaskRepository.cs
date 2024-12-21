using Microsoft.EntityFrameworkCore;
using ToDOListAPI.Models;

namespace ToDOListAPI
{
    public class TaskRepository
    {
        public TaskContext Context;

        public TaskRepository(TaskContext db)
        {
            Context = db;
        }


        public List<Models.Task> GetAllTasks()
        {
            return Context.Tasks.ToList();
        }

        public Models.Task GetTaskById(string id)
        {
            return Context.Tasks.SingleOrDefault(t => t.Id == id);
        }

        public void Add(Models.Task task)
        {
            Context.Tasks.Add(task);
            Context.SaveChanges();
        }

        public void Update(Models.Task task)
        {
            Context.Tasks.Update(task);
            Context.SaveChanges();
        }

        public void Delete(string id)
        {
            Models.Task task = Context.Tasks.SingleOrDefault(task => task.Id == id);
            if (task != null)
            {
                Context.Tasks.Remove(task);
                Context.SaveChanges();
            }
        }
    }
}
