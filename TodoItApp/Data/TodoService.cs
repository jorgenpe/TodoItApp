using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoItApp.Models;

namespace TodoItApp.Data
{
    public class TodoService
    {
        private static Todo[] todos = new Todo[0];

        public int Size()
        {
            return todos.Length;
        }

        public Todo[] FindAll()
        {
            return todos;
        }

        public Todo FindById(int todoId)
        {
            for(int i = 0; i < todos.Length; i++)
            {
                if(todos[i].TodoId == todoId)
                {
                    return todos[i];
                }
            }
            return null;
        }

        public Todo CreateTodoItem(String description, bool done, Person assignee)
        {
            Todo todo = new Todo(TodoSequencer.NextTodoId(), description, done, assignee);
            Array.Resize<Todo>(ref todos, todos.Length + 1);
            todos[todos.Length - 1] = todo;
            return todo;
        }

        public Todo CreateTodoItem(String description)
        {
            Todo todo = new Todo(TodoSequencer.NextTodoId(), description);
            Array.Resize<Todo>(ref todos, todos.Length + 1);
            todos[todos.Length - 1] = todo;
            return todo;
        }

        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            Todo[] tempTodo = new Todo[0];
            for(var i = 0;i < todos.Length; i++)
            {
                if(doneStatus == todos[i].Done)
                {
                    tempTodo.Append(todos[i]);
                }
            }
            return tempTodo;
        }

        public Todo[] FindByAssignee(int personId)
        {
            Todo[] tempTodo = new Todo[0];
            for(int i = 0; i < todos.Length; i++)
            {
                if(personId == todos[i].Assignee.PersonId)
                {
                    Array.Resize<Todo>(ref tempTodo, tempTodo.Length + 1);
                    tempTodo[tempTodo.Length-1] = todos[i];
                }
            }
            return tempTodo;
        }

        public Todo[] FindByAssignee(Person Assignee)
        {
            Todo[] tempTodo = new Todo[0];
            for (int i = 0; i < todos.Length; i++)
            {
                if ( todos[i].Assignee.PersonId.Equals(Assignee))
                {
                    Array.Resize<Todo>(ref tempTodo, tempTodo.Length + 1);
                    tempTodo[tempTodo.Length - 1] = todos[i];
                }
            }
            return tempTodo;
        }

        public Todo[] FindByUnAssignedTodoItems()
        {
            Todo[] tempTodo = new Todo[0];
            for (int i = 0; i < todos.Length; i++)
            {
                if (todos[i].Assignee.Equals(null))
                {
                    Array.Resize<Todo>(ref tempTodo, tempTodo.Length + 1);
                    tempTodo[tempTodo.Length - 1] = todos[i];
                }
            }
            return tempTodo;
        }

        public bool RemoveTodoItemById(int todoId)
        {
            for(int i = 0;i < todos.Length; i++)
            {
                if(todos[i].TodoId == todoId)
                {
                    todos[i] = todos[todos.Length - 1];
                    Array.Resize<Todo>(ref todos, todos.Length - 1);
                    return true;
                }
            }
            return false;
        }

        public void Clear() { todos = new Todo[0]; }

    }
}
