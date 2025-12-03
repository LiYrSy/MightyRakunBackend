using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

// TODO: use redirect to make urls prettier on client side

var habits = new List<Habit>();
// post

app.MapPost("/todos", (Habit task) => 
{
    habits.Add(task);
    return TypedResults.Created("/todos/{id}", task);
});

// app.MapPut("/todos/{id}", (Todo task, int id) => 
// {
//     var targetTodo = todos.SingleOrDefault(t => id == t.Id);
//   if (targetTodo is not null) {
//       todos.Remove(targetTodo);
//   }
//     todos.Add(task);
//     return TypedResults.Accepted("/todos/{id}", task);
// });

// get all
app.MapGet("/todos", () => habits);

// // get one item
app.MapGet("/todos/{id}", Results<Ok <Habit>, NotFound> (string id) =>
{
    var targetTodo = habits.SingleOrDefault(t => id == t.Id);
     return targetTodo is null
     ? TypedResults.NotFound()
     : TypedResults.Ok(targetTodo);
});

app.MapDelete("/todos/{id}", (string id) =>
{
    habits.RemoveAll(t => id == t.Id);
return TypedResults.NoContent();
});

app.Run();

