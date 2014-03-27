using Newtonsoft.Json;
using Partisk.API.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Partisk.API
{
    public class PartiskClient : IDisposable
    {
        private HttpClient _client = new HttpClient
        {
            BaseAddress = new Uri("https://www.partisk.nu/api/", UriKind.Absolute)
        };
        
        private static PartiskClient _service;
        public static PartiskClient GetClient()
        {
            if(_service == null)
                _service = new PartiskClient();
                
            return _service;
        }

        public async Task<PartiskQuestion[]> GetQuestionsAsync()
        {
            var urlSuffix = "questions/";
            var questions = await _getAsync<PartiskQuestion[]>(urlSuffix);
            return questions;
        }
        public async Task<PartiskQuestion> GetQuestionAsync(string id)
        {
            var urlSuffix = string.Format("questions/{0}", id);
            var question = await _getAsync<PartiskQuestion>(urlSuffix);
            return question;
        }

        public async Task<PartiskAnswer[]> GetAnswersAsync()
        {
            var urlSuffix = "answers/";
            var answers = await _getAsync<PartiskAnswer[]>(urlSuffix);
            return answers;
        }
        public async Task<PartiskAnswer> GetAnswerAsync(string id)
        {
            var urlSuffix = string.Format("answers/{0}", id);
            var answer = await _getAsync<PartiskAnswer>(urlSuffix);
            return answer;
        }

        public async Task<PartiskParty[]> GetPartiesAsync()
        {
            var urlSuffix = "parties/";
            var parties = await _getAsync<PartiskParty[]>(urlSuffix);
            return parties;
        }
        public async Task<PartiskParty> GetPartyAsync(string id)
        {
            var urlSuffix = string.Format("parties/{0}", id);
            var party = await _getAsync<PartiskParty>(urlSuffix);
            return party;
        }

        public async Task<PartiskTag[]> GetTagsAsync()
        {
            var urlSuffix = "tags/";
            var tags = await _getAsync<PartiskTag[]>(urlSuffix);
            return tags;
        }
        public async Task<PartiskTag> GetTagAsync(string id)
        {
            var urlSuffix = string.Format("tags/{0}", id);
            var tag = await _getAsync<PartiskTag>(urlSuffix);
            return tag;
        }


        public PartiskQuestion[] GetQuestions()
        {
            return AsyncHelper.RunSync(() => GetQuestionsAsync());
        }
        public PartiskQuestion GetQuestion(string id)
        {
            return AsyncHelper.RunSync(() => GetQuestionAsync(id));
        }

        public PartiskAnswer[] GetAnswers()
        {
            return AsyncHelper.RunSync(() => GetAnswersAsync());
        }
        public PartiskAnswer GetAnswer(string id)
        {
            return AsyncHelper.RunSync(() => GetAnswerAsync(id));
        }

        public PartiskParty[] GetParties()
        {
            return AsyncHelper.RunSync(() => GetPartiesAsync());
        }
        public PartiskParty GetParty(string id)
        {
            return AsyncHelper.RunSync(() => GetPartyAsync(id));
        }

        public PartiskTag[] GetTags()
        {
            return AsyncHelper.RunSync(() => GetTagsAsync());
        }
        public PartiskTag GetTag(string id)
        {
            return AsyncHelper.RunSync(() => GetTagAsync(id));
        }


        private async Task<T> _getAsync<T>(string urlSuffix)
        {
            var response = await _client.GetAsync(urlSuffix);

            if (!response.IsSuccessStatusCode)
                throw new Exception("An error occured while requesting the question.");

            var responseBody = await response.Content.ReadAsStringAsync();

            // DateTime does not know what a bunch of zeroes are.
            responseBody = responseBody.Replace("0000-00-00 00:00:00", "1970-01-01 00:00:00");

            return await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<T>(responseBody));
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}
