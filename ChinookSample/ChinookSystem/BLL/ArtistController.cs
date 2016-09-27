using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel; //ODS
using ChinookSystem.Data.Entities;
using ChinookSystem.Data.POCOs;
using ChinookSystem.DAL;
#endregion

namespace ChinookSystem.BLL
{
    [DataObject]
   public class ArtistController
    {
        //report a dataset containing data from 
        //multiple entities
        //this will use Linq to Entity Access 
        //POCO Classes will be use to define the data
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<ArtistAlbums> ArtistAlbums_Get()
        {
            //Set up Transaction Area 
            using (var context = new ChinookContext())
            {
                //when you bring the query from linq pad to your program you must change the refrences to the datasource

                //you may also need to change your navigation refrencing use in linqPad
                //to the navigation properties you stated in the Entity class definitions
                var results = from x in context.Albums
                              where x.ReleaseYear == 2008
                              orderby x.Artists.Name, x.Title
                              select new ArtistAlbums
                              {
                                  //Name and Titles are POCO 
                                  //Class property names
                                  Name = x.Artists.Name,
                                 Title = x.Title
                              };
                //the following requires the query data in memory
                //.ToList()
                //At this point the query will actually execute
                return results.ToList();
            }
        }
    }
}
