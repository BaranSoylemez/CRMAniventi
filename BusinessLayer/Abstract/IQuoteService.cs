using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IQuoteService
    {
        List<Quote> GetQuoteList();
        void AddQuote(Quote quote);
        void DeleteQuote(Quote quote);
        void UpdateQuote(Quote quote);
        Quote GetProjectById(int id);
    }
}
