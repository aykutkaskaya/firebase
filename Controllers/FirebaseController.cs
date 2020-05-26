using System.Reflection.Metadata;
using System.Text;
using System.Net;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Firebase_a.Models;
using Newtonsoft.Json;

namespace Firebase_a.Controllers
{
    public class FirebaseController : Controller
    {

        //TODO: Önce oluşturduğunuz Firebase Base Adress URL'sini ekleyin.
        string baseAddress = "";

        public async Task<IActionResult> Index()
        {
            ResponseResult vm = new ResponseResult();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(baseAddress + ".json"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (apiResponse != "null")
                        vm = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
                }
            }
            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> User(string id)
        {
            Models.User vm = new Models.User();

            if (id != null)
            {
                //existing recored
                using (var httpClient = new HttpClient())
                {
                    string url = baseAddress + "users/" + id + ".json";
                    using (var response = await httpClient.GetAsync(url))
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            vm = JsonConvert.DeserializeObject<Models.User>(apiResponse);
                        }
                    }
                }

                ViewBag.ItemId=id;
            }

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> User(Models.User vm, string id)
        {
            if (id != null)
            {
                //existing record
                using (var httpClient = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(vm);
                    var data = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");
                    string url = baseAddress + "users/" + id + ".json";

                    using (var response = await httpClient.PutAsync((url), data))
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            return RedirectToAction("Error", "Home");
                        }
                    }
                }
            }
            else
            {
                using (var httpClient = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(vm);
                    var data = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");

                    using (var response = await httpClient.PostAsync((baseAddress + "users.json"), data))
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            return RedirectToAction("Error", "Home");
                        }
                    }
                }
            }

        }

        [HttpPost]
        public async Task<IActionResult> UserDelete(string id)
        {
            if (id != null)
            {
                //existing record
                using (var httpClient = new HttpClient())
                {
                    string url = baseAddress + "users/" + id + ".json";

                    using (var response = await httpClient.DeleteAsync(url))
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            return RedirectToAction("Error", "Home");
                        }
                    }
                }
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        [HttpGet]
        public async Task<IActionResult> Brand(string id)
        {

            Models.Brand vm = new Models.Brand();

            if (id != null)
            {
                //existing recored
                using (var httpClient = new HttpClient())
                {
                    string url = baseAddress + "brands/" + id + ".json";
                    using (var response = await httpClient.GetAsync(url))
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            vm = JsonConvert.DeserializeObject<Models.Brand>(apiResponse);
                        }
                    }
                }

                ViewBag.ItemId=id;

            }

            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Brand(Models.Brand vm, string id)
        {
            if (id != null)
            {
                //existing record

                using (var httpClient = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(vm);
                    var data = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");

                    string url = baseAddress + "brands/" + id + ".json";

                    using (var response = await httpClient.PutAsync((url), data))
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            return RedirectToAction("Error", "Home");
                        }
                    }
                }
            }

            else
            {
                using (var httpClient = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(vm);
                    var data = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");
                    string url = baseAddress + "brands.json";

                    using (var response = await httpClient.PostAsync((url), data))
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            return RedirectToAction("Error", "Home");
                        }
                    }
                }
            }
        }

        [HttpPost]
        public async Task<IActionResult> BrandDelete(string id)
        {
            if (id != null)
            {
                //existing record
                using (var httpClient = new HttpClient())
                {
                    string url = baseAddress + "brands/" + id + ".json";

                    using (var response = await httpClient.DeleteAsync(url))
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            return RedirectToAction("Error", "Home");
                        }
                    }
                }
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
    }
}