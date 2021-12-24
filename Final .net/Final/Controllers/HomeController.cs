using Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        public IConfiguration Configuration { get; }
        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Cart()
        {
            decimal t = 0;
            List<Cart> cartList = new List<Cart>();
            string connectionString = Configuration["ConnectionStrings:Myconnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "select * from Cart";
                SqlCommand command = new SqlCommand(sql, connection);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Cart products = new Cart();
                        products.Cart_id = Convert.ToInt32(dataReader["Cart_id"]);
                        products.Book_image = Convert.ToString(dataReader["Book_image"]);
                        products.Book_name = Convert.ToString(dataReader["Book_name"]);
                        products.Cost = Convert.ToDecimal(dataReader["Cost"]);
                        t = t + products.Cost;
                        cartList.Add(products);
                    }
                }
                connection.Close();
                ViewBag.counter = cartList.Count();
                ViewBag.Total = t;
            }
                return View(cartList);
        }
        public IActionResult StoryBooks()
        {
            List<Books> BooksList = new List<Books>();

            string connectionString = Configuration["ConnectionStrings:Myconnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "select * from Books where Book_type='Story Books'";
                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Books Books = new Books();
                        Books.Id = Convert.ToInt32(dataReader["Id"]);
                        Books.Book_image = Convert.ToString(dataReader["Book_image"]);
                        Books.Book_name = Convert.ToString(dataReader["Book_name"]);
                        Books.Cost = Convert.ToDecimal(dataReader["Cost"]);

                        BooksList.Add(Books);
                    }
                }

                connection.Close();
            }
            return View(BooksList);
        }
        public IActionResult SubjectBooks()
        {
            List<Books> BooksList = new List<Books>();

            string connectionString = Configuration["ConnectionStrings:Myconnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "select * from Books where Book_type='Subject Books'";
                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Books Books = new Books();
                        Books.Id = Convert.ToInt32(dataReader["Id"]);
                        Books.Book_image = Convert.ToString(dataReader["Book_image"]);
                        Books.Book_name = Convert.ToString(dataReader["Book_name"]);
                        Books.Cost = Convert.ToDecimal(dataReader["Cost"]);

                        BooksList.Add(Books);
                    }
                }

                connection.Close();
            }
            return View(BooksList);
        }
        public IActionResult ActivityBooks()
        {
            List<Books> BooksList = new List<Books>();

            string connectionString = Configuration["ConnectionStrings:Myconnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "select * from Books where Book_type='Activity Books'";
                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Books Books = new Books();
                        Books.Id = Convert.ToInt32(dataReader["Id"]);
                        Books.Book_image = Convert.ToString(dataReader["Book_image"]);
                        Books.Book_name = Convert.ToString(dataReader["Book_name"]);
                        Books.Cost = Convert.ToDecimal(dataReader["Cost"]);

                        BooksList.Add(Books);
                    }
                }

                connection.Close();
            }
            return View(BooksList);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            Books Books = new Books();
            string connectionString = Configuration["ConnectionStrings:Myconnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"Select * from Books where id='{id}'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Books.Id = Convert.ToInt32(dataReader["Id"]);
                        Books.Book_image = Convert.ToString(dataReader["Book_image"]);
                        Books.Book_name = Convert.ToString(dataReader["Book_name"]);
                        Books.Book_type = Convert.ToString(dataReader["Book_type"]);
                        Books.Author = Convert.ToString(dataReader["Author"]);
                        Books.Cost = Convert.ToDecimal(dataReader["Cost"]);
                    }
                }

                connection.Close();

            }
            return View(Books);
        }
        [HttpPost]
        public IActionResult Details(int id, Books books)
        {
            string connectionString = Configuration["ConnectionStrings:Myconnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"Insert Into Cart (Book_image, Book_name, Cost, Id) Values ('{books.Book_image}','{books.Book_name}','{books.Cost}','{books.Id}')";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            ViewBag.Result = "Book is added to the Cart";
            return View();
        }

        
        public IActionResult Signup(Users Users)
        {
            string connectionString = Configuration["ConnectionStrings:MyConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"Insert Into Users (User_name, User_id, User_password) Values ('{Users.User_name}', '{Users.User_id}','{Users.User_password}')";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            ViewBag.Result = 1;
            return View();
        }

        public IActionResult Login(Users Users)
        {
            var check = 1;
            string connectionString = Configuration["ConnectionStrings:MyConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"Select User_id,User_password From Users where User_id = '{Users.LoginEmail}' and User_password = '{Users.LoginPassword}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;

                    connection.Open();
                    var validate = command.ExecuteScalar();
                    if (validate != null)
                    {
                        check = 0;

                    }
                    connection.Close();
                }

            }
            if (check == 0)
            {

                return RedirectToAction("Index");
            }
            else
            {

                ViewBag.Query = 1;
                return RedirectToAction("Login");
            }

            
        }
    }
}
