using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace bookstore.Models
{
  public class Book
  {

    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Condition { get; set; }
    public bool Available { get; set; }


    public static List<Book> GetBooks()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Book> bookList = JsonConvert.DeserializeObject<List<Book>>(jsonResponse.ToString());
      return bookList;
    }
  }
}