using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion
namespace ChinookSystem.Data.Entities
{
    //point to the sql table that this file maps
    [Table("Albums")]
    public class Album
    {
        //Key notation is optional if the sql pKey
        //ends in ID or Id
        //required if default of entity is Not Identity
        //required if pKey is compound

        //Properties can be fully implemented or Auto implemented
        //property names should use sql attribute name
        //properties should be listed in the same order as Sql table attributes for easy of maitainance

        [Key]
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public int ReleaseYear { get; set; }
        public string ReleaseLabel { get; set; }

        //navigation properties for use by Linq
        //these properties will be of type virtual
        //there are two types of navigation properties
        //properties that point to "children" use ICollection<T>
        //properties that point to "Parent" use ParentName as the datatype
        public virtual ICollection<Track> Tracks { get; set; }
        public virtual Artist Artists { get; set; }
    }
}
