//public class http
//{

//    public int id { get; set; }
//    public string url { get; set; }
//    public int width { get; set; }
//    public int height { get; set; }

//    public http(int id, string url, int width, int height)
//    {
//        this.id = id;
//        this.url = url;
//        this.width = width;
//        this.height = height;
//    }




//}
//internal class Program
//{
//    static async Task Main(string[] args)
//    {
//            //Env.Load("C:\\Users\\HP\\Desktop\\c -sharp\\My_comando_progect\\.env");
//            //string apyKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY");
//            //Console.WriteLine(apyKey);
//            //Game game = new Game();
//            //game.factory.Factory_Commando("HJ", "JHJ");
//            //game.factory.Factory_AirComando("HJ", "JHJ");

////game.enemyFactory.Creat_enemi("כעי");
////game.wEAPON_FACTORY.WEAPON_FACTORY("m16","a",89);






//HttpClient clint = new HttpClient();
//http http = new http(3, "https://api.thecatapi.com/v1/images/search", 30, 55);
//string json = JsonSerializer.Serialize(http);
//var obj = new StringContent(json);
//var response = await clint.PostAsync( , obj);

//string url = "https://api.thecatapi.com/v1/images/search";
//var r = await clint.GetAsync(url);
//string ansewer = await r.Content.ReadAsStringAsync();

//http[] list_arr = JsonSerializer.Deserialize<http[]>(ansewer);
//Console.WriteLine(list_arr[0].width);