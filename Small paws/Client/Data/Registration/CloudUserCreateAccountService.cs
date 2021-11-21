﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Client.Model;

namespace Client.Data.Registration
{
    public class CloudUserCreateAccountService : IUserCreateAccountService
    {
        private readonly HttpClient _httpClient;
        private const string Uri = "http://localhost:8090";

        public CloudUserCreateAccountService()
        {
            _httpClient = new HttpClient();
        }

  

        public async Task<int> checkUserName(string userName)
        {
            Console.WriteLine("Checking username");
            
            var endUser = new EndUser()
            {
                UserName = userName,
                Password = "",
            };
            
            var userNameAsJson = JsonSerializer.Serialize(endUser);
            HttpContent httpContent = new StringContent(
                userNameAsJson,
                Encoding.UTF8,
                "application/json");
            Console.WriteLine("Here");
            var responseMessage = await _httpClient.PostAsync(Uri + "/userName", httpContent);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
            Console.WriteLine("Here2");

            var message = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<int>(message);
            
            return result;
        }


        public async Task<int> CreateUserAsync(PetOwner petOwner)
        { 
           
            var userAsJson = JsonSerializer.Serialize(petOwner);
            HttpContent httpContent = new StringContent(
                userAsJson,
                Encoding.UTF8,
                "application/json");
            var responseMessage = await _httpClient.PostAsync(Uri + "/newAccount", httpContent);
            
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
            var message = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<int>(message);
            return result;
        }
    }
}