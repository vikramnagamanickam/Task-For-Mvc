using DataAccessLayer.Entity;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class CricketerRepository : ICricketerRepository
    {

        CricketerDbContext con = null;


            public CricketerRepository(IConfiguration configuration , CricketerDbContext regs)
            {
            con = regs;
            }
       
            public void InsertDetail(CricketerDetails loc)
            {

                try
                {
                    con.Add(loc);
                    con.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw;
                }

            }

            public List<CricketerDetails> GetAllDetail()
            {
                try
            { 
                    return con.CricketerDetail.ToList();

                }
                catch (Exception ex)
                {
                    throw;
                }

            }

            public CricketerDetails GetplayerbyId(long id)
            {
                try
                {
                return con.CricketerDetail.Find(id);

                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            public void UpdateDetail(CricketerDetails loc)
            {
                try
                {
                    con.Update(loc);
                    con.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw;
                }

            }


            public void DeleteDetail(long id)
            {
                try
                {
                    var count = con.CricketerDetail.Find(id);
                    con.CricketerDetail.Remove(count);
                    con.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }


    }
}





        
    

