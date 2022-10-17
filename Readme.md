Name :- Harshdeep Harshdeep
Student Id :-  0788912
Date started :- 10/10/2022
Time : - 15:00 - 1800

I tried many times to run the application but my codes got error then in my 5th attempt my code succesfull.

It tooks me around 20 hours to complete the application. 

1. Create a Web App on Visual studio code.

2. Create a new project. 

3. Set Web in Project type box and click on the next.

4. Set the location of the web app in your System.

5. Part 2 Add the controller in the web app.

6. Right click on the controllers folder and click on the add, then click on the cotroller to add it.

7. Add Scaffold dialog box, select MVC Controller - Empty.

8. namespace CleanTooth.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

Date :- 10/11/2022
Time :- 1800-2000

9. Replace the Welcome method in the Controllers/HomeController.cs file

    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public string Welcome(string name, int numTimes = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }



10. Replace the Welcome method with the following code:- 

    public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }


Date:- 10/13/2022

Time:- 2000 - 2300

11. In the HomeControllers.cs class, replace the Index method with the following code:-

 public IActionResult Index()
    {
        return View();
    }

12. Part 3, add a view : - 

    Replace the HelloWorld.cs Index Method to Call the View Folder, 

    Important Note : - Index method will call only that view folder where we put the Index value in the file

    For example :- Controller/HelloWorld.cs call Views/HelloWorld/Index not the HomeController file.

  
     Wrote Code in th e Helloworld.cs :- 
     public IActionResult Index()
    {
        return View();
    }

13. Add a view ;- 

    
    Right-click on the Views folder, and then Add > New Folder and name the folder HelloWorld.

    Right-click on the Views/HelloWorld folder, and then Add > New Item.

    In the Add New Item - MvcMovie dialog:

    In the search box in the upper-right, enter view
    Select Razor View - Empty
    Keep the Name box value, Index.cshtml.
    Select Add



14. Replace the code of Views/HelloWorld/Index.cshtml

    @{
    ViewData["Title"] = "Index";
    }

    <h2>Index</h2>

    <p>Hello from our View Template!</p>

15. Change views and layout pages :- 

    Change the title, footer, and menu link in the layout file :-

    Replace the content of the Views/Shared/_Layout.cshtml file with the following markup. The changes are highlighted:- 

    <!DOCTYPE html>
    <html lang="en">
    <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        <title>@ViewData["Title"] - Movie App</title>
        <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.css" />
        <link rel="stylesheet" href="~/css/site.css" />
    </head>
    <body>
        <header>
            <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3">
                <div class="container">
                    <a class="navbar-brand" asp-controller="Movies" asp-action="Index">Movie App</a>
                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target=".navbar-collapse" aria-controls="navbarSupportedContent"
                            aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse">
                        <ul class="navbar-nav flex-grow-1">
                            <li class="nav-item">
                                <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Index">Home</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Privacy">Privacy</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </header>
        <div class="container">
            <main role="main" class="pb-3">
                @RenderBody()
            </main>
        </div>

        <footer class="border-top footer text-muted">
            <div class="container">
                &copy; 2020 - Movie App - <a asp-area="" asp-controller="Home" asp-action="Privacy">Privacy</a>
            </div>
        </footer>
        <script src="~/lib/jquery/dist/jquery.js"></script>
        <script src="~/lib/bootstrap/dist/js/bootstrap.bundle.js"></script>
        <script src="~/js/site.js" asp-append-version="true"></script>
        @RenderSection("Scripts", required: false)
    </body>
    </html>

    Date:- 10/15/2022

    Time:- 1300 - 1700

16. I added this code according to the toutril and made cahnges with the name according to my application

Open the Views/HelloWorld/Index.cshtml view file

    Change the title and <h2> element as highlighted in the following:- 

    @{
    ViewData["Title"] = "Movie List";
    }

    <h2>My Movie List</h2>

    <p>Hello from our View Template!</p>

    :-  Save the change and navigate to https://localhost:{PORT}/HelloWorld 

Date:- 10/14/2022

Time:- 1500 - 1700

17. Passing Data from the Controller to the View :-

    In HelloWorldController.cs, change the Welcome method to add a Message and NumTimes value to the ViewData dictionary:-

    using Microsoft.AspNetCore.Mvc;
    using System.Text.Encodings.Web;

    namespace MvcMovie.Controllers
    {
        public class HelloWorldController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Welcome(string name, int numTimes = 1)
            {
                ViewData["Message"] = "Hello " + name;
                ViewData["NumTimes"] = numTimes;

                return View();
            }
        }
    }
     
     [Note:-Only Change the welcome method in the HelloWorld.cs]

18. I added this code according to the toutril and made cahnges with the name according to my application
Part 4, add a model to an ASP.NET Core MVC app :- 

Add a data model class

Right-click the Models folder > Add > Class. Name the file Movie.cs.

using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}

19. I added this code according to the toutril and made cahnges with the name according to my application
Add NuGet packages :- 

Add a Data/MvcMovieContext.cs file with the following code:-

using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}

20. Register the database context ;- 

Add the following highlighted code in Startup.ConfigureServices:

public void ConfigureServices(IServiceCollection services)
{
    services.AddControllersWithViews();

    services.AddDbContext<MvcMovieContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("MvcMovieContext")));
}

21.I added this code according to the toutril and made cahnges with the name according to my application 
Examine the database connection string
Add a connection string to the appsettings.json file:

{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "MvcMovieContext": "Server=(localdb)\\mssqllocaldb;Database=MvcMovieContext-1;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}

22.I added this code according to the toutril and made cahnges with the name according to my application

Scaffold movie pages :- 

In Solution Explorer, right-click the Controllers folder > Add > New Scaffolded Item.

23. The InitialCreate class
Examine the Migrations/{timestamp}_InitialCreate.cs migration file:

public partial class InitialCreate : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Movie",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:ValueGenerationStrategy", 
                                 SqlServerValueGenerationStrategy.IdentityColumn),
                Title = table.Column<string>(nullable: true),
                ReleaseDate = table.Column<DateTime>(nullable: false),
                Genre = table.Column<string>(nullable: true),
                Price = table.Column<decimal>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Movie", x => x.Id);
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Movie");
    }
}
24.I added this code according to the toutril and made cahnges with the name according to my application 
@model IEnumerable<MvcMovie.Models.Movie>

@{
    ViewData["Title"] = "Index";
}

<h1>Index</h1>

<p>
    <a asp-action="Create">Create New</a>
</p>
<table class="table">
    <thead>
        <tr>
            <th>
                @Html.DisplayNameFor(model => model.Title)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.ReleaseDate)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Genre)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Price)
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
@foreach (var item in Model) {
        <tr>
            <td>
                @Html.DisplayFor(modelItem => item.Title)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.ReleaseDate)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Genre)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Price)
            </td>
            <td>
                <a asp-action="Edit" asp-route-id="@item.Id">Edit</a> |
                <a asp-action="Details" asp-route-id="@item.Id">Details</a> |
                <a asp-action="Delete" asp-route-id="@item.Id">Delete</a>
            </td>
        </tr>
}
    </tbody>
</table>

26. 





