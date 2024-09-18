using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    
        public interface ICricketerRepository
        {
        public void InsertDetail(CricketerDetails loc);
        public List<CricketerDetails> GetAllDetail();
        public CricketerDetails GetplayerbyId(long id);

        public void UpdateDetail(CricketerDetails loc);

        public void DeleteDetail(long id);
        }
    

}

