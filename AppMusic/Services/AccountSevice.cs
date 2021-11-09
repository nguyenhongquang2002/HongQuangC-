using AppMusic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace AppMusic.Services
{
    public class AccountSevice
    {
        private static string ApibaseUrl = "https://music-i-like.herokuapp.com/accounts";
        private static string ApiLoginPath = "/api/vl/accounts/authentication";
        private static string ApiRegsiterPath = "/api/vl/accounts/";
        private static string ApiDataType = "/application/json";

        public async Task<bool> Login(Account account)
        {
            try
            {
                using(var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(ApibaseUrl);
                    var jsoncontent = Newtonsoft.Json.JsonConvert.SerializeObject(account);
                    var contentTosend = new StringContent(jsoncontent, Encoding.UTF8, ApiDataType);
                    var result = await httpClient.PostAsync(ApiLoginPath, contentTosend);
                    string rerultContent = await result.Content.ReadAsStringAsync();
                    return true;
                                                    
                }

            }catch(Exception e)
            {
                ContentDialog dialog = new ContentDialog();
                dialog.Title = "Error!";
                dialog.Content = $"{e.Message}";
                dialog.CloseButtonText = "OK";
                await dialog.ShowAsync();
                return false;
            }
        }
        public async Task<bool> Register(Account account)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(ApibaseUrl);
                    var jsoncontent = Newtonsoft.Json.JsonConvert.SerializeObject(account);
                    var contentTosend = new StringContent(jsoncontent, Encoding.UTF8, ApiDataType);
                    var result = await httpClient.PostAsync(ApiRegsiterPath, contentTosend);
                    string rerultContent = await result.Content.ReadAsStringAsync();
                    return true;

                }

            }
            catch (Exception e)
            {
                ContentDialog dialog = new ContentDialog();
                dialog.Title = "Error!";
                dialog.Content = $"{e.Message}";
                dialog.CloseButtonText = "OK";
                await dialog.ShowAsync();
                return false;
            }
        }
    }
}
