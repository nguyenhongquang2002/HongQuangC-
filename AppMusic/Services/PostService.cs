﻿using AppMusic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppMusic.Services
{
    public class PostService
    {
        private static string ApiBaseUrl = "https://jsonplaceholder.typicode.com";
        private static string ApiPostPath = "/posts";
        private static string ApiDataType = "application/json";
        public async Task<bool> Save(Post post)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ApiBaseUrl);
                    var jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(post);
                    var contentToSend = new StringContent(jsonContent, Encoding.UTF8, ApiDataType);
                    var result = await client.PostAsync(ApiPostPath, contentToSend);
                    string resultContent = await result.Content.ReadAsStringAsync();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<List<Post>> FindAll()
        {
            List<Post> list = new List<Post>();
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(ApiBaseUrl);
                    var result = await httpClient.GetAsync(ApiPostPath); // gửi request lên server.
                    var resultContent = await result.Content.ReadAsStringAsync(); // lấy dữ liệu trả về định dạng json.
                    Console.WriteLine(resultContent);
                    // ép kiểu dữ liệu trả về thành danh sách post.
                    list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Post>>(resultContent);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return list;
        }

        public async Task<Post> FindById(string id)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(ApiBaseUrl);
                    var result = await httpClient.GetAsync($"{ApiPostPath}/{id}"); // gửi request lên server.
                    var resultContent = await result.Content.ReadAsStringAsync(); // lấy dữ liệu trả về định dạng json.
                    Console.WriteLine(resultContent);
                    // ép kiểu dữ liệu trả về thành danh sách post.
                    var post = Newtonsoft.Json.JsonConvert.DeserializeObject<Post>(resultContent);
                    return post;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<bool> Update(int id, Post updatePost)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ApiBaseUrl);
                    // tạo dữ liệu update kiểu json.
                    var jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(updatePost);
                    var contentToSend = new StringContent(jsonContent, Encoding.UTF8, ApiDataType);
                    var result = await client.PutAsync($"{ApiPostPath}/{id}", contentToSend);
                    var resultContent = await result.Content.ReadAsStringAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ApiBaseUrl);
                    var result = await client.DeleteAsync($"{ApiPostPath}/{id}");
                    var resultContent = await result.Content.ReadAsStringAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }

}