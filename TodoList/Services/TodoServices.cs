using TodoList.Database;
using TodoList.Models;
using TodoList.Shared;

namespace TodoList.Services
{
    public class TodoServices
    {
        static private readonly TodoListDbContext _db = new TodoListDbContext();

        static public Todo? AddTodo(TodoDto todoDto)
        {
            Todo todo=new Todo();
            try
            {
                todo.Desc=todoDto.Desc;
                todo.Title=todoDto.Title;
                todo.CreatedOn = DateTime.Now;
                todo.IsDeleted=todoDto.IsDeleted;
                todoDto.IsCompleted=todoDto.IsCompleted;
                todo.ModifyOn = DateTime.Now;
                todo.ListId=todoDto.ListId;
                _db.Todos.Add(todo);    
                _db.SaveChanges();
                return todo;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

        }

        static public List<Todo>? getAllToday(int userId)
        {
            List<Todo> todoList = new List<Todo>();
            try
            {
                todoList=_db.Lists.Where(x=>x.ListId==1&&x.UserId==userId).Select(x=>x.Todos.Where(x=>x.IsCompleted==false).ToList()).FirstOrDefault();
                if(todoList!=null)
                {
                    return todoList;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

        }

        static public List<Todo>? getAllCompleteToday(int userId)
        {
            List<Todo> todoList = new List<Todo>();
            try
            {
                todoList = _db.Lists.Where(x => x.ListId == 1 && x.UserId == userId).Select(x => x.Todos.Where(x => x.IsCompleted == true).ToList()).FirstOrDefault();
                if (todoList != null)
                {
                    return todoList;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

        }

        static public Todo? Update(Todo todoDto)
        {
            Todo todo = new Todo();
            try
            {
                todo = _db.Todos.Where(x => x.ItemId==todoDto.ItemId).FirstOrDefault();
                if( todo != null ) 
                { 
                    todo.IsCompleted= true;
                    _db.SaveChanges();
                    return todo;
                }
                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

        }
    }
}
