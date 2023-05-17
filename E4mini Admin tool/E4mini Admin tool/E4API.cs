using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;


namespace E4mini_Admin_tool
{
    internal class E4API
    {
<<<<<<< HEAD
        public async Task<string>  Getter(string baseCurrency, string quoteCurrency)
=======
        public async Task<string> Getter(string baseCurrency, string quoteCurrency)
>>>>>>> Была попытка изменить код для лучшего вывода сообшения
        {
            JsonContent content;
            string answer;

            using (var httpClient = new HttpClient())
            {
                //using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://127.0.0.1:3000/order_book/" + baseCurrency + "-" + quoteCurrency))
<<<<<<< HEAD
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://127.0.0.1:3000/order_book"))
                {
                    //Нихуя не понял шо тут ордербук делает, когда должен быть POST admin/pair
                    //Но для теста сойдёт
                    HttpResponseMessage response;
                    try
                    {

                        response = await httpClient.SendAsync(request);
                    }
                    catch (System.Net.Http.HttpRequestException)
                    {
                        return "Hueta, no connection";
                    }

                    answer = await response.Content.ReadAsStringAsync();
                }               
=======
                /*using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://127.0.0.1:3000/order_book"))
                {*/
                    //Нихуя не понял шо тут ордербук делает, когда должен быть POST admin/pair
                    //Но для теста сойдёт
                    HttpResponseMessage response;
                    var content2 = new StringContent(
 $"{{\"base_currency\": \"{baseCurrency}\", \"quote_currency\": \"{quoteCurrency}\"}}",
 Encoding.UTF8,
                "application/json");

                    try
                    {

                        response = await httpClient.PostAsync("http://127.0.0.1:3000/admin", content2);
                    }
                    catch (System.Net.Http.HttpRequestException)
                    {
                        return "Error, no connection";
                    }

                    answer = await response.Content.ReadAsStringAsync();
                //}
>>>>>>> Была попытка изменить код для лучшего вывода сообшения
            }
            return answer;
        }
    }
}