using QuotesApp.model;
using QuotesApp.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesApp.AppServices
{

    public interface IQuotesService
    {
        Task<List<QuotesModel>> FetchQuotes();


    }

    public class QuotesServices : IQuotesService
    {

        public async Task<List<QuotesModel>> FetchQuotes()
        {
            QuotesClient<QuotesModel> quotesClient = new QuotesClient<QuotesModel>();
            try
            {
                var apiResponse = await quotesClient.GetQuotes();

                if (apiResponse != null)
                {
                    var data = apiResponse;
                    return data;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception e)
            {


                Console.WriteLine(e.Message);
                throw e;
            }

        }
    }
}
