using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    
    public class QuoteManager : IQuoteService
    {
        IQuoteDal _quoteDal;

        public QuoteManager(IQuoteDal quoteDal)
        {
            _quoteDal = quoteDal;
        }

        public void AddQuote(Quote quote)
        {
            _quoteDal.Add(quote);
        }

        public void DeleteQuote(Quote quote)
        {
            _quoteDal.Delete(quote);
        }

        public Quote GetProjectById(int id)
        {
            return _quoteDal.Get(x => x.QuoteID == id);
            
        }

        public List<Quote> GetQuoteList()
        {
            return _quoteDal.List();
        }

        public void UpdateQuote(Quote quote)
        {
            _quoteDal.Update(quote);
        }
    }
}
