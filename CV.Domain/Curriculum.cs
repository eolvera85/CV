using System;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CV.Models;
using System.Collections.Generic;

namespace CV.Domain
{
    public class Curriculum : ICurriculum
    {
        string BaseUrl = "https://localhost:44383/api/";


        public async Task<Models.Curriculum> GetCurriculum(int value)
        {
            Models.Curriculum _cv = null;
            string controllerAction;

            controllerAction = String.Format("curriculum/{0}", value);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(controllerAction);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;

                    _cv = JsonConvert.DeserializeObject<Models.Curriculum>(json);
                }
            }

            return _cv;
        }

        public async Task<Models.Document> GetDocument(int value)
        {
            Models.Document document = null; ;
            string controllerAction;

            controllerAction = String.Format("curriculum/document/{0}", value);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(controllerAction);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;

                    document = JsonConvert.DeserializeObject<Models.Document>(json);
                }
            }

            return document;
        }

        public async Task<Models.AboutMe> GetAboutMe(int value)
        {
            Models.AboutMe aboutMe = null;
            string controllerAction;

            controllerAction = String.Format("aboutme/{0}", value);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(controllerAction);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;

                    aboutMe = JsonConvert.DeserializeObject<Models.AboutMe>(json);
                }
            }

            return aboutMe;
        }

        public async Task<List<Models.Experience>> GetExperiences(int value)
        {
            List<Models.Experience> experiences = new List<Experience>();

            string controllerAction;

            controllerAction = String.Format("experiences/{0}", value);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(controllerAction);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;

                    experiences = JsonConvert.DeserializeObject<List<Models.Experience>>(json);
                }
            }

            return experiences;
        }

        public async Task<Models.Formation> GetFormation(int value)
        {
            Models.Formation formation = new Models.Formation();

            string controllerAction;

            controllerAction = String.Format("formation/{0}", value);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(controllerAction);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;

                    formation = JsonConvert.DeserializeObject<Models.Formation>(json);
                }
            }

            return formation;
        }

        public async Task<Models.Skills> GetSkills(int value)
        {
            Models.Skills skills = new Models.Skills();

            string controllerAction;

            controllerAction = String.Format("skills/{0}", value);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(controllerAction);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;

                    skills = JsonConvert.DeserializeObject<Models.Skills>(json);
                }
            }

            return skills;
        }

        public async Task<bool> SaveContact(Models.Contact contact)
        {
            StringContent content;
            bool result = false;
            string controllerAction;

            controllerAction = "contact";
            content = new StringContent(JsonConvert.SerializeObject(contact), Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsync(controllerAction, content);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;

                    result = JsonConvert.DeserializeObject<bool>(json);
                }
            }

            return result;
        }
    }
}
